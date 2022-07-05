using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int bossHealth = 100;
            int bossArmor = 10;
            int bassArmorIncreaseMax = 10;
            int bossDamage = 10;
            int bossHeal = 10;
            int bossAmountAbilities = 3;

            int playerHealth = 100;
            int playerArmor = 0;
            bool playerRamashone = false;
            int playerHealChance = 20;
            int playerHealMin = 5;
            int playerHealMax = 40;

            Console.WriteLine("BOSS FIGTH!!!");
            while (bossHealth > 0 && playerHealth > 0)
            {
                Console.WriteLine($"Boss health: {bossHealth}");

                if (bossArmor > 0)
                    Console.WriteLine($"Boss armor: {bossArmor}");
                else
                    bossArmor = 0;

                Console.WriteLine($"Player health: {playerHealth}");

                if (playerArmor > 0)
                    Console.WriteLine($"Player armor: {playerArmor}");
                else
                    playerArmor = 0;

                if (playerRamashone)
                    Console.WriteLine("Player has Ramashone.");

                Console.WriteLine("\nBoss turn:");
                int bossTurn = random.Next(1, bossAmountAbilities + 1);
                switch (bossTurn)
                {
                    case 1:
                        {
                            int damage = bossDamage - playerArmor;
                            if (damage > 0)
                            {
                                playerArmor -= bossDamage;
                                playerHealth -= damage;
                                Console.WriteLine($"Boss attack. Deals {damage} damage.");
                                break;
                            }
                            Console.WriteLine("Player Armor absorbs all damage.");
                            break;
                        }

                    case 2:
                        {
                            int heal = random.Next(bossHeal + 1);
                            bossHealth += heal;
                            Console.WriteLine($"Boss heals {heal} HP.");
                            break;
                        }

                    case 3:
                        {
                            int addArmor = random.Next(bassArmorIncreaseMax + 1);
                            bossArmor += addArmor;
                            Console.WriteLine($"Boss adds {addArmor} armor.");
                            break;
                        }
                }
                Console.WriteLine();

                //player turn
            }

            if(playerHealth > 0)
                Console.WriteLine("Congratulation!!! You win!!!");
            else
                Console.WriteLine("Boss wins... Good luck next time :-)");
        }
    }
}
