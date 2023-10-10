using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSoPhuc
{
    internal class Program
    {
        class SoPhuc
        {
            private int phanThuc;
            private int phanAo;
            public int getPhanThuc
            {
                set { this.phanThuc = value; }
                get { return this.phanThuc; }
            }
            public int getPhanAo
            {
                set { this.phanAo = value; }
                get { return this.phanAo; }
            }
            public int setPhanThuc(int phanThuc)
            {
                this.phanThuc = phanThuc;
                return this.phanThuc;
            }
            public int setPhanAo(int phanAo)
            {
                this.phanAo = phanAo;
                return this.phanAo;
            }
            public void PrintSoPhuc()
            {
                Console.WriteLine(" z = {0} + {1}*i ", this.phanThuc, this.phanAo);
            }
            public SoPhuc Sum2SoPhuc(SoPhuc z2)
            {
                SoPhuc sumZ = new SoPhuc();
                sumZ.phanThuc = this.phanThuc + z2.phanThuc;
                sumZ.phanAo = this.phanAo + z2.phanAo;
                Console.WriteLine(" z1 + z2 = {0} + {1}*i ", sumZ.phanThuc, sumZ.phanAo);
                return sumZ;
            }

        }   
        static void Main(string[] args)
        {
            SoPhuc sophuc1 = new SoPhuc();
            sophuc1.setPhanThuc(5);
            sophuc1.setPhanAo(5);
            sophuc1.PrintSoPhuc();

            SoPhuc sophuc2 = new SoPhuc();
            sophuc2.setPhanThuc(6);
            sophuc2.setPhanAo(6);
            sophuc2.PrintSoPhuc();

            Console.ReadKey();
        }
    }
}
