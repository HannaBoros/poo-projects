using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        private int rows;
        private int columns;
        private double[,] matrix;
        private static Random r = new Random();

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new double[this.rows, this.columns];
        }

        public Matrix(int n) : this(n, n)
        {

        }
        public void RandomMatrix()
        {
            int n = this.rows;
            int m = this.columns;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = r.Next(5);
                }
            }
        }

        public Matrix Add(Matrix m1)
        {
            if (this.rows != m1.rows && this.columns != m1.columns)
            {
                throw new System.InvalidOperationException("Invalid");
            }

            int n = this.rows;
            int m = this.columns;

            Matrix sum = new Matrix(n, m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum.matrix[i, j] = this.matrix[i, j] + m1.matrix[i, j];
                }
            }

            return sum;
        }
        public Matrix Diff(Matrix m1)
        {
            if (this.rows != m1.rows && this.columns != m1.columns)
            {
                throw new System.InvalidOperationException("Invalid");
            }

            int n = this.rows;
            int m = this.columns;

            Matrix dif = new Matrix(n, m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dif.matrix[i, j] = this.matrix[i, j] - m1.matrix[i, j];
                }
            }

            return dif;
        }
        public Matrix Multiply(Matrix m1)
        {
           
            if (this.rows != m1.columns)
                throw new System.InvalidOperationException("Invalid");
            
            int n = this.rows;
            int m = m1.columns;
            Matrix Multiply = new Matrix(n,m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < this.columns; k++)
                    {
                       sum += this.matrix[i,  k] * m1.matrix[k, j];
                    }
                    Multiply.matrix[i, j] = sum;
                }
            }
            
            return Multiply;
        }
        public double GetDeterminant()
        {
            int n = this.rows;
            int m = this.columns;

            if (n != m)
            {
                Console.WriteLine("Can't calculate Determinant");
            }

            if (n == 2)
            {
                return this.matrix[0, 0] * this.matrix[1, 1] - this.matrix[0, 1] * this.matrix[1, 0];
            }
            if (n == 3)
            {
                return (this.matrix[0, 0] * this.matrix[1, 1] * this.matrix[2, 2] + this.matrix[1, 0] * this.matrix[2, 1] * this.matrix[0, 2] + this.matrix[0, 1] * this.matrix[1, 2] * this.matrix[2, 0]) -
                    (this.matrix[0, 2] * this.matrix[1, 1] * this.matrix[2, 0] + this.matrix[0, 1] * this.matrix[1, 0] * this.matrix[2, 2] + this.matrix[1, 2] * this.matrix[2, 1] * this.matrix[0, 0]);
            }
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Matrix aux = new Matrix(n - 1, n - 1);
                int p = 0;
                int q = 0;
                for (int k = 1; k < n; k++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j != i)
                        {
                            aux.matrix[p, q] = this.matrix[k, j];
                            q++;
                        }
                    }
                    q = 0;
                    p++;
                }
                if ((i + 2) % 2 == 0)
                {
                    sum += this.matrix[0, 1] * aux.GetDeterminant();
                }
                else
                {
                    sum -= this.matrix[0, 1] * aux.GetDeterminant();
                }
            }


            return sum;
        }
        public Matrix GetTransposedMatrix()
        {
            Matrix  M= new Matrix(this.rows, this.columns);

            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    M.matrix[i, j] = this.matrix[j, i];
                }
            }
            return M;
        }
        public Matrix GetAdjugateMatrix()
        {
            Matrix a = new Matrix(this.rows, this.columns);

            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    Matrix b = this.Reduce(this, i, j);
                    a.matrix[i, j] = (int)Math.Pow(-1, (i + j)) * b.GetDeterminant();
                }
            }
            return a;
        }

        public Matrix Reduce(Matrix old, int r, int c)
        {
            int n = old.rows;
            int m = old.columns;

            Matrix tmp = new Matrix(n - 1, m - 1);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    tmp.matrix[i, j] = old.matrix[i, j];
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = c + 1; j < m; j++)
                {
                    tmp.matrix[i, j - 1] = old.matrix[i, j];
                }
            }

            for (int i = r + 1; i < n; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    tmp.matrix[i - 1, j] = old.matrix[i, j];
                }
            }

            for (int i = r + 1; i < n; i++)
            {
                for (int j = c + 1; j < m; j++)
                {
                    tmp.matrix[i - 1, j - 1] = old.matrix[i, j];
                }
            }

            return tmp;
        }
        internal Matrix GetInverseMatrix(double d)
        {
            int n = this.rows;
            Matrix transpose = this.GetTransposedMatrix();
            Console.WriteLine("Transpozed:");
            Console.WriteLine(transpose);
           
            Matrix adjugate = transpose.GetAdjugateMatrix();
            Console.WriteLine("Adjugate: ");
            Console.WriteLine(adjugate);
            Matrix inverse_matrix = new Matrix(n, n);


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    inverse_matrix.matrix[i, j] = adjugate.matrix[i, j] / d;
                }
            }
            return inverse_matrix;
        }
        public Matrix Power(int power)
        {
            int n = this.rows;
            int m = this.columns;
            Matrix Power = new Matrix(n,m);
            while (power > 0)
            {
                Power = this.Multiply(this);
                power--;
            }
            return Power;
        }


          
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    double rounded = Math.Round(matrix[i, j], 2);
                    sb.Append($"{rounded} ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

    }
}
