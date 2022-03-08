using System;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] month = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            char answer, ans, option;
            int[] number_of_days = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int x, days, year, start_day, february;


            year = 2021;
            Console.Write("\n\n");

            if (year > 0)
            {
                start_day = det_start_day(year);
                february = det_leapyear(year);
                number_of_days[1] = february;


                for (x = 0; x < 12; x++) //*this will output the calendar*//
                {
                    //*this will output the names of the month*//

                    if (x == 0)
                    {
                        Console.Write("\t\t\t\tJanuary\n");
                    }
                    else if (x >= 2 && x <= 7)
                    {
                        Console.Write("\t\t\t\t {0}\n", month[x]);
                    }

                    else
                    {
                        Console.Write("\t\t\t\t{0}\n", month[x]);
                    }

                    Console.Write("\t\t=========================================\n");
                    Console.Write("\t\tSun Mon Tue Wed Thur Fri Sat\n");
                    Console.Write("\t\t=========================================\n");

                    Console.Write("\t\t");

                    for (days = 1; days <= start_day; days++) //*determines the location of the first day of the month*//
                    {
                        Console.Write(" ", days);
                    }

                    for (days = 1; days <= number_of_days[x]; days++) //*this will output the dates*//
                    {
                        Console.Write(" {0,2}", days);

                        if (((days + start_day) % 7) > 0) //*determines if the printed dates already make up a week*//
                        {
                            Console.Write(" ");
                        }

                        else //*starts a new week*//
                        {
                            Console.Write("\n\t\t");
                        }
                    }


                    Console.Write("\n\n\n");
                    start_day = (start_day + number_of_days[x]) % 7; //*determines the start of the day in the next month*//
                }
            }


            Console.WriteLine("\t\t Do you have plans for this year? ☺");
            Console.Write("\n\n\t\t Enter 'y' or 'Y' if Yes, Enter 'n' if NO: ");
            option = char.Parse(Console.ReadLine());
            while (option == 'y' || option == 'Y')
            {
                Console.Clear();
                explain();
                calplanner();
            }

            if (option == 'n' || option == 'N')
            {
                Console.WriteLine("\t\t\t\t\tOk, see ya!");
            }

            else
            {
                Console.Clear();
            }

        }
        public static void calplanner()
        {
            int num = 0, month = 0, day = 0;


            Console.Write("\n\n\nEnter month<1-12>: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("\t\t\t\t{0} / {1} / 2015", month, day);
            question();
        }

        public static void explain()
        {

            Console.Write("To choose time for the next step use the following numbers:\n\n");
            Console.WriteLine("1 - 5:00 am 2 - 6:00am 3 - 7:00am 4 - 8:00am 5 - 9:00am 6 - 10:00 am\n");
            Console.WriteLine("7 - 11:00am 8 - 12:00pm 9 - 1:00pm 10 - 2:00pm 11 - 3:00pm 12 - 4:00pm\n");
            Console.WriteLine("13 - 5:00pm 14 - 6:00pm 15 - 7:00pm 16 - 8:00 pm 17 - 9:00pm 18 - 10:00 pm\n");
            Console.Write("\n");
            Console.Write("To input plans for new date type '0'");
            Console.WriteLine("\n\n");
        }
        static private void question()
        {
            int day = 0, i = 0, numtime, month = 0, year = 0;
            char ans, yn;
            string input;



            do
            {
                Console.Write("\n");
                Console.Write("\t");
                numtime = Convert.ToInt32(Console.ReadLine());

                for (i = numtime; i <= numtime; i++)
                {
                    switch (numtime)
                    {
                        case 0:
                            calplanner();
                            break;
                        case 1:

                            Console.Write("\t - 5:00 am : ");
                            input = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("\t - 6:00 am : ");
                            input = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("\t - 7:00 am : ");
                            input = Console.ReadLine();
                            break;
                        case 4:
                            Console.Write("\t - 8:00 am : ");
                            input = Console.ReadLine();
                            break;
                        case 5:
                            Console.Write("\t - 9:00 am : ");
                            input = Console.ReadLine();
                            break;
                        case 6:
                            Console.Write("\t - 10:00 am : ");
                            input = Console.ReadLine();
                            break;
                        case 7:
                            Console.Write("\t - 11:00 am : ");
                            input = Console.ReadLine();
                            break;
                        case 8:
                            Console.Write("\t - 12:00 pm : ");
                            input = Console.ReadLine();
                            break;
                        case 9:
                            Console.Write("\t - 1:00 pm : ");
                            input = Console.ReadLine();
                            break;
                        case 10:
                            Console.Write("\t - 2:00 pm : ");
                            input = Console.ReadLine();
                            break;
                        case 11:
                            Console.Write("\t - 3:00 pm : ");
                            input = Console.ReadLine();
                            break;
                        case 12:
                            Console.Write("\t - 4:00 pm : ");
                            input = Console.ReadLine();
                            break;
                        case 13:
                            Console.Write("\t - 5:00 pm : ");
                            input = Console.ReadLine();
                            break;
                        case 14:
                            Console.Write("\t - 6:00 pm : ");
                            input = Console.ReadLine();
                            break;
                        case 15:
                            Console.Write("\t - 7:00 pm : ");
                            input = Console.ReadLine();
                            break;
                        case 16:
                            Console.Write("\t - 8:00 pm : ");
                            input = Console.ReadLine();
                            break;
                        case 17:
                            Console.Write("\t - 9:00 pm : ");
                            input = Console.ReadLine();
                            break;
                        case 18:
                            Console.Write("\t - 10:00 pm : ");
                            input = Console.ReadLine();
                            break;
                        default:
                            Console.Write("No more available slot for that plan.");
                            break;
                    }


                }

                yn = 'y';
            } while (yn == 'y');



        }


        static private int det_start_day(int num)
        {
            int d1, d2, d3, start_day;

            d1 = (num - 1) / 4;
            d2 = (num - 1) / 100;
            d3 = (num - 1) / 400;
            start_day = (num + d1 - d2 + d3) % 7; //*formula in determining the first day of the year*//

            return start_day;
        }



        public static int det_leapyear(int num)
        {
            int det_4, det_100, det_400, february;

            det_4 = num % 4;
            det_100 = num % 100;
            det_400 = num % 400;

            //*a year is considered a leap year if it is divisible by 4*//
            //*if the year satisfies the first condition and is not divisible by 100, it is still a leap year*//
            //*if the said year meets the first condition at the same time is divisible by 100, it will only be considered a leap year if it is also divisible by 400*//

            if (det_4 == 0)
            {
                if (det_100 != 0)
                {
                    february = 29;
                }

                else if (det_100 == 0 && det_400 == 0)
                {
                    february = 29;
                }

                else
                {
                    february = 28;
                }
            }

            else
            {
                february = 28;
            }

            return february;
        }
    }
}