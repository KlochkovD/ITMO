namespace Utils
{
    using System;

    public class Utils
    {

        public static bool IsItFormattable(object x)
        {
           
            if (x is IFormattable)
                return true;
            else
                return false;
        }


    }
}
