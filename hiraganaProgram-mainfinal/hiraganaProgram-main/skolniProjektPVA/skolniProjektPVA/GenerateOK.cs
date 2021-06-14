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
        static int v3 = 0;
        static int v4 = 0;
        static int v5 = 0;
        static int v6 = 0;
        static int r1 = 0;
        static int r2 = 0;
        static int lr1 = 0;
        static int lr2 = 0;
       internal static  int stepX = -1;

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

        internal static int GetDoble(string v, int steps)
        {
            if (stepX == steps)
            {
                if (v == "ok1")
                {
                    return r1;
                }
                else if (v == "ok2")
                {
                    return r2;
                }
                else if (v == "v1")
                {
                    return v3;
                }
                else if (v == "v2")
                {
                    return v4;
                }
                else if (v == "v3")
                {
                    return v5;
                }
                else if (v == "v4")
                {
                    return v6;
                }
                else
                {
                    return v3;
                }
            }
            else
            {
                int a = GenDouble1();
                int b = GenDouble2();
                int c = GenDouble3();
                int d = GenDouble4();
                int e = GenDouble5();
                int f = GenDouble6();

                stepX = steps;
                if (v == "ok1")
                {
                    return a;
                }
                else if (v == "ok2")
                {
                    return b;
                }
                else if (v == "v1")
                {
                    return c;
                }
                else if (v == "v2")
                {
                    return d;
                }
                else if (v == "v3")
                {
                    return e;
                }
                else if (v == "v4")
                {
                    return f;
                }
                else
                {
                    return c;
                }
            }
        }

        internal static int GenDouble1()
        {
            bool x = true;
            while (x)
            {
                r1 = generate();
                if (r1 != lr1)
                {
                    lr1 = r1;
                    x = false;
                }
            }
            return r1;
        }

        internal static int GenDouble2()
        {
            bool x = true;
            while (x)
            {
                r2 = generate();
                if (r2 != lr2 && r2 != r1)
                {
                    lr2 = r2;
                    x = false;
                }
            }
            return r2;
        }

        internal static int GenDouble3()
        {
            bool x = true;
            while (x)
            {
                v3 = generate();
                if (v3 != r1 && v3 != r2)
                {
                    x = false;
                }
            }
            return v3;
        }

        internal static int GenDouble4()
        {
            bool x = true;
            while (x)
            {
                v4 = generate();
                if (v4 != r1 && v4 != r2)
                {
                    x = false;
                }
            }
            return v4;
        }

        internal static int GenDouble5()
        {
            bool x = true;
            while (x)
            {
                v5 = generate();
                if (v5 != r1 && v5 != r2)
                {
                    x = false;
                }
            }
            return v5;
        }

        internal static int GenDouble6()
        {
            bool x = true;
            while (x)
            {
                v6 = generate();
                if (v6 != r1 && v6 != r2)
                {
                    x = false;
                }
            }
            return v6;
        }
    }
}