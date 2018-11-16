using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicepoint
{
    public class Point
    {//attribut
        private int x;
        private int y;

        //propriétés
        public int getX()
        { return this.x;
        }

        public int getY()
        {
            return this.y;
        }
        //constructeurs
        //public Point(int _x, int _y)
        //{
        //    this.x = _x;
        //    this.y = _y;
        //}
        public Point(int _x,int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public Point()
        {
          this.x =  0;
          this.y = 0;
          
        }

        //methodes
        public void Deplace(int a, int b)
        {

            this.x = this.x + a;
            this.y += b;
        }

   

        public Point symx()
        {


            Point symX = new Point(getX(),-getY() );

            return symX;
        }

        public Point symy()
        {


            Point symY = new Point(-getX(), getY());

            return symY;
        }


        public Point symO()
        {
            Point symO = new Point(-getX(), -getY());
            return symO;
        }

        public Point permute()
        {
            Point permut = new Point();
            int temp = getX();
            this.x = getY();
            this.y = temp;
            permut.x = this.x;
            permut.y = this.y;

            return permut;

        }
        public string AfficherPoint()
        {
           string chaine = "Je suis le point de coordonnées " + getX() + "," +getY();

            return chaine;
        }
    }
}