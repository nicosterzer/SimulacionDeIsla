using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace TP1LAB2_2
{

    internal class Isla
    {
        protected int cantQuesos;
        protected int cantRatones;
        protected int ancho;
        protected int alto;

        protected Form1 aux;

        protected ArrayList piezas = new ArrayList();
        protected ArrayList muertos = new ArrayList();
        public int ContPiezas
        {
            get
            {
                return piezas.Count ;
            }
        }
        public int Ratones
        {
            get { return cantRatones; }
        }
        public int Quesos
        {
            get { return cantQuesos; }
        }
        virtual public object this[int pos]
        {
            get
            {
                if (piezas[pos] is Queso)
                {
                    return (Queso)piezas[pos];
                }
                else if (piezas[pos] is Raton)
                {
                    return ((Raton)piezas[pos]);
                }
                else
                {
                    return null;
                }
            }
        }
        public Isla(int ancho, int alto, int cantQuesos, int cantRatones, Form1 f)
        {
            this.ancho = ancho;
            this.alto = alto;
            this.cantQuesos = cantQuesos;
            this.cantRatones = cantRatones;
            for (int i = 0; i < cantRatones; i++)
            {
                piezas.Add(new Raton(ancho, alto));
            }
            for (int i = 0; i < cantQuesos; i++)
            {
                piezas.Add(new Queso(ancho, alto));
            }
            aux = f;
        }
        public virtual void MoverPiezas()
        {
            for (int i = 0; i < piezas.Count; i++)
            {
                //Mover todas las piesas de tipo animal;
                if (piezas[i] is Animal)
                {
                    ((Animal)piezas[i]).Mover();
                }
            }
            ComprobacionFueraDeRango();
            ComprobacionDeReproducir();
            ComprobacionDeMuerte();
            ComprobacionDeComerParaRaton();
            InformeDeEntidades();
        }
        void ComprobacionFueraDeRango()
        {
            for (int i = 0; i < piezas.Count; i++)
            {
                if (piezas[i] is Animal)
                {
                    int x = ((Animal)piezas[i]).GetPosicionX();
                    int y = ((Animal)piezas[i]).GetPosicionY();
                    if (x >= alto || x < 0 || y >= ancho || y < 0 )
                    {
                        muertos.Add(piezas[i]);
                        piezas.Remove(piezas[i]);
                        cantRatones--;
                        aux.listBox1.Items.Add("Un raton se cayo al agua.");
                    }
                }               
            }
        }
        void ComprobacionDeReproducir()
        {
            for (int i = 0; i < piezas.Count - 1; i++)
            {
                for (int j = i + 1; j < piezas.Count; j++)
                {
                    if (piezas[i] is Raton && piezas[j] is Raton)
                    {
                        int iX = ((Animal)piezas[i]).GetPosicionX();
                        int iY = ((Animal)piezas[i]).GetPosicionY();
                        int jX = ((Animal)piezas[j]).GetPosicionX();
                        int jY = ((Animal)piezas[j]).GetPosicionY();
                        if (iX == jX && iY == jY)//Comparamos posiciones
                        {
                            if (((Raton)piezas[i]).CompareTo(piezas[j]) != 0)
                            {
                                Raton[] nuevos;
                                nuevos = ((Raton)piezas[i]).Reproducirse();
                                int x = 0;
                                //Añadir los ratones hijos;
                                for (int z = 0; z < nuevos.Length; z++)
                                {
                                    piezas.Add(nuevos[z]);
                                    cantRatones++;
                                }
                                //añade los quesos por la creacion de nuevos ratones;
                                if (nuevos.Length == 3 || nuevos.Length == 5)
                                {
                                    x = ((nuevos.Length + 1) / 2);
                                    for (int d = 0; d < x; d++)
                                    {
                                        piezas.Add(new Queso(ancho, alto));
                                        cantQuesos++;
                                    }
                                }
                                else
                                {
                                    for (int d = 0; d < (nuevos.Length / 2); d++)
                                    {
                                        piezas.Add(new Queso(ancho, alto));
                                        cantQuesos++;
                                    }
                                }
                                aux.listBox1.Items.Add("Dos ratones de sexos opuestos se encontraron y tuvieron " + nuevos.Length + " ratones nuevos. Y se generaron " + x + " quesos nuevos.");
                            }
                        }                       
                    }
                }
            }
        }
        protected virtual void ComprobacionDeMuerte()
        {
            for (int i = 0; i < piezas.Count; i++)
            {
                if (piezas[i] is Animal)
                {
                    if (((Animal)piezas[i]).ChequearVida().Ticks != 0)
                    {
                        muertos.Add(piezas[i]);
                        piezas.Remove(piezas[i]);
                        aux.listBox1.Items.Add("Un raton murio de hambre.");
                        cantRatones--;
                    }
                }
            }
        }
        void ComprobacionDeComerParaRaton() 
        {
            for (int i = 0; i < piezas.Count - 1; i++)
            {
                for (int j = i + 1; j < piezas.Count; j++)
                {
                    if (piezas[i] is Queso && piezas[j] is Raton)
                    {
                        int iX = ((Queso)piezas[i]).GetPosicionX();
                        int iY = ((Queso)piezas[i]).GetPosicionY();
                        int jX = ((Animal)piezas[j]).GetPosicionX();
                        int jY = ((Animal)piezas[j]).GetPosicionY();
                        if (iX == jX && iY == jY)
                        {
                            piezas.Remove(piezas[i]);
                            cantQuesos--;
                            ((Raton)piezas[j]).Comer();
                            aux.listBox1.Items.Add("Un Raton comio un queso en la posicion: X: " + ((Raton)piezas[j]).GetPosicionX() + "Y: " + ((Raton)piezas[j]).GetPosicionY());
                        }
                    }
                }
            }
        }    
        protected void InformeDeEntidades()
        {
            for (int i = 0; i < piezas.Count; i++)
            {
                if (piezas[i] is Queso)
                {
                    aux.listBox2.Items.Add("Hay un queso en la posicion: X: " + ((Queso)piezas[i]).GetPosicionX() + " Y: " + ((Queso)piezas[i]).GetPosicionY());
                    aux.listBox2.Items.Add("-----------------------------------------------------------------------------");
                }              
                else if (piezas[i] is Raton)
                {
                    aux.listBox2.Items.Add("Hay un Raton"+ ((Raton)piezas[i]).Sexo + " en la posicion: X: " + ((Raton)piezas[i]).GetPosicionX() + " Y: " + ((Raton)piezas[i]).GetPosicionY());
                    aux.listBox2.Items.Add("Y se comio " + ((Raton)piezas[i]).QuesosComidos + " quesos");
                    aux.listBox2.Items.Add("Y la ultima vez que comio fue hace " + ((Raton)piezas[i]).DiasSinComer + " dias");
                    aux.listBox2.Items.Add("-----------------------------------------------------------------------------");
                }
                else if (piezas[i] is Gato)
                {
                    aux.listBox2.Items.Add("Hay un Gato en la posicion: X: " + ((Gato)piezas[i]).GetPosicionX() + " Y: " + ((Gato)piezas[i]).GetPosicionY());
                    aux.listBox2.Items.Add("Y se comio " + ((Gato)piezas[i]).RatonesComidos + " ratones");
                    aux.listBox2.Items.Add("Y la ultima vez que comio fue hace " + ((Gato)piezas[i]).DiasSinComer + " dias");
                    aux.listBox2.Items.Add("-----------------------------------------------------------------------------");
                }
            }
        }
        public ListBox InformeDeFinDePartida()
        {
            ListBox informeFinal = new ListBox();
            for (int i = 0; i < muertos.Count; i++)
            {
                if (muertos[i] is Raton)
                {
                    informeFinal.Items.Add("Un Raton vivio: " + ((Animal)muertos[i]).ChequearVida().Minute.ToString("00") + ((Animal)muertos[i]).ChequearVida().Second.ToString("00"));
                }
                else if (muertos[i] is Gato)
                {
                    informeFinal.Items.Add("Un Gato vivio: " + ((Animal)muertos[i]).ChequearVida().Minute.ToString("00") + ((Animal)muertos[i]).ChequearVida().Second.ToString("00"));
                }
            }
            return informeFinal;
        }
    }
    class Isla2 : Isla
    {       
        int cantGatos;
        public int Gatos
        {
            get { return cantGatos; }
        }
        public override object this[int pos]
        {
            get
            {
                if (piezas[pos] is Queso)
                {
                    return (Queso)piezas[pos];
                }
                else if (piezas[pos] is Raton)
                {
                    return ((Raton)piezas[pos]);
                }
                else if (piezas[pos] is Gato)
                {
                    return ((Gato)piezas[pos]);
                }
                else
                {
                    return null;
                }
            }
        }
        public Isla2(int ancho, int alto, int cantQuesos, int cantRatones, int cantGatos, Form1 f) : base(ancho, alto, cantQuesos, cantRatones , f)
        {
            this.cantGatos = cantGatos;
            for (int i = 0; i < cantGatos; i++)
            {
                piezas.Add(new Gato(ancho, alto));
            }
        }
        public override void MoverPiezas()
        {
            base.MoverPiezas();
            ComprobacionDeMuerte();
            ComprobacionDeComerParaGato();
            InformeDeEntidades();
        }
        void ComprobacionDeComerParaGato()
        {
            for (int i = 0; i < piezas.Count - 1; i++)
            {
                for (int j = i + 1; j < piezas.Count; j++)
                {
                    if (piezas[i] is Raton && piezas[j] is Gato)
                    {
                        int iX = ((Animal)piezas[i]).GetPosicionX();
                        int iY = ((Animal)piezas[i]).GetPosicionY();
                        int jX = ((Animal)piezas[j]).GetPosicionX();
                        int jY = ((Animal)piezas[j]).GetPosicionY();
                        if (iX == jX && iY == jY)
                        {
                            muertos.Add(piezas[i]);
                            piezas.Remove(piezas[i]);
                            cantRatones--;
                            ((Gato)piezas[j]).Comer();
                            aux.listBox1.Items.Add("Un Gato comio un Raton en la posicion: X: " + ((Gato)piezas[j]).GetPosicionX() + " Y: " + ((Gato)piezas[j]).GetPosicionY());
                        }
                    }
                }
            }

        }
        protected override void ComprobacionDeMuerte()
        {
            for (int i = 0; i < piezas.Count; i++)
            {
                if (piezas[i] is Raton)
                {
                    if (((Animal)piezas[i]).ChequearVida().Ticks != 0)
                    {
                        muertos.Add(piezas[i]);
                        piezas.Remove(piezas[i]);
                        aux.listBox1.Items.Add("Un raton murio de hambre.");
                        cantRatones--;
                    }
                }
                else if (piezas[i] is Gato)
                {
                    if (((Animal)piezas[i]).ChequearVida().Ticks != 0)
                    {
                        muertos.Add(piezas[i]);
                        piezas.Remove(piezas[i]);
                        aux.listBox1.Items.Add("Un Gato murio de hambre.");
                        cantGatos--;
                    }
                }
            } 
        }
    }
}
