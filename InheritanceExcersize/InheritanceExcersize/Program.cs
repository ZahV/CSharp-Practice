﻿using System;
using System.Runtime.InteropServices;

namespace InheritanceExcersize
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }
    }
}
