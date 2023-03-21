using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    public class Param
    {
        public int h;
        public Bitmap pic;
    }
   

    public class ParamOneYearTree : Param
    {
        public ParamOneYearTree()
        {
            h = 50;
            pic = new Bitmap("Без названия.jfif");
        }
    }
    public class ParamTwoYearTree : Param
    {
        public ParamTwoYearTree()
        {
            h = 100;
            pic = new Bitmap("Без названия.png");
        }
    }
    public class Tree
    {
        public int x, y;
        public Param p;
        public Tree()
        {
            x = 0; y = 0;
        }

        public Tree(int x, int y, Param p)
        {
            this.p = p;
            this.x = x;
            this.y = y;
        }
        Random random = new Random();
        public void Clear()
        {

        }
        public void move()
        {

            if (x < 1000)
            {
                this.x += random.Next(1, 50);
            }
            else
            {
                x = 1;
            }
        }
    }
}
