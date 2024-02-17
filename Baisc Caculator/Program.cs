namespace cgpga
{

    class Program
    {

        static void Main(string[] args)
        {
            double first, second, third, fourth, fifth, CGPA;
            char option;
            Console.Write("Enter the number of the first subject ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number of the second subject ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number of the third subject ");
            third = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number of the fourth subject ");
            fourth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number of the fifth subject ");
            fifth = Convert.ToDouble(Console.ReadLine());

            CGPA = ((first + second + third + fourth + fifth) / 5) / 9.5;//We are to divide per to 9.5
            Console.WriteLine("Your CGPA is =>" + CGPA);

            if (CGPA >= 8)
            {
                option = '1';
            }else if(CGPA>=6.5 && CGPA < 8)
            {
                option = '2';
            }else if(CGPA>= 3.5 && CGPA < 6.5)
            {
                option = '3';
            }
            else
            {
                option = 'F';
            }
            switch (option)
            {
                case '1': Console.WriteLine("Grade: First class with Distinction"); break;
                case '2': Console.WriteLine("Grade: Second class "); break;
                case '3': Console.WriteLine("Grade: Third class "); break;
                case 'F': Console.WriteLine("Grade: Fail "); break;
                default:  Console.WriteLine("Invalid GRADE"); break;

            }

            Console.ReadLine();



        }
    }
}

