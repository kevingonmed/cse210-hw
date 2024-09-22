using System;

class Program
{
    static void Main()
    {

        Console.Write("Enter your grade percentage: ");
        float gradePercentage = float.Parse(Console.ReadLine());

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        Console.WriteLine("Your letter grade is: " + letter);


        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't worry! Keep trying for next time.");
        }


        string sign = "";
        if (letter != "F" && letter != "A")
        {
            int lastDigit = (int)gradePercentage % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        string finalGrade = letter;
        if (letter == "A" && sign != "")
        {
            finalGrade = "A-";
        }
        else if (letter == "F")
        {
            finalGrade = "F";
        }
        else
        {
            finalGrade += sign;
        }


        Console.WriteLine("Your final grade is: " + finalGrade);
    }
}
