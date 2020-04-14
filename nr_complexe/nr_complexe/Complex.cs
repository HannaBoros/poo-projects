using System;


namespace nr_complexe
{
    internal class Complex
    {
        private int realP;
        private int imaginaryP;

        public Complex(int realP, int imaginaryP)
        {
            this.realP = realP;
            this.imaginaryP = imaginaryP;
        }
        public Complex(int realP)
        {
            this.realP = realP;
        }

        public static void Diff(Complex nr1, Complex nr2)
        {

            int diffReal = nr1.realP - nr2.realP;
            int diffImaginary = nr1.imaginaryP - nr2.imaginaryP;
            Complex Diff= new Complex(diffReal, diffImaginary);
            Complex.Print(Diff);
        }

        internal static void TrigonometricForm(Complex nr)
        {
            double r = Math.Sqrt(nr.realP * nr.realP + nr.imaginaryP * nr.imaginaryP);
            double t = Math.Atan(nr.imaginaryP / nr.realP);
            Console.WriteLine($" Forma trigonometrica : {r}(cos({t})+isin({t}))");
        }

        public static void Pow(Complex nr, int pow)
        {
            double r = Math.Sqrt(nr.realP * nr.realP + nr.imaginaryP * nr.imaginaryP);
            double t = Math.Atan(nr.imaginaryP / nr.realP);
            double Preal = (int)Math.Pow(r, pow) * Math.Cos(pow * t);
           double Pim= (int)Math.Pow(r, pow) * Math.Sin(pow * t);
            Complex P = new Complex((int)Preal, (int)Pim);
            Complex.Print(P);

        }

        public  static void Multiply(Complex nr1, Complex nr2)
        {
            int mReal = (nr1.realP * nr2.realP) - (nr1.imaginaryP * nr2.imaginaryP);
            int mImaginar = (nr1.realP * nr2.imaginaryP) + (nr2.realP * nr1.imaginaryP); ;
            Complex M= new Complex(mReal, mImaginar);
            Complex.Print(M);
        }

        public static void Sum(Complex nr1, Complex nr2)
        {
            int sumReal = nr1.realP + nr2.realP;
            int sumImaginary = nr1.imaginaryP + nr2.imaginaryP;
            Complex Sum = new Complex(sumReal, sumImaginary);
            Complex.Print(Sum);
        }

        public Complex()
        {
            realP = 0;
            imaginaryP = 0;
        }
        public static void Print(Complex nr)
        {
            if (nr.imaginaryP < 0)
            {
                nr.imaginaryP = (int)Math.Abs(nr.imaginaryP);
                Console.WriteLine($"z= {nr.realP}-{nr.imaginaryP}*i");
            }
            else Console.WriteLine($"z= { nr.realP}+{ nr.imaginaryP}*i");

        }
    }
}