using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\pjm21\OneDrive\바탕 화면\test\test.txt";
            string text = File.ReadAllText(path);
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("name", "Jason");
            map.Add("message", "Please, check it out");
            foreach(var e in map)
            {
                string pattern = string.Format(@"{0}.({1}){2}", "{{", e.Key, "}}");
                Console.WriteLine(string.Format("key: {0}, pattern: {1}", e.Key, pattern));
                text = Regex.Replace(text, pattern, e.Value);
            }
            string result = string.Format("text: {0}", text);
            Console.WriteLine(result);
        }
    }
}
