using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        Graphics g;
        Tree[] t = new Tree[500];
        Param[] p = new Param[2];
        List<Tree> plist = new List<Tree>();
        ParamOneYearTree p1 = new ParamOneYearTree();
        ParamTwoYearTree p2 = new ParamTwoYearTree();
        int count = 0;
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (r.Next(1, 3) == 1)
                plist.Add(new Tree(r.Next(10, 100), r.Next(10, 1500), p1));
            else
                plist.Add(new Tree(r.Next(10, 100), r.Next(10, 1500), p2));


            g.DrawImage(plist[count].p.pic, new Rectangle(plist[count].x, plist[count].y, plist[count].p.h, 20));

            foreach (Tree q in plist)
            {

                q.move();
                g.Clear(Color.AliceBlue);
                for (int i = 0; i < plist.Count; i++)
                {
                    g.DrawImage(plist[i].p.pic, new Rectangle(plist[i].x, plist[i].y, plist[i].p.h, 20));
                }
            }
            if (count < 499)
                count++;
            else
                timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
