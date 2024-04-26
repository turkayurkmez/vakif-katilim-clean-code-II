﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Game
    {
        public string GetWord(int value)
        {
            if (value % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (value % 3==0)
            {
                return "Fizz";
            }
            else if(value % 5 ==0)
            {
                return "Buzz";
            }
            return value.ToString();
        }
    }
}
