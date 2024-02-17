namespace task5
{
    internal class Program
    {
     
                                private static object l1;
        private static object l2;
        private static object l3;

        static void Main(string[] args)
        {
        l15:

            Console.Write("Enter number 1 :");
            string num1 = Console.ReadLine();
            bool state1 = int.TryParse(num1, out int number1);
            Console.Write("Enter number 2 :");
            string num2 = Console.ReadLine();
            bool state2 = int.TryParse(num1, out int number2);
            Console.Write("Enter number 3 :");
            string num3 = Console.ReadLine();
            bool state3 = int.TryParse(num1, out int number3);
            Console.Write("Enter number 4 :");
            string num4 = Console.ReadLine();
            bool state4 = int.TryParse(num1, out int number4);
            Console.Write("Enter number 5 :");
            string num5 = Console.ReadLine();
            bool state5 = int.TryParse(num1, out int number5);

            if (!(state5 && state4 && state3 && state2 && state1))
            {

                Console.WriteLine("Eded daxil edin.");
                goto l15;
            }

            if ((number1 < 1000 || number1 > 99) && (number2 < 1000 || number2 > 99) && (number3 > 99999 || number3 < 1000000) && (number4 > 99999 || number4 < 1000000) && (number5 > 999999 || number5 < 10000000))
            {
                int cem3 = number1 + number2;
                int k = cem3 % 10;
                int k2 = cem3 % 100;
                int k3 = k2 / 10;
                int k4 = (k3 + k) * (k3 + k);
                int yps = ((number1 * 1000) + number2) + k4;
                int n5 = number5 % 100000;
                int yps1 = yps - n5;
                int rqm6 = number3 + number4;
                int rqm7 = rqm6 % 1000;//Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.

                int sum = 0;
                int qaliq;
                while (number5 > 0)
                {
                    qaliq = number5 % 10;
                    number5 /= 10;
                    sum += qaliq;
                }

                int sum1 = 0;
                while (sum > 0)
                {
                    sum1 = sum1 * 10 + sum % 10;
                    sum /= 10;

                }

                int result2 = rqm7 + sum1;
                int result3 = (result2 * 100) + 11;
                int number6 = number5;

                int summ = 0;
                int resultt = 0;

                while (number6 > 0)
                {
                    summ = summ * 10 + number6 % 10;
                    number6 = number6 / 100;

                }

                while (summ > 0)
                {
                    resultt = resultt * 10 + summ % 10;
                    summ = summ / 10;

                }
                int result4 = result3 - summ;
                int result5 = ((result4 / 10) * 100) + 88;
                int result7 = result4 % 10;
                int result8 = (result5 * 10) + result7;


                Console.WriteLine($"Netice :{result8}");




            }


            else
            {
                Console.WriteLine("Yeniden daxil edin.");
                goto l15;
            }



        }
        static void Task1()
        {
            //l1:

            //    Console.Write("Enter number 1 :");
            //    string num1 = Console.ReadLine();
            //    bool state = int.TryParse(num1, out int number);



            //    if (!state)
            //    {
            //        Console.WriteLine("Sehv daxil edilib ");
            //        goto l1;

            //    }
            //    if (number > 999 && number < 10000)
            //    {
            //        int sum = 0;
            //        int qaliq;
            //        while (number > 0)
            //        {

            //            qaliq = number % 10;
            //            number /= 10;
            //            sum += qaliq;
            //        }
            //        Console.WriteLine(sum);


            //    }
            //    else
            //    {
            //        Console.WriteLine("Eded 4 reqemli deyil.");
            //        goto l1;
            //    }
        }

        private static void Task2()
        {
            //l2:

            //    Console.Write("Eded daxil edin : ");
            //    string num = Console.ReadLine();
            //    bool state = int.TryParse(num, out int number);


            //    if (!state)
            //    {
            //        Console.WriteLine("Duzgun daxil edin.");
            //        goto l2;

            //    }
            //    if (number > 99999 && number < 1000000)
            //    {
            //        int result = number / 1000;
            //        int sum = 0;
            //        int qaliq;
            //        while (result > 0)
            //        {
            //            qaliq = result % 10;
            //            result /= 10;
            //            sum += qaliq;


            //        }
            //        Console.WriteLine(sum);

            //    }
            //    else
            //    {
            //        Console.WriteLine("Ededi 6 reqemli deil.");
            //        goto l2;
            //    }
        }
        private static void Task3()
        {
            //l3:

            //    Console.Write("Eded daxil edin : ");
            //    string num = Console.ReadLine();
            //    bool state = int.TryParse(num, out int number);


            //    if (!state)
            //    {
            //        Console.WriteLine("Duzgun daxil edin.");
            //        goto l3;

            //    }
            //    if (number > 99999999 && number < 1000000000)
            //    {

            //        int number1 = number / 1000;
            //        int result = number1 % 1000;
            //        int sum = 0;
            //        int qaliq;

            //        while (result > 0)
            //        {
            //            qaliq = result % 10;
            //            result /= 10;
            //            sum += qaliq;


            //        }
            //        Console.WriteLine(sum);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Eded 9 reqemli deil.");
            //        goto l3;
            //    }

        }

        private static void Task4()
        {
            //l4:

            //    Console.Write("Eded daxil edin : ");
            //    string num = Console.ReadLine();
            //    bool state = int.TryParse(num, out int number);


            //    if (!state)
            //    {
            //        Console.WriteLine("Duzgun daxil edin.");
            //        goto l4;

            //    }
            //    if (number > 9999 && number < 100000)
            //    {
            //        int n1 = number % 10;
            //        int n2 = number / 10000;
            //        int result = (n1 + n2) * (n1 + n2);

            //        Console.WriteLine($"Cavab : {result}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Eded 5 reqemli deyil.");
            //        goto l4;
            //    }

        }
        private static void Task5()
        {
            //l5:

            //    Console.Write("Eded daxil edin : ");
            //    string num = Console.ReadLine();
            //    bool state = int.TryParse(num, out int number);


            //    if (!state)
            //    {
            //        Console.WriteLine("Duzgun daxil edin.");
            //        goto l5;

            //    }
            //    if (number > 99999 && number < 1000000)
            //    {
            //        int n1 = number % 100000;

            //        int n2 = number / 100000;
            //        int result = n1 * 10 + n2;


            //        Console.WriteLine($"Cavab : {result}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Eded 6 reqemli deyil.");
            //        goto l5;
            //    }

        }
        private static void Task6()
        {
            //l6:

            //    Console.Write("Eded daxil edin : ");
            //    string num = Console.ReadLine();
            //    bool state = int.TryParse(num, out int number);


            //    if (!state)
            //    {
            //        Console.WriteLine("Duzgun daxil edin.");
            //        goto l6;

            //    }
            //    if (number > 9999999 && number < 100000000)
            //    {
            //        int n1 = number % 10000000;

            //        int n2 = n1 / 10;



            //        Console.WriteLine($"Cavab : {n2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Eded 6 reqemli deyil.");
            //        goto l6;
            //    }
        }
        private static void Task7()
        {
            //l7:

            //    Console.Write("Eded daxil edin : ");
            //    string num = Console.ReadLine();
            //    bool state = int.TryParse(num, out int number);


            //    if (!state)
            //    {
            //        Console.WriteLine("Duzgun daxil edin.");
            //        goto l7;

            //    }
            //    if (number > 999 && number < 10000)
            //    {
            //        int sum = 0;
            //        while (number > 0)
            //        {
            //            sum = sum * 10 + number % 10;
            //            number /= 10;
            //        }
            //        int result = sum + 80000;


            //        Console.WriteLine($"Netice :  {result}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Eded 4 reqemli deyil.");
            //        goto l7;
            //    }

        }
        private static void Task8()
        {
            //l8:

            //    Console.Write("Eded daxil edin : ");
            //    string num = Console.ReadLine();
            //    bool state = int.TryParse(num, out int number);


            //    if (!state)
            //    {
            //        Console.WriteLine("Duzgun daxil edin.");
            //        goto l8;

            //    }
            //    if (number > 0)
            //    {
            //        int n1 = number % 10;
            //        int n2 = number / 100;
            //        int n3 = n2 % 10;
            //        int result = n1 + n3;
            //        Console.WriteLine($"Cavab : {result}");
            //    }

        }
        private static void Task9()
        {
            //l9:

            //    Console.Write("Eded daxil edin : ");
            //    string num = Console.ReadLine();
            //    bool state = int.TryParse(num, out int number);


            //    if (!state)
            //    {
            //        Console.WriteLine("Duzgun daxil edin.");
            //        goto l9;

            //    }
            //    if (number > 99999999 && number < 1000000000)
            //    {
            //        int result = 0;
            //        int sum = 0;
            //        while (number > 0)
            //        {
            //            sum = sum * 10 + number % 10;
            //            number = number / 100;


            //        }
            //        while (sum > 0)
            //        {
            //            result = result * 10 + sum % 10;
            //            sum = sum / 10;

            //        }
            //        Console.WriteLine($"Cavab {result}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Eded 9 reqemli deyil.");
            //        goto l9;
            //    }
        }
        private static void Task10()
        {
            //l10:

            //    Console.Write("Eded daxil edin : ");
            //    string num = Console.ReadLine();
            //    bool state = int.TryParse(num, out int number);
            //    int number2 = number;


            //    if (!state)
            //    {
            //        Console.WriteLine("Duzgun daxil edin.");
            //        goto l10;

            //    }
            //    if (number > 99999999 && number < 1000000000)
            //    {
            //        int result = 0;
            //        int sum = 0;
            //        int result1 = 0;
            //        int sum1 = 0;
            //        while (number > 0)
            //        {
            //            sum = sum * 10 + number % 10;
            //            number = number / 100;


            //        }
            //        while (sum > 0)
            //        {
            //            result = result * 10 + sum % 10;
            //            sum = sum / 10;



            //        }
            //        Console.WriteLine($"Tek eded :{result}");
            //        while (number2 > 0)
            //        {
            //            sum1 = sum1 * 10 + ((number2 % 100) - (number2 % 10)) / 10;
            //            number2 = number2 / 100;


            //        }
            //        sum1 /= 10;
            //        while (sum1 > 0)
            //        {
            //            result1 = result1 * 10 + sum1 % 10;
            //            sum1 = sum1 / 10;

            //        }
            //        Console.WriteLine($"Cut Eded :{result1}");
            //        int cem = result + result1;
            //        Console.WriteLine($"Cem :{cem}");



            //    }
            //    else
            //    {
            //        Console.WriteLine("Eded 9 reqemli deyil.");
            //        goto l10;
            // }
        }
        private static void Task11()
        {
        l11:

            Console.Write("Eded daxil edin : ");
            string num = Console.ReadLine();
            bool state = int.TryParse(num, out int number);


            if (!state)
            {
                Console.WriteLine("Duzgun daxil edin.");
                goto l11;

            }
            if (number > 9999999 && number < 100000000)
            {
                int qaliq = 0;
                int sum = 0;
                while (number > 0)
                {
                    qaliq = number % 100;
                    number /= 100;
                    sum += qaliq;


                }
                float result = sum * 100 + 99;
                float result2 = (result * 18) / 100;
                float result3 = result - result2;
                Console.WriteLine($"Netice :{result3}");


            }

            else
            {
                Console.WriteLine("Eded 8 reqemli deyil.");
                goto l11;
            }
        }
        private static void Task12()
        {
            //l12:

            //    Console.Write("Eded daxil edin : ");
            //    string num = Console.ReadLine();
            //    bool state = int.TryParse(num, out int number);
            //    Console.Write("2ci ededi daxil edin : ");
            //    string num2 = Console.ReadLine();
            //    bool state2 = int.TryParse(num2, out int number2);

            //    int result4 = number % 10;

            //    if (!(state && state2))
            //    {
            //        Console.WriteLine("Duzgun daxil edin.");
            //        goto l12;

            //    }
            //    if ((number > 9999 && number < 100000) && (number2 > 9999 && number2 < 100000))
            //    {
            //        int sum = 0;
            //        int qaliq;
            //        int sum2 = 1;
            //        int qaliq2;

            //        while (number > 0)
            //        {
            //            qaliq = number % 10;
            //            number /= 10;
            //            sum += qaliq;
            //        }
            //        Console.WriteLine($"Cem :{sum}");
            //        while (number2 > 0)
            //        {
            //            qaliq2 = number2 % 10;
            //            number2 /= 10;
            //            sum2 *= qaliq2;
            //        }
            //        Console.WriteLine($"Hasil :{sum2}");

            //        int result = sum + sum2;

            //        int result2 = result * 10;


            //        int result3 = result2 + result4;
            //        Console.WriteLine($"Netice :{result3}");
            //    }

            //    else
            //    {
            //        Console.WriteLine("Eded 5 reqemli deyil.");
            //        goto l12;
            //    }
        }
        private static void Task13()
        {
            //l13:

            //    Console.Write("Eded daxil edin : ");
            //    string num = Console.ReadLine();
            //    bool state = int.TryParse(num, out int number);
            //    Console.Write("2ci ededi daxil edin : ");
            //    string num2 = Console.ReadLine();
            //    bool state2 = int.TryParse(num2, out int number2);
            //    Console.Write("3cu eded daxil edin : ");
            //    string num3 = Console.ReadLine();
            //    bool state3 = int.TryParse(num3, out int number3);


            //    if (!(state && state2 && state3))
            //    {
            //        Console.WriteLine("Duzgun daxil edin.");
            //        goto l13;

            //    }
            //    if ((number > 9999 && number < 100000) && (number2 > 9999 && number2 < 100000) && (number3 > 9999 && number3 < 100000))
            //    {
            //        int n1 = (number / 10000) * 10;
            //        int n11 = number % 10 + n1;
            //        int n2 = (number2 / 10000) * 10;
            //        int n22 = number2 % 10 + n2;
            //        int n3 = (number3 / 10000) * 10;
            //        int n33 = number3 % 10 + n2;
            //        int result = n11 + n22 + n33;
            //        int result1 = result + (result / 2);
            //        Console.WriteLine($"Cavab :{result1}");


            //    }

            //    else
            //    {
            //        Console.WriteLine("Eded 5 reqemli deyil.");
            //        goto l13;
            //    }
        }
        private static void Task14()
        {
            //Console.Write("Eded daxil edin : ");
            //string num = Console.ReadLine();
            //bool state = int.TryParse(num, out int number);
            //Console.Write("2ci ededi daxil edin : ");
            //string num2 = Console.ReadLine();
            //bool state2 = int.TryParse(num2, out int number2);
            //Console.Write("3cu eded daxil edin : ");
            //string num3 = Console.ReadLine();
            //bool state3 = int.TryParse(num3, out int number3);
            //Console.Write("4cu eded daxil edin : ");
            //string num4 = Console.ReadLine();
            //bool state4 = int.TryParse(num3, out int number4);





            //number = number / 1000;
            //number2 = number2 / 1000;
            //number3 = number3 / 1000;
            //int sum = 0;
            //int qaliq;
            //int sum2 = 0;
            //int qaliq2;
            //int sum3 = 0;
            //int qaliq3;
            //while (number2 > 0 && number > 0 && number3 > 0)
            //{
            //    qaliq = number % 10;
            //    number /= 10;
            //    sum += qaliq;

            //    qaliq2 = number2 % 10;
            //    number2 /= 10;
            //    sum2 += qaliq2;

            //    qaliq3 = number3 % 10;
            //    number3 /= 10;
            //    sum3 += qaliq3;

            //}
            //int numm4 = number4 % 10000;
            //int r5 = sum + sum2 + sum3;
            //int r6 = r5 + numm4;
            //int n4 = number4 / 10000;
            //int sum4 = 1;
            //int qaliq4;
            //while (n4 > 0)
            //{
            //    qaliq = n4 % 10;
            //    n4 /= 10;
            //    sum4 *= qaliq;

            //}
            //int r7 = r6 - sum4;
            //int r8 = r7 * 6 / 10;
            //int r9 = (r8 * 100) + 60;
            //float r10 = r9 * 18 / 100;
            //float r11 = r9 - r10;
            //Console.WriteLine($"Netice :{r11}");
        }


    }
}

        
   
