using System;

namespace Day2
{
    class Program
    {

        static int[] input = new[] {1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,9,1,19,1,5,19,23,2,9,23,27,1,27,5,31,2,31,13,35,1,35,9,39,1,39,10,43,2,43,9,47,1,47,5,51,2,13,51,55,1,9,55,59,1,5,59,63,2,6,63,67,1,5,67,71,1,6,71,75,2,9,75,79,1,79,13,83,1,83,13,87,1,87,5,91,1,6,91,95,2,95,13,99,2,13,99,103,1,5,103,107,1,107,10,111,1,111,13,115,1,10,115,119,1,9,119,123,2,6,123,127,1,5,127,131,2,6,131,135,1,135,2,139,1,139,9,0,99,2,14,0,0};

        static void Main(string[] args)
        {

        }

        static int[] DoWork(int[] input)
        {

        }

        static (int, int) TranslateOpCode(int[] input)
        {

        }

        static void OpcodeTests()
        {
            int[] input1 = {1,0,0,0,99};
            int[] output1 = {2,0,0,0,99};
            if(DoWork(input1) == output1)
            {
                Console.WriteLine("Pass1");
            }
            else
            {
                Console.WriteLine("Fail1");
            }

            int[] input2 = {2,3,0,3,99};
            int[] output2 = {2,3,0,6,99};
            if(DoWork(input2) == output2)
            {
                Console.WriteLine("Pass2");
            }
            else
            {
                Console.WriteLine("Fail2");
            }

            int[] input3 = {2,4,4,5,99,0};
            int[] output3 = {22,4,4,5,99,9801};
            if(DoWork(input3) == output3)
            {
                Console.WriteLine("Pass3");
            }
            else
            {
                Console.WriteLine("Fail3");
            }

            int[] input4 = {1,1,1,4,99,5,6,0,99};
            int[] output4 = {30,1,1,4,2,5,6,0,99};
            if(DoWork(input4) == output4)
            {
                Console.WriteLine("Pass4");
            }
            else
            {
                Console.WriteLine("Fail4");
            }

        }
    }
}
