﻿using System;

namespace solution
{
    class Program
    {

        static int[] input = new[] {83453,
                                    89672,
                                    81336,
                                    74923,
                                    71474,
                                    117060,
                                    55483,
                                    116329,
                                    123515,
                                    99383,
                                    80314,
                                    108221,
                                    128335,
                                    72860,
                                    139235,
                                    127843,
                                    140120,
                                    63561,
                                    68854,
                                    109062,
                                    146211,
                                    59096,
                                    123085,
                                    105763,
                                    127657,
                                    142212,
                                    111007,
                                    100166,
                                    63641,
                                    59010,
                                    108575,
                                    93619,
                                    144095,
                                    74561,
                                    95059,
                                    145318,
                                    81404,
                                    96567,
                                    91799,
                                    92987,
                                    107137,
                                    87678,
                                    126842,
                                    85594,
                                    116330,
                                    104714,
                                    128117,
                                    132641,
                                    75602,
                                    90747,
                                    69038,
                                    67322,
                                    146147,
                                    147535,
                                    83266,
                                    85908,
                                    124634,
                                    51681,
                                    104430,
                                    56202,
                                    68631,
                                    69970,
                                    116985,
                                    140878,
                                    125357,
                                    126229,
                                    66379,
                                    103213,
                                    108210,
                                    73855,
                                    130992,
                                    113363,
                                    82298,
                                    111468,
                                    110751,
                                    52272,
                                    103661,
                                    122262,
                                    114363,
                                    80881,
                                    65183,
                                    125291,
                                    100119,
                                    56995,
                                    101634,
                                    55467,
                                    136284,
                                    107433,
                                    95647,
                                    71462,
                                    133265,
                                    104554,
                                    62499,
                                    61347,
                                    68675,
                                    123501,
                                    113954,
                                    135798,
                                    80825,
                                    128235};

        static void Main(string[] args)
        {
            int sum = 0;
            foreach(var item in input)
            {
                sum += DoMathToInput(item);
            }
            Console.WriteLine(sum.ToString());
        }

        private static int DoMathToInput(int input)
        {
            return (int)(Math.Floor((decimal)input/3) - 2);
        }

        private static void DoMathToInputTests()
        {
            if(DoMathToInput(12) == 2)
            {
                Console.WriteLine("Pass1");
            }
            else
            {
                Console.WriteLine("Fail1");
            }
            if(DoMathToInput(14) == 2)
            {
                Console.WriteLine("Pass2");
            }
            else
            {
                Console.WriteLine("Fail2");
            }
            if(DoMathToInput(1969) == 654)
            {
                Console.WriteLine("Pass3");
            }
            else
            {
                Console.WriteLine("Fail3");
            }
            if(DoMathToInput(100756) == 33583)
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
