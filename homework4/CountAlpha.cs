using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace homework4
{
    public class CountAlpha
    {
        public static int CountAlphaFunction(string insertStr)
        {
            int intDuplicate = 0;
            Dictionary<string, int> countDic = new Dictionary<string, int>();
            if (string.IsNullOrEmpty(insertStr))
            {
                return intDuplicate;
            }
            else
            {
                for(int i = 0; i < insertStr.Length; i++)
                {
                    if (countDic.ContainsKey(insertStr.Substring(i, 1).ToLower()))
                    {
                        countDic[insertStr.Substring(i, 1).ToLower()] ++;
                    }
                    else
                    {
                        countDic.Add(insertStr.Substring(i, 1).ToLower(), 0);
                    }               
                }
                foreach(var numCount in countDic)
                {
                    if(numCount.Value != 0)
                    {
                        intDuplicate ++;
                    }
                }
            }
            return intDuplicate;
        }
    }
}
