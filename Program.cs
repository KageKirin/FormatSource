using System;
using System.CommandLine.DragonFruit;
using EditorConfig.Core;

namespace formatsource
{
    class Program
    {
        /// <summary>
        /// Apply EditorConfig settings to given input files
        /// </summary>
        /// <param name="config">editorconfig file</param>
        /// <param name="inplace">inplace edit, do not print the result to stdout, but write directly to input file</param>
        /// <param name="verbose">print verbose statements to stderr</param>
        /// <param name="args">input files</param>
        public static void Main(string config = ".editorconfig", bool inplace = false, bool verbose = false, string[] args = null)
        {
            var parser = new EditorConfigParser(
                configFileName: config
            );

            if (verbose)
            {
                Console.WriteLine("Running in verbose mode");
            }
            Console.WriteLine($"inplace: {inplace}, config: {config}");
            foreach (var i in args)
            {
                var configuration = parser.Parse(fileName: i);
                foreach (var kv in configuration.Properties)
                {
                    Console.WriteLine("{0}={1}", kv.Key, kv.Value);
                }

                Console.WriteLine($"{i}");
            }
        }
    }
}
