using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyChallenges
{
    public static class DailyChallenge1
    {
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
