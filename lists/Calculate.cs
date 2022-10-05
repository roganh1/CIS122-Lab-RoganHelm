// Written by Rogan Helm
// 10/5/22

// From line 17 to line 21 is my code
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;


namespace lists
{
    /*public class Calculate
    {
        public int TargetNumber = 5;
        public List<int> Numbers = new List<int> { 1, 20, 5, 6, 12, 30, 4, 6 };
    }*/
    public class FindNumbers
    {
        public List<int> FindTargets(List<int> aListOfInts, int aTarget)
        {
            int firstPosition = 0;
            int secondPosition = 1;
            List<int> answer = new List<int> { int.MinValue, int.MinValue };
            while (firstPosition < aListOfInts.Count)
            {
                if (aListOfInts[firstPosition] + aListOfInts[secondPosition] == aTarget)
                {
                    answer[0] = firstPosition;
                    answer[1] = secondPosition;
                }
                secondPosition++;
            }
            firstPosition = firstPosition + 1;
            secondPosition = secondPosition + 1;
        }
        return answer;
    }
}
