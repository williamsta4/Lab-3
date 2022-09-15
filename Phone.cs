﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
    internal class Phone
    {
        public string Number { get; init; } = String.Empty;

        public Phone(char separator = '-')
        {
            Number = Format();
        }

        public string Format(char separator = '-')
        {
            Random random = new Random();
            int[] randomNumbers = new int[10];
            string phoneNumber = "";

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(10);
            }

            if (randomNumbers[0] == 0 || randomNumbers[0] == 1)
            {
                randomNumbers[0] = random.Next(2, 10);
            }

            // turn the array into one concatenated string
            foreach (int i in randomNumbers)
            {
                phoneNumber = phoneNumber + i;
                //phoneNumber += i;
            }

            phoneNumber = phoneNumber.Insert(3, separator.ToString()).Insert(7, separator.ToString());

            return phoneNumber;
        }

        public override string ToString()
        {
            return Number;
        }
    }
}
