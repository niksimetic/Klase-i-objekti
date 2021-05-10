using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseObjekti22
{
    class GeometrijskiLik
    {
        public int BrojStr;
        public double[] Stranice = new double[10];

        public void IspisiStr()
        {
            for(int i = 0; i < BrojStr; i++)
            {
                Stranice[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public double Opseg()
        {
            double opseg = 0;
            for(int i = 0; i < BrojStr; i++)
            {
                opseg = opseg + Stranice[i];
            }
            return 0;
        }
    }
}
