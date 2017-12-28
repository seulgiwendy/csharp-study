using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExperiment
{
    class CSharpVariables
    {
        int globalVariable;
        const int MAX = 1024;

        public void forLoop()
        {
            for(int i = 0; i < MAX; i++)
            {
                Console.WriteLine(i);
            }
            globalVariable = 100;
            Console.WriteLine("전역 변수를 할당하였다!");
        }
        class Program
        {
            static void Main(string[] args)
            {
                CSharpVariables variables = new CSharpVariables();
                Console.WriteLine(CSharpVariables.MAX);
                variables.forLoop();
            }
        }
    }
}
