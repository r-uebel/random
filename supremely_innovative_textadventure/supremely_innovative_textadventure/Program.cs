using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace supremely_innovative_textadventure
{
    class Program
    {
        // battle things
        public static void battle()
        {
            // player
            int player_hp = 100;
            int player_str = 10;
            int player_def = 10;
            // player ende

            // guard
            int guard_hp = 100;
            int guard_str = 10;
            int guard_def = 10;
            // guard ende

            while (player_hp > 0 || guard_hp > 0) // literally a death match ayyy
            {

                if(player_hp <= 0 || guard_hp <= 0)
                {
                    if(player_hp <= 0 && guard_hp > 0)
                    {
                        Console.WriteLine("Die Wache gewinnt! Du bist tot!");
                    }
                    else if(guard_hp <= 0 && player_hp > 0)
                    {
                        Console.WriteLine("Du gewinnst!");
                    }

                    break;
                }
                Console.WriteLine("");
                Console.WriteLine("-----");
                Console.WriteLine("---------------");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Player HP: " + player_hp + "   Enemy HP: " + guard_hp);
                Console.WriteLine("1. Angriff");
                Console.WriteLine("2. Verteidigen");
                Console.WriteLine("3. Warten");
                Console.WriteLine("-------------------------");
                Console.WriteLine("---------------");
                Console.WriteLine("-----");
                Console.WriteLine("");
                string battle_action = Console.ReadLine();

                if (battle_action != "1" && battle_action != "2" && battle_action != "3")
                {
                    battle_action = "3";
                }

                // player
                bool another_loop_thing = true;
                while ((battle_action == "1" || battle_action == "2" || battle_action == "3") && another_loop_thing == true)
                {


                        another_loop_thing = false;

                        if (battle_action == "1")
                        {
                            Console.WriteLine("Du greifst an!");
                            guard_hp -= player_str;
                        }
                        else if (battle_action == "2")
                        {
                            Console.WriteLine("Du verteidigst!");
                            player_hp += player_def;
                        }
                        else if (battle_action == "3")
                        {
                            Console.WriteLine("Nichts passiert!");
                        }
                        else
                        {
                            battle_action = "3";
                        }

                        
                    
                }
                // player ende

                // enemy
                if (guard_hp > 0)
                {
                    Random rnd = new Random();
                    int enemy_action_rnd = rnd.Next(1, 11);

                    if (enemy_action_rnd > 0 && enemy_action_rnd <= 4)
                    {
                        Console.WriteLine("Die Wache greift an!");
                        player_hp -= guard_str;
                    }
                    else if (enemy_action_rnd > 4 && enemy_action_rnd < 8)
                    {
                        Console.WriteLine("Die Wache verteidigt!");
                        guard_hp += guard_def;
                    }
                    else if (enemy_action_rnd >= 8)
                    {
                        Console.WriteLine("Die Wache wartet!");
                    }
                    else
                    {
                        Console.WriteLine("Die Wache wartet!");
                    }
                }
                // enemy ende
            }
        }
        // battle things ende


        // who needs libraries
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        public static void output_n_sleep(string output, int sleep)
        {
            Console.WriteLine(output);
            System.Threading.Thread.Sleep(sleep);
        }

        public static string action_choice(string ch1 = "", string ch2 = "", string ch3 = "", string ch4 = "", string ch5 = "")
        {
            Console.WriteLine("");
            output_n_sleep("----- Was wirst du tun? -----", 0);

            int how_many_choices = 0;
            if (ch1 != "")
            {
                how_many_choices++;
            }
            if (ch2 != "")
            {
                how_many_choices++;
            }
            if (ch3 != "")
            {
                how_many_choices++;
            }
            if (ch4 != "")
            {
                how_many_choices++;
            }
            if (ch5 != "")
            {
                how_many_choices++;
            }

            Console.WriteLine("-------------------------");
            for (int i = 0; i < how_many_choices; i++)
            {
                if (i == 0)
                    Console.WriteLine(i + 1 + ": " + ch1);
                if (i == 1)
                    Console.WriteLine(i + 1 + ": " + ch2);
                if (i == 2)
                    Console.WriteLine(i + 1 + ": " + ch3);
                if (i == 3)
                    Console.WriteLine(i + 1 + ": " + ch4);
                if (i == 4)
                    Console.WriteLine(i + 1 + ": " + ch5);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("");

            string choice_string = Console.ReadLine();
            if (choice_string != "1" && choice_string != "2" && choice_string != "3" && choice_string != "4" && choice_string != "5")
            {
                choice_string = "0";
            }

            if (!IsDigitsOnly(choice_string))
            {
                choice_string = "0";
            }
            int running_out_of_names_meh = Convert.ToInt16(choice_string);
            if (running_out_of_names_meh > how_many_choices)
            {
                choice_string = "0";
            }

            return choice_string;
        }
        // I don't

        static void Main(string[] args)
        {
            // ohayoooooooou
            output_n_sleep("Du wachst in einem dunklen Raum auf.", 1000);
            output_n_sleep("Du bist alleine.", 1000);
            output_n_sleep("Vor dir siehst du eine Tür.", 1000);
            output_n_sleep("Sie ist offen...", 1000);

            bool loop_thing = true;
            while (loop_thing == true)
            {
                loop_thing = false;

                string player_choice = "0";
                while (player_choice == "0")
                {
                    player_choice = action_choice("Gehe durch die Tür", "Bleibe im Raum", "Kosmische Todesstrahlen");
                }

                switch (player_choice)
                {
                    case "1":
                        {
                            // Hier gehts weiter
                            output_n_sleep("Du betrittst einen Gang", 1000);
                            output_n_sleep("Am Ende dieses Gangs siehst du eine einzelne Tür", 1000);
                            output_n_sleep("Du gehst zur Tür", 1000);

                            player_choice = "0";
                            while (player_choice == "0")
                            {
                                player_choice = action_choice("Öffne die Tür", "Öffne die Tür", "Öffne die Tür", "Öffne die Tür", "stirb");
                            }

                            switch (player_choice)
                            {
                                case "1":
                                case "2":
                                case "3":
                                case "4":
                                    {
                                        // Hier gehts weiter
                                        output_n_sleep("Du betrittst einen weiteren Raum", 1000);
                                        output_n_sleep("Eine Wache greift dich an! *Kampfmusik intensifies*", 1000);
                                        output_n_sleep("Kampf beginnt!", 1000);
                                        // insert kampf here
                                        battle();

                                    }
                                    break;
                                case "5":
                                    {
                                        output_n_sleep("Du stirbst", 1000);
                                    }
                                    break;
                                default:
                                    {
                                        output_n_sleep("Gute Arbeit, du hast es kaputt gemacht", 3000);
                                        output_n_sleep("Du Monster", 3000);
                                    }
                                    break;
                            }
                        }
                        break;
                    case "2":
                        {
                            while (player_choice == "2")
                            {
                                output_n_sleep("Nichts passiert", 2000);
                                player_choice = "0";
                                loop_thing = true;
                                continue;
                            }
                        }
                        break;
                    case "3":
                        {
                            output_n_sleep("Du stirbst", 1000);
                        }
                        break;
                    default:
                        {
                            output_n_sleep("Gute Arbeit, du hast es kaputt gemacht", 3000);
                            output_n_sleep("Du Monster", 3000);
                        }
                        break;
                } // switch player_choice ende

            } // 1st loop ende

            Console.ReadKey();

        } // main end

    } // class: Program end

} // namespace end
