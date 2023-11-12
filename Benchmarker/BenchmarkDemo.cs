using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmarker
{
    //Documentation- https://benchmarkdotnet.org/
    [MemoryDiagnoser]
    public class BenchmarkDemo
    {
        [Benchmark(Baseline =true)]
        public string GetFullStringNormally()
        {
            string output = "";
            for (int i = 0; i < 100; i++)
            {
                output += i.ToString();
            }
            return output;
        }

        [Benchmark]
        public string GetFullStringByStringBuilder()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0;i < 100;i++)
            {
                output.Append(i.ToString());
            }
            return output.ToString();   
        }
    }
}
