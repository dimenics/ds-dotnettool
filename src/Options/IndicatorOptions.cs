﻿using CommandLine;

namespace Dime.Scheduler.CLI
{
    public abstract class IndicatorOptions : BaseOptions
    {
        [Option('n', "name", Required = true)]
        public string Name { get; set; }

        [Option('h', "hex", Required = true)]
        public string Color { get; set; }
    }
}