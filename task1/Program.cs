using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace task1
{
    class Program
    {
        static int FindNumber(string textt)
        {
            int n = 0;
            string num="";
            char[] totrim = new char[1] { ' ' };
            string text=textt.TrimStart(totrim);
            while(text[n]!=' ')
            {
                num = num + text[n];
                n++;
            }
            while(text[n]==' ')
            {
                n++;
            }
            return Convert.ToInt32(num);
        }
        static void Main(string[] args)
        {
            FileStream f = new FileStream("input.txt",FileMode.OpenOrCreate);
            StreamReader r = new StreamReader(f);
            string text = r.ReadToEnd();
            r.Close();
            f.Close();
            int n1 = FindNumber(text);
            string text1=text.Replace(Convert.ToString(n1), " ");
            int n2 = Convert.ToInt32(text1.TrimStart(' '));
            FileStream f1 = new FileStream("output.txt", FileMode.Create);
            StreamWriter w = new StreamWriter(f1);
            w.Write(Convert.ToString(n1 + n2));
            w.Close();
            f1.Close();
        }
    }
}
