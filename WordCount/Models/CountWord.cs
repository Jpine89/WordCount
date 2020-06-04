﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WordCount.Models
{
    public class CountWord
    {
        public CountWord()
        {
            Values = new Dictionary<string, int>();
        }

        public Dictionary<string, int> Values { get; set; }

        public CountWord Add(string key, int value)
        {
            Values.Add(key, value);
            return this;
        }

        public CountWord StopWord()
        {
            var model = new CountWord();
            FileStream fileStream = new FileStream("stop-words.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                Console.WriteLine("This is C#");
                string test = reader.ReadLine();
            }

            return model;
        }
    }

}