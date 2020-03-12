﻿using System.Collections.Generic;
using System.Linq;

namespace DailyChallenges
{
    public static class DailyChallenge1
    {
        /* Challenge:
         Good morning! Here's your coding interview problem for today. This problem was recently asked by Google.

        Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
        For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
        */
        public static bool DoAddendsExistInList(List<int> numbers, int sum)
        {
            foreach (var n in numbers)
            {
                var newList = numbers.ToList();
                newList.Remove(n);
                if (newList.Contains(sum - n))
                    return true;
            }
            return false;
        }
    }
}
