using System;

namespace ConsoleApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            
            string[] arrstr = new string[] { "Наргис", "Фарзона", "Шукрона" };
            string Arraystr = ArrayHelper.Pop(ref arrstr);
            Console.WriteLine($"Pop string: {Arraystr}");


            int[] arrint = new int[] { 5, 1, 4, 152, 100 };
            int Arrayint = ArrayHelper.Pop(ref arrint);
            Console.WriteLine($"Pop int: {Arrayint}");


            double[] arrdbl = new double[] { 8.251, 5.42, 8.5, 8.4, 1.1655 };
            double Arraydbl = ArrayHelper.Pop(ref arrdbl);
            Console.WriteLine($"Pop double: {Arraydbl}");

            decimal[] arrdec = new decimal[] { 4.49m, 4.515m, 4.7585m, 4.215m, 10.552m };
            decimal Arraydec = ArrayHelper.Pop(ref arrdec);
            Console.WriteLine($"Pop decimal: {Arraydec}");

            float[] arrflt = new float[] { 2.1f, 1.5f, 1.4f, 2.4f, 10.6f };
            float Arrayflt = ArrayHelper.Pop(ref arrflt);
            Console.WriteLine($"Pop float: {Arrayflt}");


            
            string[] newstr = new string[] { "Наргис", "Фарзона", "Шукрона" };
            int Oldstring = ArrayHelper.Push(ref newstr, "Марям");
            Console.WriteLine($"Push string:  {Oldstring}");


            int[] newint = new int[] {5, 1, 4, 152, 100 };
            int Oldint = ArrayHelper.Push(ref newint, 5488);
            Console.WriteLine($"Push int: {Oldint}");


            double[] newdbl = new double[] { 8.251, 5.42, 8.5, 8.4, 1.1655 };
            double Olddbl = ArrayHelper.Push(ref newdbl, 100.45);
            Console.WriteLine($"Push double: {Olddbl}");


            decimal[] newdec = new decimal[] { 4.49m, 4.515m, 4.7585m, 4.215m, 10.552m };
            decimal Olddec = ArrayHelper.Push(ref newdec, 10.701m);
            Console.WriteLine($"Push decimal: {Olddec}");


            float[] newflt = new float[] { 2.1f, 1.5f, 1.4f, 2.4f, 10.6f };
            float Oldflt = ArrayHelper.Push(ref newflt, 7.1f);
            Console.WriteLine($"Push decimal: {Oldflt}");


            

            string[] str1 = new string[] { "Наргис", "Фарзона", "Шукрона" };
            string string1 = ArrayHelper.Shift(ref str1);
            Console.WriteLine($"Shift string: {string1}");


            int[] int1 = new int[] { 5, 1, 4, 152, 100 };
            int Int1 = ArrayHelper.Shift(ref int1);
            Console.WriteLine($"Shift int: {Int1}");


            double[] dbl1 = new double[] { 8.251, 5.42, 8.5, 8.4, 1.1655 };
            double Doubl1 = ArrayHelper.Shift(ref dbl1);
            Console.WriteLine($"Shift double: {Doubl1}");

            decimal[] dec1 = new decimal[] { 4.49m, 4.515m, 4.7585m, 4.215m, 10.552m };
            decimal Decimal1 = ArrayHelper.Shift(ref dec1);
            Console.WriteLine($"Shift decimal: {Decimal1}");


            float[] flt1 = new float[] { 2.1f, 1.5f, 1.4f, 2.4f, 10.6f };
            float Float1 = ArrayHelper.Shift(ref flt1);
            Console.WriteLine($"Shift float: {Float1}");



            

            string[] PastStr = new string[] { "Наргис", "Фарзона", "Шукрона" };
            int newPast = ArrayHelper.UnShift(ref PastStr, "Марям");
            Console.WriteLine($"Unshift string: {newPast}");

            int[] Pastint = new int[] { 5, 1, 4, 152, 100 };
            int newPasti = ArrayHelper.UnShift(ref Pastint, 98);
            Console.WriteLine($"Unshift int: {newPasti}");


            double[] Pastdbl = new double[] { 8.251, 5.42, 8.5, 8.4, 1.1655 };
            double newPastd = ArrayHelper.UnShift(ref Pastdbl, 43.2);
            Console.WriteLine($"Unshift double {newPastd}");


            decimal[] Pastdec = new decimal[] {4.49m, 4.515m, 4.7585m, 4.215m, 10.552m };
            decimal newPastde = ArrayHelper.UnShift(ref Pastdec, 0.589m);
            Console.WriteLine($"Unshift decimal: {newPastde}");


            float[] Pastflt = new float[] { 2.1f, 1.5f, 1.4f, 2.4f, 10.6f };
            float newPastflt = ArrayHelper.UnShift(ref Pastflt, 4.85f);
            Console.WriteLine($"Unshift float: {newPastflt}");
        }
    }



     public static class ArrayHelper
    {
        public static string Pop(ref string[] arrstr)
        {
            string Arraystr = arrstr[arrstr.Length - 1];
            Array.Resize(ref arrstr, arrstr.Length - 1);

            return Arraystr;
        }

        public static int Pop(ref int[] arrint)
        {
            int Arrayint = arrint[arrint.Length - 1];
            Array.Resize(ref arrint, arrint.Length - 1);
            return Arrayint;
        }

        public static double Pop(ref double[] arrdbl)
        {
            double Arraydbl = arrdbl[arrdbl.Length - 1];
            Array.Resize(ref arrdbl, arrdbl.Length - 1);
            return Arraydbl;
        }

        public static decimal Pop(ref decimal[] arrdec)
        {
            decimal Arraydec = arrdec[arrdec.Length - 1];
            Array.Resize(ref arrdec, arrdec.Length - 1);
            return Arraydec;
        }

        public static float Pop(ref float[] arrflt)
        {
            float Arrayflt = arrflt[arrflt.Length - 1];
            Array.Resize(ref arrflt, arrflt.Length - 1);
            return Arrayflt;
        }

        
        public static int Push(ref string[] Oldstring, string newstr)
        {

            Array.Resize(ref Oldstring, Oldstring.Length + 1);
            Oldstring[Oldstring.Length - 1] = newstr;
            return Oldstring.Length - 1;
        }

        public static int Push(ref int[] Oldint, int newint)
        {
            Array.Resize(ref Oldint, Oldint.Length + 1);
            return Oldint.Length - 1;
        }

        public static double Push(ref double[] Olddbl, double newdbl)
        {
            Array.Resize(ref Olddbl, Olddbl.Length + 1);
            return Olddbl.Length - 1;
        }

        public static decimal Push(ref decimal[] Olddec, decimal newdec)
        {
            Array.Resize(ref Olddec, Olddec.Length + 1);
            return Olddec.Length - 1;
        }


        public static float Push(ref float[] Oldflt, float newflt)
        {
            Array.Resize(ref Oldflt, Oldflt.Length + 1);
            return Oldflt.Length - 1;
        }


       

        public static string Shift(ref string[] str1)
        {
            string string1 = str1[0];
            for (int i = 0; i < str1.Length - 1; i++)
            {
                str1[i] = str1[i + 1];
            }
            Array.Resize(ref str1, str1.Length - 1);
            return string1;
        }

        public static int Shift(ref int[] int1)
        {
            int Int1 = int1[0];
            for (int i = 0; i < int1.Length - 1; i++)
            {
                int1[i] = int1[i + 1];
            }
            Array.Resize(ref int1, int1.Length - 1);
            return Int1;
        }

        public static double Shift(ref double[] dbl1)
        {
            double Doubl1 = dbl1[0];
            for (int i = 0; i < dbl1.Length - 1; i++)
            {
                dbl1[i] = dbl1[i + 1];
            }
            Array.Resize(ref dbl1, dbl1.Length - 1);
            return Doubl1;
        }

        public static decimal Shift(ref decimal[] dec1)
        {
            decimal Decimal1 = dec1[0];
            for (int i = 0; i < dec1.Length - 1; i++)
            {
                dec1[i] = dec1[i + 1];
            }
            Array.Resize(ref dec1, dec1.Length - 1);
            return Decimal1;
        }
        public static float Shift(ref float[] flt1)
        {
            float Float1 = flt1[0];
            for (int i = 0; i < flt1.Length - 1; i++)
            {
                flt1[i] = flt1[i + 1];
            }
            Array.Resize(ref flt1, flt1.Length - 1);
            return Float1;
        }

        

        public static int UnShift(ref string[] PastStr, string newPast)
        {
            Array.Resize(ref PastStr, PastStr.Length + 1);
            for (int i = PastStr.Length - 1; i >= 1; i--)
            {
                PastStr[i] = PastStr[i - 1];
            }
            PastStr[0] = newPast;
            return PastStr.Length - 1;
        }


        public static int UnShift(ref int[] Pastint, int newPasti)
        {
            Array.Resize(ref Pastint, Pastint.Length + 1);
            for (int i = Pastint.Length - 1; i >= 1; i--)
            {
                Pastint[i] = Pastint[i - 1];
            }
            Pastint[0] = newPasti;
            return Pastint.Length - 1;
        }


        public static double UnShift(ref double[] Pastdbl, double newPastd)
        {
            Array.Resize(ref Pastdbl, Pastdbl.Length + 1);
            for (int i = Pastdbl.Length - 1; i >= 1; i--)
            {
                Pastdbl[i] = Pastdbl[i - 1];
            }
            Pastdbl[0] = newPastd;
            return Pastdbl.Length - 1;
        }


        public static decimal UnShift(ref decimal[] Pastdec, decimal newPastde)
        {
            Array.Resize(ref Pastdec, Pastdec.Length + 1);
            for (int i = Pastdec.Length - 1; i >= 1; i--)
            {
                Pastdec[i] = Pastdec[i - 1];
            }
            Pastdec[0] = newPastde;
            return Pastdec.Length - 1;
        }

        public static float UnShift(ref float[] Pastflt, float newPastflt)
        {
            Array.Resize(ref Pastflt, Pastflt.Length + 1);
            for (int i = Pastflt.Length - 1; i >= 1; i--)
            {
                Pastflt[i] = Pastflt[i - 1];
            }
            Pastflt[0] = newPastflt;
            return Pastflt.Length - 1;
        }
    }
}
