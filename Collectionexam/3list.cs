using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Collectionexam
{
    class _3list
    {
        static void Main(string[] args)
        {
            
                List<string> l1 = new List<string>() { "red", "red", "blue", "pink", "blue", "red" };
                //key is color--value is count
                Dictionary<string, int> dd = new Dictionary<string, int>();
                foreach (string color in l1)
                {
                    if (dd.ContainsKey(color))
                    {
                        int val = dd[color];
                        dd[color] = val + 1;
                    }
                    else
                    {
                        dd.Add(color, 1);
                    }
                }
                foreach (KeyValuePair<string, int> kv in dd)
                    Console.WriteLine(kv.Key + ".." + kv.Value);
            }
        }
    }

