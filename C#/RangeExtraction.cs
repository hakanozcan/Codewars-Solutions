//4 kyu
//https://www.codewars.com/kata/51ba717bb08c1cd60f00002f
using System;
using System.Collections.Generic;
using System.Linq;


    public class RangeExtraction
    {
        public static string Extract(int[] args)
        {
            List<int> seq = new List<int>();
            string result = "";
            for (int i = 0; i < args.Length; i++)
            {
                seq.Add(args[i]);
                if (i == args.Length - 1 || args[i + 1] != args[i] + 1)
                {
                    if (seq.Count < 3)
                    {
                        result += string.Join(",", seq) + ",";
                    }
                    else
                    {
                        result += seq[0] + "-" + seq[^1] + ",";
                    }
                    seq.Clear();
                }
            }
            return result.TrimEnd(',');
        }
    }