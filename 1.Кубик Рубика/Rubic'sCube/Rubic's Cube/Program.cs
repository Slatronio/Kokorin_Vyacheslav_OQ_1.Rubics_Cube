using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Xml.Resolvers;

class Program
{
    static void Main()
    {
        for (int l = 1; l < 21; l++)
        {
            string path = "input_s1_0" + Convert.ToString(l) + ".txt";
            if (l > 9) path = "input_s1_" + Convert.ToString(l) + ".txt";
            StreamReader file = new StreamReader(path);
            string[] str = file.ReadLine().Split();
            int n = Convert.ToInt32(str[0]);
            int m = Convert.ToInt32(str[1]);
            str = file.ReadLine().Split();
            int xn = Convert.ToInt32(str[0]);
            int yn = Convert.ToInt32(str[1]);
            int zn = Convert.ToInt32(str[2]);
            int xk = 0;
            int yk = 0;
            int zk = 0;
            for (int i = 0; i < m; i++)
            {
                int p = 0;
                str = file.ReadLine().Split();
                string a = str[0];
                int k = Convert.ToInt32(str[1]);
                int s = Convert.ToInt32(str[2]);
                switch (a)
                {
                    case "X":
                    {
                        if (k == xn)
                        {
                            xk = xn;
                            p++;
                            if (s == 1)
                            {
                                yk = zn;
                                zk = n - yn + 1;
                            }
                            else
                            {
                                yk = n - zn + 1;
                                zk = yn;
                            }
                        }
                        break;
                    }
                    case "Y":
                    {
                        if (k == yn)
                        {
                            yk = yn;
                            p++;
                            if (s == 1)
                            {
                                xk = zn;
                                zk = n - xn + 1;
                            }
                            else
                            {
                                xk = n - zn + 1;
                                zk = xn;
                            }
                        }
                        break;
                    }
                    case "Z":
                    {
                        if (k == zn)
                        {
                            zk = zn;
                            p++;
                            if (s == 1)
                            {
                                xk = yn;
                                yk = n - xn + 1;
                            }
                            else
                            {
                                xk = n - yn + 1;
                                yk = xn;
                            }
                        }
                        break;
                    }
                }
                if (p != 0)
                {
                    xn = xk;
                    yn = yk;
                    zn = zk;
                    xk = 0;
                    yk = 0;
                    zk = 0;
                }
            }
            Console.WriteLine(xn + " " + yn + " " + zn);
        }
    }
}