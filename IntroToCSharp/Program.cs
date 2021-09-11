using System;
using System.Text;

namespace IntroToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This is an example of a comment
             * multi line comment
             * 
             * */
            Console.WriteLine("Hello World!"); // print or echo text

            //StringBuilder stringBuilder = new StringBuilder();

            //stringBuilder.Append("This is ");
            //stringBuilder.Append(" a string from");
            //stringBuilder.Append(" the StringBuilder Class");
            //string a = Console.ReadLine();

            //string Variable;
            //string variable;
            //string variAble;

            //GradeCalculator gradeCalculator;

            //var number = 1234;
            //dynamic dynamicData = 12345.4567d;

            //Console.WriteLine($"Number type:{number.GetType()} DynamicData type:{dynamicData.GetType()}");

            //long a = 2147483649;
            //int convert = (int)a;
            //int intConvert = (int)convert;

            //Console.WriteLine($"Value: {a} Type: {a.GetType()}");
            //Console.WriteLine($"Value: {convert} Type: {convert.GetType()}");

            //Console.WriteLine($"Value: {intConvert} Type: {intConvert.GetType()}");


            int variableName = 10;

            //const int constantValue = 10;

            //bool isGreaterThan = variableName > constantValue;

            //string result;

            //if (variableName > constantValue)
            //{
            //    result = "isGreaterThan";
            //}
            //else
            //{
            //    result = "nope";
            //}


            //string result2 = variableName > constantValue ? "isGreaterThan" : "nope";


            //Console.WriteLine("This is a \nnew line");


            GradeCalculator gradeCalculator = new GradeCalculator();

            int[] grades = new int[5];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade:");

                string inputText = Console.ReadLine();

                if (string.IsNullOrEmpty(inputText))
                {
                    inputText = "0";
                }

                grades[i] = Int32.Parse(inputText);
            }

            var averageScore = gradeCalculator.ComputeGrade(grades);

            Console.WriteLine($"Average score: {averageScore.ToString("N4")}");



            Console.ReadKey();
        }


    }
}
