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

            double userEnteredSum = 0;

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

                Int32.TryParse(Console.ReadLine(), out menuItem);

                switch (menuItem)
                {
                    case 1:
                        {
                            Console.Write("How much USD to convert: ");
                            userEnteredSum = Int32.Parse(Console.ReadLine());

                            if (userEnteredSum > 0 & userEnteredSum > walletUSD)
                            {
                                Console.WriteLine($"You do not have {userEnteredSum} USD in your wallet.");
                                break;
                            }

                            walletUSD -= userEnteredSum;
                            walletRUS += userEnteredSum * USDtoRUS;
                            break;
                        }
                    case 2:
                        {
                            Console.Write("How much USD to convert: ");
                            userEnteredSum = Int32.Parse(Console.ReadLine());

                            if (userEnteredSum > 0 & userEnteredSum > walletUSD)
                            {
                                Console.WriteLine($"You do not have {userEnteredSum} USD in your wallet.");
                                break;
                            }

                            walletUSD -= userEnteredSum;
                            walletEUR += userEnteredSum * USDtoEUR;
                            break;
                        }
                    case 3:
                        {
                            Console.Write("How much EUR to convert: ");
                            userEnteredSum = Int32.Parse(Console.ReadLine());

                            if (userEnteredSum > 0 & userEnteredSum > walletEUR)
                            {
                                Console.WriteLine($"You do not have {userEnteredSum} EUR in your wallet.");
                                break;
                            }

                            walletEUR -= userEnteredSum;
                            walletRUS += userEnteredSum * EURtoRUS;
                            break;
                        }
                    case 4:
                        {
                            Console.Write("How much EUR to convert: ");
                            userEnteredSum = Int32.Parse(Console.ReadLine());

                            if (userEnteredSum > 0 & userEnteredSum > walletEUR)
                            {
                                Console.WriteLine($"You do not have {userEnteredSum} EUR in your wallet.");
                                break;
                            }

                            walletEUR -= userEnteredSum;
                            walletUSD += userEnteredSum * EURtoUSD;
                            break;
                        }
                    case 5:
                        {
                            Console.Write("How much RUS to convert: ");
                            userEnteredSum = Int32.Parse(Console.ReadLine());

                            if (userEnteredSum > 0 & userEnteredSum > walletRUS)
                            {
                                Console.WriteLine($"You do not have {userEnteredSum} RUS in your wallet.");
                                break;
                            }

                            walletRUS -= userEnteredSum;
                            walletUSD += userEnteredSum * RUStoUSD;
                            break;
                        }
                    case 6:
                        {
                            Console.Write("How much RUS to convert: ");
                            userEnteredSum = Int32.Parse(Console.ReadLine());

                            if (userEnteredSum > 0 & userEnteredSum > walletRUS)
                            {
                                Console.WriteLine($"You do not have {userEnteredSum} RUS in your wallet.");
                                break;
                            }

                            walletRUS -= userEnteredSum;
                            walletEUR += userEnteredSum * RUStoEUR;
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
    }
}
