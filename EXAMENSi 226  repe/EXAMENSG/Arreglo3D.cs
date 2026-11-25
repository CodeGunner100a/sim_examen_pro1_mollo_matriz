using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENSG
{
    class Arreglo3D
    {
        private int[,,] Y;
        private int f, c, p;
        const int MAXF = 30;
        const int MAXC = 30;
        const int MAXP = 30;


        public Arreglo3D()
        {
            Y = new int[MAXF, MAXC, MAXP];
            f = 0;
            c = 0;
            p = 0;
        }


        public void Cargar(int nf, int nc, int np, int a, int b)
        {
            int f1, c1, p1;
            f = nf; c = nc; p = np;

            Random r = new Random();
            for (p1 = 1; p1 <= p; p1++)
            {
                for (f1 = 1; f1 <= f; f1++)
                {
                    for (c1 = 1; c1 <= c; c1++)
                    {
                        Y[f1, c1, p1] = r.Next(a, b + 1);
                    }
                }
            }

        }
        public string Descargar()
        {
            string s = "";
            int f1, c1, p1;

            for (p1 = 1; p1 <= p; p1++)
            {
                for (f1 = 1; f1 <= f; f1++)
                {
                    for (c1 = 1; c1 <= c; c1++)
                    {
                        s = s + Y[f1, c1, p1] + "\x09";
                    }

                    s = s + "\r\n";

                }
                s = s + "\r\n\n";
            }
            return s;
        }

        //Examen - Ejercicio 3D
    }
}
