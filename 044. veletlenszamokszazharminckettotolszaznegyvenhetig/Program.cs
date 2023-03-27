using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044.veletlenszamokszazharminckettotolszaznegyvenhetig
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Random random = new Random();

                for (int i = 132; i < 148; i++)     // Ez a sor 16 db random számot fog kiírni, mert a 132 és a 147 közti intervallumot veszi, ami 16.
                {
                    Console.WriteLine(random.Next(132, 147));   // Ha a zárójelbe nem írunk paramétereket, akkor az integer (int) értékéig, vagyis 2 milliárdig generálja a véletlen   számokat, de a for ciklusban megadott paraméterek miatt akkor is csak 16 db számot fog kiírni. Viszont nekünk nem kellenek ekkora számok, mert a feladat azt mondja, hogy 132-től 147-ig generáljon számokat, így ide is be kell írni a kért paramétereket.
                }

                //int num = random.Next(1, 7);     // 1-től 7-ig egész számokat generál

                //double num = random.NextDouble();   //tizedes törteket generál

                //Console.WriteLine(num);

                Console.ReadKey();

            }
        }
    }
}
