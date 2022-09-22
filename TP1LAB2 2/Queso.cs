using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace TP1LAB2_2
{
    internal class Queso : IPosicionable
    {
        static Random aux2 = new Random();
        int posicionX;
        int posicionY;
        public int GetPosicionX()
        {
            return posicionX;
        }
        public int GetPosicionY()
        {
            return posicionY;
        }
        public Queso(int paramCreacionX, int paramCreacionY)
        {
            posicionX = aux2.Next(0, paramCreacionX - 1);
            posicionY = aux2.Next(0, paramCreacionY - 1);
        }
    }
}
