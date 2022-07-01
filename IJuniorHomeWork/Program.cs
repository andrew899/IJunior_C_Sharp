using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            double walletUSD = 1000;
            double walletEUR = 1000;
            double walletRUS = 1000;

            const double USDtoEUR = 0.9d;
            const double USDtoRUS = 53.1d;
            const double EURtoUSD = 1.05d;
            const double EURtoRUS = 56.28d;
            const double RUStoUSD = 0.019d;
            const double RUStoEUR = 0.018d;



            double sumToConvert = 0;

            bool exit = false;
            while (!exit)
            {
                int menuItem = 0;

                Console.WriteLine($"Your balance: \n USD : {walletUSD} \n EUR : {walletEUR} \n RUS : {walletRUS}");
                Console.WriteLine("1. Conwert USD to RUS.");
                Console.WriteLine("2. Conwert USD to EUR.");
                Console.WriteLine("3. Conwert EUR to RUS.");
                Console.WriteLine("4. Conwert EUR to USD.");
                Console.WriteLine("5. Conwert RUS to USD.");
                Console.WriteLine("6. Conwert RUS to EUR.");
                Console.WriteLine("7. Exit \n");

                menuItem = Int32.Parse(Console.ReadLine());

                switch (menuItem)
                {
                    case 1:
                        {
                            Console.Write("How much USD to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());

                            if (SumCheck(walletUSD, sumToConvert))
                            {
                                Console.WriteLine($"You do not have {sumToConvert} USD in your wallet.");
                                break;
                            }

                            walletUSD -= sumToConvert;
                            walletRUS += sumToConvert * USDtoRUS;
                            break;
                        }
                    case 2:
                        {
                            Console.Write("How much USD to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());

                            if (SumCheck(walletUSD, sumToConvert))
                            {
                                Console.WriteLine($"You do not have {sumToConvert} USD in your wallet.");
                                break;
                            }

                            walletUSD -= sumToConvert;
                            walletEUR += sumToConvert * USDtoEUR;
                            break;
                        }
                    case 3:
                        {
                            Console.Write("How much EUR to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());

                            if (SumCheck(walletEUR, sumToConvert))
                            {
                                Console.WriteLine($"You do not have {sumToConvert} EUR in your wallet.");
                                break;
                            }

                            walletEUR -= sumToConvert;
                            walletRUS += sumToConvert * EURtoRUS;
                            break;
                        }
                    case 4:
                        {
                            Console.Write("How much EUR to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());

                            if (SumCheck(walletEUR, sumToConvert))
                            {
                                Console.WriteLine($"You do not have {sumToConvert} EUR in your wallet.");
                                break;
                            }

                            walletEUR -= sumToConvert;
                            walletUSD += sumToConvert * EURtoUSD;
                            break;
                        }
                    case 5:
                        {
                            Console.Write("How much RUS to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());

                            if (SumCheck(walletRUS, sumToConvert))
                            {
                                Console.WriteLine($"You do not have {sumToConvert} RUS in your wallet.");
                                break;
                            }

                            walletRUS -= sumToConvert;
                            walletUSD += sumToConvert * RUStoUSD;
                            break;
                        }
                    case 6:
                        {
                            Console.Write("How much RUS to convert: ");
                            sumToConvert = Int32.Parse(Console.ReadLine());

                            if (SumCheck(walletRUS, sumToConvert))
                            {
                                Console.WriteLine($"You do not have {sumToConvert} RUS in your wallet.");
                                break;
                            }

                            walletRUS -= sumToConvert;
                            walletEUR += sumToConvert * RUStoEUR;
                            break;
                        }
                    case 7:
                        {
                            exit = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong input. Try againe.");
                            break;
                        }

                }
            }
        }

        static bool SumCheck(double walletSum, double SumToCovert)
        {
            return SumToCovert > 0 & SumToCovert > walletSum;
        }

    }
}
