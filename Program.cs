using System;
using System.CommandLine.DragonFruit;

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
            if (verbose)
            {
                Console.WriteLine("Running in verbose mode");
            }
            Console.WriteLine($"inplace: {inplace}, config: {config}");
            foreach (var i in args)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
