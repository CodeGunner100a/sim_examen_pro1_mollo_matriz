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


        // PREGUNTA 1 repechaeje si

        //ejercicio 1 repe si miercoles
        public void Ejercicio1(int fi, int ff, int ci, int cf)
        {
            int f1, c1, f2, c2, i, j, n;

            n = (ff - fi + 1) * (cf - ci + 1);

            
            for (i = 1; i < n; i++)
            {
                f1 = fi;
                c1 = ci;

                for (j = 1; j <= n - i; j++)
                {
                    f2 = f1;
                    c2 = c1;

                    SiguienteSenoidal(ref f2, ref c2, fi, ff, ci, cf);

                    if (x[f1, c1] > x[f2, c2])
                    {
                        intercambiar(f1, c1, f2, c2);
                    }

                    f1 = f2;
                    c1 = c2;
                }
            }
        }

        private void SiguienteSenoidal(ref int fila, ref int col,
            int fi, int ff, int ci, int cf)
        {
            if ((fila - fi) % 2 == 0)
            {
                if (col < cf)
                {
                    col++;
                }
                else
                {
                    fila++;
                }
            }
            else
            {
                if (col > ci)
                {
                    col--;
                }
                else
                {
                    fila++;
                }
            }
        }

        private void intercambiar(int f1, int c1, int f2, int c2)
        {
            int aux;

            aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }





        //PREGUNTA 2 
































































        //public int Frecuencia(int ele)
        //{
        //    int cont = 0;

        //    for (int i = 1; i <= f; i++)
        //    {
        //        for (int j = i + 1; j <= c; j++) 
        //        {
        //            if (x[i, j] == ele)
        //            {
        //                cont++;
        //            }
        //        }
        //    }

        //    return cont;
        //}

        //public void Ejercicio2(ref int ele, ref int frec)
        //{
        //    int cont;

        //    ele = x[1, 2];
        //    frec = 0;

        //    for (int i = 1; i <= f; i++)
        //    {
        //        for (int j = i + 1; j <= c; j++)
        //        {
        //            cont = Frecuencia(x[i, j]);

        //            if (cont > frec)
        //            {
        //                frec = cont;
        //                ele = x[i, j];
        //            }
        //        }
        //    }
        //}


    }
}
