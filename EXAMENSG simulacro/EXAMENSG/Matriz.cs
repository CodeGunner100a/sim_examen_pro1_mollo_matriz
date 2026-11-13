using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EXAMENSG
{
    class Matriz
    {

        const int MAXF = 50;
        const int MAXC = 50;

        private int[,] x;
        private int f, c;

        public Matriz()
        {
            x = new int[MAXF, MAXC];
            f = 0;
            c = 0;
        }

        public void CargarRandom(int nf, int nc, int a, int b)
        {
            int f1, c1;
            Random r = new Random();
            f = nf;
            c = nc;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    x[f1, c1] = r.Next(a, b + 1);
                }
            }
        }

        public void Dim(int f1, int c1)
        {
            f = f1;
            c = c1;
        }

        public string Descargar()
        {
            int f1, c1;
            string s = "";

            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    s = s + x[f1, c1] + "\x9";
                }
                s = s + "\xd" + "\xa";
            }
            return s;
        }


        //EXAMEN


        //PREGUNTA 1 ===========
        public void Ejercicio1(int fi, int ff, int ci, int cf,
                                         ref int ele, ref int frec)
        {
            int f1, c1, v, fv;

            frec = -1; // máximo encontrado
            ele = -1;

            for (f1 = fi; f1 <= ff; f1++)
            {
                for (c1 = ci; c1 <= cf; c1++)
                {
                    v = x[f1, c1];
                    fv = FrecRango(v, fi, ff, ci, cf);


                    if (fv > frec || (fv == frec && v > ele))
                    {
                        frec = fv;
                        ele = v;
                    }
                }
            }
        }


        private int FrecRango(int v, int fi, int ff, int ci, int cf)
        {
            int k = 0;

            for (int f1 = fi; f1 <= ff; f1++)
                for (int c1 = ci; c1 <= cf; c1++)
                    if (x[f1, c1] == v)
                        k++;

            return k;
        }




        //PREGUNTA 2 ===========

        public void EjercicioDiferentesP1()
        {
            int p, d;
            for (p = 1; p <= f - 1; p++)
            {
                for (d = p + 1; d <= f; d++)
                {
                    if (ContadorDiferentes(p) < ContadorDiferentes(d))
                    {
                        Intercambiarfilas(p, d);
                    }
                }
            }
            for (int f1 = 1; f1 <= f; f1++)
            {
                x[f1, c + 1] = ContadorDiferentes(f1);
            }
            c++;
        }

        public int ContadorDiferentes(int f1)
        {
            int cont = 0;
            int c1, c2;
            bool yaContado;
            for (c1 = 1; c1 <= c; c1++)
            {
                yaContado = false;
                for (c2 = 1; c2 < c1; c2++)
                {
                    if (x[f1, c2] == x[f1, c1])
                    {
                        yaContado = true;
                    }
                }
                if (!yaContado)
                {
                    cont++;
                }
            }
            return cont;
        }
        public void Intercambiarfilas(int f1, int f2)
        {
            int c1;
            for (c1 = 1; c1 <= c; c1++)
            {
                Intercambiar(f1, c1, f2, c1);
            }
        }//
        public void Intercambiar(int f1, int c1, int f2, int c2)
        {
            int aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }

    }
}
