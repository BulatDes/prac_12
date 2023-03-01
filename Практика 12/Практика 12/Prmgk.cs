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
    public partial class Form2 : Form
    {

        internal class Prmgk
        {
            int x, y, v, s, x1, y1;
            public void Vvod(int x, int y, int v, int s, int x1, int y1)
            {
                this.x = x;
                this.y = y;
                this.v = v;
                this.s = s;
                this.x1 = x1;
                this.y1 = y1;
            }
            public void Sozdanie()
            {
                
            }

        }
    }
}
