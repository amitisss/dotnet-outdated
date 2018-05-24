﻿using System;
using McMaster.Extensions.CommandLineUtils;

namespace DotNetOutdated
{
    public static class ConsoleExtensions
    {
        public static void Write(this IConsole console, object value, ConsoleColor color)
        {
            ConsoleColor currentColor = console.ForegroundColor;
            
            console.ForegroundColor = color;
            console.Write(value);
            console.ForegroundColor = currentColor;
        }
        
        public static void WriteIndent(this IConsole console, int level)
        {
            console.Write(new String(' ', level * 2));
        }
    }
}