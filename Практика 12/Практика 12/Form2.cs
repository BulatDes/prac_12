using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_12
{
    public partial class Form2 : Form
    {
        bool flag = false;
        bool flag1 = false;
        Pen redPen = new Pen(Color.Red, 1);
        Pen bluePen = new Pen(Color.Blue, 2);
        Pen greenPen = new Pen(Color.Green, 2);
        Pen purplePen = new Pen(Color.Purple, 2);
        Pen blackPen = new Pen(Color.Black, 2);
        Pen whitePen = new Pen(Color.White, 2);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                Prmgk rec = new Prmgk();
                Graphics g = this.CreateGraphics();
                //int x, y, v, s;
               rec.x = (int)numericUpDown4.Value+this.Width/2;
                rec.y = this.Height / 2-(int)numericUpDown1.Value;
                rec.v = (int)numericUpDown2.Value;
                rec.s = (int)numericUpDown3.Value;
                g.DrawRectangle(blackPen, rec.x, rec.y, rec.s, rec.v);
                g.Dispose();
                flag = true;
            }
            else MessageBox.Show("Очистите старый Прямоугольник чтобы наисовать новую!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            g.Dispose();
            flag = false;
            flag1 = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag1 == false)
            {
                Prmgk rec = new Prmgk();
                Graphics g = this.CreateGraphics();
               // int x, y, v, s;
                rec.x = (int)numericUpDown7.Value + this.Width / 2;
                rec.y = this.Height / 2 - (int)numericUpDown10.Value;
                rec.v = (int)numericUpDown9.Value;
                rec.s = (int)numericUpDown8.Value;
                g.DrawRectangle(blackPen, rec.x, rec.y, rec.s, rec.v);
                g.Dispose();
                flag1 = true;
            }
            else MessageBox.Show("Очистите старый Прямоугольник чтобы нарисовать новую!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(redPen, this.Width/2, 0, this.Width/2, this.Height);
            g.DrawLine(redPen, 0, this.Height/2, this.Width, this.Height/2);
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prmgk clear = new Prmgk();
            Prmgk rec = new Prmgk();
            Graphics g = this.CreateGraphics();
            //int x2, y2, v2, s2;
            clear.x = (int)numericUpDown4.Value + this.Width / 2;
            clear.y = this.Height / 2 - (int)numericUpDown1.Value;
            clear.v = (int)numericUpDown2.Value;
            clear.s = (int)numericUpDown3.Value;
            g.DrawRectangle(whitePen, clear.x, clear.y, clear.s, clear.v);
            //int x, y, v, s;
            rec.x = (int)numericUpDown4.Value + this.Width / 2;
            rec.y = this.Height / 2 - (int)numericUpDown1.Value;
            rec.v = (int)numericUpDown2.Value;
            rec.s = (int)numericUpDown3.Value;
            //int x1, y1;
            rec.x1 =(int)numericUpDown6.Value;
            rec.y1 = (int)numericUpDown7.Value;
            g.DrawRectangle(blackPen, rec.x + rec.x1, rec.y + rec.y1, rec.s, rec.v);
            numericUpDown4.Value = numericUpDown4.Value + numericUpDown6.Value;
            numericUpDown1.Value = numericUpDown1.Value + numericUpDown7.Value;
            g.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prmgk clear = new Prmgk();
            Prmgk rec = new Prmgk();
            Graphics g = this.CreateGraphics();
           // int x, y, v, s;
            clear.x = (int)numericUpDown7.Value + this.Width / 2;
            clear.y = this.Height / 2 - (int)numericUpDown10.Value;
            clear.v = (int)numericUpDown9.Value;
            clear.s = (int)numericUpDown8.Value;
            g.DrawRectangle(whitePen, clear.x, clear.y, clear.s, clear.v);
            //int x, y, v, s;
            rec.x = (int)numericUpDown7.Value + this.Width / 2;
            rec.y = this.Height / 2 - (int)numericUpDown10.Value;
            rec.v = (int)numericUpDown9.Value;
            rec.s = (int)numericUpDown8.Value;
            //int x1, y1;
            rec.x1 = (int)numericUpDown11.Value;
            rec.y1 = (int)numericUpDown12.Value;
            g.DrawRectangle(blackPen, rec.x + rec.x1, rec.y + rec.y1, rec.s, rec.v);
            numericUpDown7.Value = numericUpDown7.Value + numericUpDown11.Value;
            numericUpDown10.Value = numericUpDown10.Value + numericUpDown12.Value;
            g.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Prmgk rec = new Prmgk();
            rec.v = (int)numericUpDown2.Value;
            rec.s = (int)numericUpDown3.Value;
            double P = rec.Perimetr(rec.v,rec.s);
            double S = rec.Ploshad(rec.v, rec.s);
            double d = rec.Diogonal(rec.v, rec.s);
            MessageBox.Show($"Периметр: {P} \nПлощадь: {S} \nДиагональ: {d}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Prmgk rec = new Prmgk();
            rec.v = (int)numericUpDown9.Value;
            rec.s = (int)numericUpDown8.Value;
            double P = rec.Perimetr(rec.v, rec.s);
            double S = rec.Ploshad(rec.v, rec.s);
            double d = rec.Diogonal(rec.v, rec.s);
            MessageBox.Show($"Периметр: {P} \nПлощадь: {S} \nДиагональ: {d}");
        }
    }
}

