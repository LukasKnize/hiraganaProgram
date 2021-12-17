using System;

namespace skolniProjektPVA
{
    internal class Generate
    {
        static Random random = new Random();
        static int lastChar = 0;
        static int nextCharacter = 0;
        static int v1 = 0;
        static int v2 = 0;
        static  int stepX = 0;

        internal static int Gen1()
        {
            bool x = true;
            while (x)
            {
                nextCharacter = generate();
                if (nextCharacter != lastChar)
                {
                    lastChar = nextCharacter;
                    x = false;
                }
            }
            return nextCharacter;
        }

        internal static int Gen2()
        {
            bool x = true;
            while (x)
            {
                v1 = generate();
                if (v1 != lastChar)
                {
                    x = false;
                }
            }
            return v1;
        }

        internal static int Gen3()
        {
            bool x = true;
            while (x)
            {
                v2 = generate();
                if (v2 != lastChar)
                {
                    x = false;
                }
            }
            return v2;
        }

        private static int generate()
        {
            int nextChar = random.Next(46);
            return nextChar;
        }

        internal static int Get(string v, int steps)
        {
            if (stepX == steps)
            {
                if (v == "ok")
                {
                    return nextCharacter;
                }
                else if(v == "v1")
                {
                    return v1;
                }
                else if (v == "v2")
                {
                    return v2;
                }
                else
                {
                    return v2;
                }
            }
            else
            {
                int a = Gen1();
                int b = Gen2();
                int c = Gen3();

                stepX = steps;
                if (v == "ok")
                {
                    return a;
                }
                else if (v == "v1")
                {
                    return v1;
                }
                else if (v == "v2")
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
        }
    }
}