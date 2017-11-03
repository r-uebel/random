using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;



namespace supremely_innovative_textadventure
{
    class Program
    {
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
            // ohayoooooooou
            output_n_sleep("----- Was wirst du tun? -----", 0);

            int how_many_choices = 0;
            if(ch1 != "")
            {
                how_many_choices++;
            }
            if(ch2 != "")
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
            for(int i = 0; i < how_many_choices; i++)
            {
                if (i == 0)
                    Console.WriteLine(i+1 + ": " + ch1);
                if (i == 1)
                    Console.WriteLine(i+1 + ": " + ch2);
                if (i == 2)
                    Console.WriteLine(i+1 + ": " + ch3);
                if (i == 3)
                    Console.WriteLine(i+1 + ": " + ch4);
                if (i == 4)
                    Console.WriteLine(i+1 + ": " + ch5);
            }
            Console.WriteLine("-------------------------");

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

        static void Main(string[] args)
        {
            output_n_sleep("Du wachst in einem dunklen Raum auf.", 1000);
            output_n_sleep("Du bist alleine.", 1000);
            output_n_sleep("Vor dir siehst du eine Tür.", 1000);
            output_n_sleep("Sie ist offen...", 1000);
            
            string player_choice = "0";
            while (player_choice == "0")
            {
                player_choice = action_choice("do thing 1", "do thing 2", "do thing 3", "", "");
            }

            Console.WriteLine(player_choice);
        } // main end

    } // class: Program end

} // namespace end
