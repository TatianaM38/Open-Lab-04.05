using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string str = "";
            foreach (var v in orig)
            {
                for (int i = 0; i < n; i++)
                {
                    str += v;
                }
            }

            return str;
        }
    }
}
