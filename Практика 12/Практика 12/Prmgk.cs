using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_12
{
        internal class Prmgk
        {
           public int x, y, v, s, x1, y1;

            public double Perimetr(int v,int s)
            {
                double P = (v + s) * 2;
                return P;
            }

             public double Ploshad(int v, int s)
             {
                 double S = v*s;
                 return S;
             }

            public double Diogonal(int v, int s)
        {
            double d;
            d=Math.Sqrt(Math.Pow(v,2) + Math.Pow(s,2));
            return d;
        }

         }

   
    
}
