using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2_Sav
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
        const string CFd = "U1.txt";
        const string CFr = "Rezultatai.txt";

            Console.InputEncoding = Encoding.GetEncoding(1257);
            Console.OutputEncoding = Encoding.UTF8;

            Apdoroti_Spausdinti(CFd, CFr);
        }
        static void Apdoroti_Spausdinti(string fv, string fvr)
        {
            string[] lines = File.ReadAllLines(fv, Encoding.GetEncoding(1257));
            int eilKiekis = EiluciuKiekis(fv);
            int n = 1;
            string line;
            using (StreamReader reader = new StreamReader(fv))
            {
                using (var fr = File.CreateText(fvr))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Trim().Length > 0)
                        {
                            fr.Write(line);
                            if (n != eilKiekis)
                            {
                                fr.Write("\n");
                            }
                        }
                        n++;
                    }
                }
            }

        }
        static int EiluciuKiekis(string fv)
        {
            string[] lines = File.ReadAllLines(fv);
            return lines.Length;
        }
    }
}