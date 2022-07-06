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
            int playerAmountAbilities = 4;
            
            int playerArmor = 0;
            int playerArmorAdd = 10;

            bool playerRamashone = false;
            int ramashanAmountAttacksStart = 3;
            int ramashanAmountAttacks = 3;
            int ramashanCostHealthCall = 20;
            int ramashanDamage = 10;

            bool playerDimensionalRift = false;
            int playerHealChance = 20;
            int playerHealMin = 5;
            int playerHealMax = 40;

            Console.WriteLine("BOSS FIGTH!!!");
            while (bossHealth > 0 && playerHealth > 0)
            {
                Console.WriteLine($"Boss health: {bossHealth}");

                if (bossArmor > 0)
                {
                    Console.WriteLine($"Boss armor: {bossArmor}");
                }
                else
                {
                    bossArmor = 0;
                }

                Console.WriteLine($"Player health: {playerHealth}");

                if (playerArmor > 0)
                {
                    Console.WriteLine($"Player armor: {playerArmor}");
                }
                else
                {
                    playerArmor = 0;
                }

                if (playerRamashone && ramashanAmountAttacks > 0)
                {
                    Console.WriteLine("Player has Ramashone.");
                }
                if (playerDimensionalRift)
                {
                    Console.WriteLine("Player rest in Dimensional rift.");
                }

                Console.WriteLine("\nBoss turn:");
                int bossTurn = random.Next(1, bossAmountAbilities + 1);
                switch (bossTurn)
                {
                    case 1:
                        {
                            if (playerDimensionalRift)
                            {
                                Console.WriteLine("Boss can not reach you.");
                                break;
                            }

                            int damage = bossDamage - playerArmor;
                            if (damage > 0)
                            {
                                playerArmor -= bossDamage;
                                playerHealth -= damage;
                                Console.WriteLine($"Boss attacks. Deals {damage} damage.");
                                break;
                            }
                            playerArmor -= bossDamage;
                            Console.WriteLine($"Player Armor absorbs all {bossDamage} damage.");
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

                if (playerHealth <= 0)
                {
                    break;
                }

                int playerChoisee;
                int playerChoiseeTries = 3;
                playerDimensionalRift = false;
                do
                {
                    Console.WriteLine("Abilities: \n" +
                        $"1. Summon Ramashone, shadow spirit. Cost {ramashanCostHealthCall} HP. {ramashanAmountAttacks} attaсks before wanish.\n" + 
                        $"2. Haganzakura. Ramashone deal {ramashanDamage}.\n" + 
                        $"3. Dimensional rift. Awoid attack and have {playerHealChance}% to heal {playerHealMin} - {playerHealMax} HP.\n" + 
                        $"4. Stone armor. Add {playerArmor} armor.\n");
                    Console.Write($"Attention you have {playerChoiseeTries} mistakes to lose your turn. Choose wisely: ");

                    if(Int32.TryParse(Console.ReadLine(), out playerChoisee) == false || playerChoisee > playerAmountAbilities || playerChoisee <= 0)
                    {
                        --playerChoiseeTries;
                        Console.WriteLine("Mistake, try again.");
                    }
                    else
                    {
                        playerChoiseeTries = 0;
                    }
                    
                } while (playerChoiseeTries > 0);
                
                switch (playerChoisee)
                {
                    case 1:
                        {
                            playerRamashone = true;
                            ramashanAmountAttacks = ramashanAmountAttacksStart;
                            if(playerHealth < ramashanCostHealthCall)
                            {
                                Console.WriteLine("You have no helth for Ramashone... Summon failed.");
                                break;
                            }
                            playerHealth -= ramashanCostHealthCall;
                            Console.WriteLine("You summon Ramashone!!!");
                            break;
                        }
                        
                        case 2:
                        {
                            if (playerDimensionalRift && ramashanAmountAttacks > 0)
                            {
                                --ramashanAmountAttacks;
                                Console.WriteLine("Your are too far from your spirit. It hears you, but can not undestand order.  " +
                                    $"Left {ramashanAmountAttacks} of Ramashan attacks.");
                            }
                            else if (playerRamashone == false || ramashanAmountAttacks == 0)
                            {
                                playerRamashone = false;
                                Console.WriteLine("You have no summoned spirit... Be patient!!!");
                            }

                            int damage = ramashanDamage - bossArmor;
                            if (damage > 0)
                            {
                                bossArmor -= ramashanDamage;
                                bossHealth -= damage;
                                ramashanAmountAttacks--;
                                Console.WriteLine($"Ramashan attacks. Deals {damage} damage. Left {ramashanAmountAttacks} of Ramashan attacks.");
                                break;
                            }
                            bossArmor -= ramashanDamage;
                            ramashanAmountAttacks--;
                            Console.WriteLine($"Boss Armor absorbs all {ramashanDamage} damage. Left {ramashanAmountAttacks} of Ramashan attacks.");
                            break;
                        }
                        
                        case 3:
                        {
                            playerDimensionalRift = true;
                            Console.WriteLine("You step aside and found yourself in Dimenshion Rift. No one can get to you. Dimenshion Rift garble orders.");

                            int chance = random.Next(1, 100);
                            if (chance <= 20)
                            {
                                int heal = random.Next(playerHealMin, playerHealMax);
                                playerHealth += heal;
                                Console.WriteLine($"Heal success. You heal {heal} HP.");
                                break;
                            }

                            Console.WriteLine("Heal failed.");
                            break;
                        }
                        
                        case 4:
                        {
                            playerArmor += playerArmorAdd;
                            Console.WriteLine($"You add {playerArmorAdd} armor.");
                            break;
                        }
                }
                Console.WriteLine();
            }

            if(playerHealth > 0)
            {
                Console.WriteLine("Congratulation!!! You win!!!");
            }
            else
            {
                Console.WriteLine("Boss wins... Good luck next time :-)");
            }
        }
    }
}
