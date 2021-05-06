namespace Utils
{
    using System;

    public class Utils
    {
        // As before....

        //
        // Exchange two integers, passed by reference
        //

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}

