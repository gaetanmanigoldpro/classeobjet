using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicepoint
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point (3,1);

          p1.Deplace(2,2);
            Console.WriteLine(p1.AfficherPoint());

            Point p2 = p1.symx();
            Console.WriteLine(p2.AfficherPoint());

            Point p3 = p1.symy();
            Console.WriteLine(p3.AfficherPoint());

            Point p4 = p1.symO();
            Console.WriteLine(p4.AfficherPoint());

            Point p5 = p1.permute();
            Console.WriteLine(p5.AfficherPoint());

            Console.ReadKey();


           
            
        }
        
           
    }
}
