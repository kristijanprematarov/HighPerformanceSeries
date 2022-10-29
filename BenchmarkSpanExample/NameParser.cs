﻿using System;
using System.Linq;

namespace BenchmarkSpanExample
{
    public class NameParser
    {
        public string GetLastName(string fullName)
        {
            var names = fullName.Split(" ");

            var lastName = names.LastOrDefault();

            return lastName ?? string.Empty;
        }
    }
}
