using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToCSharp
{
    class GradeCalculator
    {
        /// <summary>
        /// Compute the average of the grade 
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public double ComputeGrade(int[] grade)
        {
            double average;

            int sum = 0;

            for (int i = 0; i < grade.Length; i++)
            {
                sum += grade[i];
            }

            average = sum / grade.Length;

            return average;
        }
    }
}
