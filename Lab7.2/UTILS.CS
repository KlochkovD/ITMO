namespace Utils
{
    using System;

    public class Utils
    {

        public static void Reverse(ref string s)
        {
            string sRev = "";

            for (int k = s.Length - 1; k >= 0; k--)
            {
                sRev += s[k];
            }

            s = sRev;
        }
      
    }
}
