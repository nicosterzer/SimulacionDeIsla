using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TP1LAB2_2
{
    internal abstract class Animal : IPosicionable
    {
        protected int posicionX;
        protected int posicionY;
        protected int diasSinComer = 0;
        protected DateTime inicio;
        protected DateTime tiempoVivo = new DateTime(0);
        protected int pasosCant;

        protected int paramCreacionX;
        protected int paramCreacionY;

        //protected int contadorDeMuerte = 0;
        /*public int Muerte
        {
            get
            {
                return contadorDeMuerte;
            }
        }*/
        public int GetPosicionY()
        {
            return posicionY;
        }
        public int GetPosicionX()
        {
            return posicionX;
        }
        protected static Random aux = new Random();
        public int DiasSinComer
        {
            get { return diasSinComer; }
        }
        public Animal(int paramCreacionX, int paramCreacionY)
        {
            inicio = DateTime.Now;
            posicionX = aux.Next(0, paramCreacionX);
            posicionY = aux.Next(0, paramCreacionY);
            //guarda las posiciones maximas iniciales;
            this.paramCreacionX = paramCreacionX;
            this.paramCreacionY = paramCreacionY;
        }
        public abstract void Mover();
        protected abstract void CacularDiasSinComer();
        public DateTime ChequearVida()
        {
            return tiempoVivo;
        }
        public abstract void Comer();
        public void Morir()
        {
            DateTime final = DateTime.Now;
            TimeSpan aux = final.Subtract(this.inicio);
            tiempoVivo = new DateTime(aux.Ticks);
        }
    }
    
    class Gato : Animal
    {
        int ratonesComidos;
        public int RatonesComidos
        {
            get
            {
                return ratonesComidos;
            }
        }
        public Gato(int paramCreacionX, int paramCreacionY) : base(paramCreacionX, paramCreacionY)
        {}
        public override void Comer()
        {
            this.diasSinComer = 0;
            ratonesComidos++;
        }
        public override void Mover()
        {
            int pasos = aux.Next(0, 4);
            int direccion = aux.Next(0, 4);

            switch(direccion)
            {
                case 0:
                    posicionX -= pasos;// hacia arrriba;
                    break;
                case 1:
                    posicionX += pasos;//hacia abajo;
                    break;
                case 2:
                    posicionY += pasos;//hacia la derecha;
                    break;
                case 3:
                    posicionY -= pasos;//hacia la izquierda;
                    break;
            }
            while(posicionX >= paramCreacionX || posicionX < 0 || posicionY >= paramCreacionY || posicionY < 0)
            {
                posicionY = paramCreacionY;
                posicionX = paramCreacionX;
                AuxDeMover(pasos);
            }
            pasosCant += pasos;
            if (pasosCant > 10)
            {
                CacularDiasSinComer();
            }        
        }
        void AuxDeMover( int pasos)
        {

            int direccion = aux.Next(0, 4);
            switch (direccion)
            {
                case 0:
                    posicionX -= pasos;// hacia arrriba;
                    break;
                case 1:
                    posicionX += pasos;//hacia abajo;
                    break;
                case 2:
                    posicionY += pasos;//hacia la derecha;
                    break;
                case 3:
                    posicionY -= pasos;//hacia la izquierda;
                    break;
            }
        }
        protected override void CacularDiasSinComer()
        {
            pasosCant = 0;
            diasSinComer++;
            if (diasSinComer > 4)
            {
                Morir();
            }
        }
    }
    
    class Raton : Animal, IComparable
    {
        int quesosComidos;
        string sexo;
        public string Sexo
        {
            get { return sexo; }
        }
        public int QuesosComidos
        {
            get { return quesosComidos; }
        }
        public Raton(int paramCreacionX, int paramCreacionY) : base(paramCreacionX, paramCreacionY)
        {
            //le da el sexo al raton;
            if (aux.Next(1,3) == 1)
            {
                sexo = "Hembra";
            }
            else
            {
                sexo = "Macho";
            }
        }
        public override void Mover()
        {
            //metodo mover entre 0 a 3 pasos y en cualquiera de las 4 direcciones;
            int pasos = aux.Next(0, 4);
            int direccion = aux.Next(0, 4);

            switch (direccion)
            {
                case 0:
                    posicionX -= pasos;// hacia arrriba;
                    break;
                case 1:
                    posicionX += pasos;//hacia abajo;
                    break;
                case 2:
                    posicionY += pasos;//hacia la derecha;
                    break;
                case 3:
                    posicionY -= pasos;//hacia la izquierda;
                    break;
            }
            pasosCant += pasos;
            if (pasosCant > 10)
            {
                CacularDiasSinComer();
            }
        }
        public Raton[] Reproducirse()
        {
            //metodo de reproducirse devuelve un vector de ratones de 2 a 6 nuevos ratones;
            Raton[] hijos;            
            hijos = new Raton[aux.Next(2,7)];
                
            for (int i = 0; i < hijos.Length; i++)
            {
                 hijos[i] = new Raton(this.paramCreacionX, this.paramCreacionY);
            }
            return hijos;            
        }
        public override void Comer()
        {
            this.diasSinComer = 0;
            quesosComidos++;
        }
        //CompareTo para comparar los sexos de los ratones;
        public int CompareTo(object obj)
        {
            Raton r = obj as Raton;
            return sexo.CompareTo(r.sexo);
        }
        protected override void CacularDiasSinComer()
        {
            pasosCant = 0;
            diasSinComer++;
            if (diasSinComer > 2)
            {
                Morir();
            }
        }
    }
}
