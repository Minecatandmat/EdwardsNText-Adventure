namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Choice = 0;
            //string Eggs = null;
            //if (Eggs == "BillyBob")
            //{
            //    billybob();
            //}
            //if (Eggs == "SixtyNine")
            //{
            //    Console.WriteLine("The year of the first Woodstock festival.");
            //}
            //if (Eggs == "NinerNiner")
            //{
            //    Console.WriteLine("Woodstock 99 was fun... If you were a drunkard junkie. Look it up");
            //}
            //if (Eggs == "Hundred")
            //{
            //    Console.WriteLine("Whose line is it anyways? Line 18? Ok.");
            //}
            Console.WriteLine("You are a prisonor within a unknown facility belonging to a 'SCP Foundation'. All you know about them is that they contain dangerous paranormal objects and test them on people like you, Death row inmates or violent prisoners. What you were charged with and if it was correct is irrelevent. What is relevent is when the power goes out and the guards leave in a panic, your door is unlocked. As you step out, you see to the left is a door marked STORAGE and to the right is a door marked MEDICAL. Where do you go?");
            Console.WriteLine("[1: Go through STORAGE] [2: Go through MEDICAL]");
            Choice = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
            if (Choice == 1)
            {
                Console.WriteLine("The black concrete and grated metal floors filled with wires and pipes are forboding, as are the large metal crate that turn the room into a maze. You manage to come across a squad of soldiers who look different than any of the insurgency you have seen. Before you can sneak away, they spot you and make an offer: You can join their orginization, the Chaos Insurgency and help destroy the SCP Foundation.");
                Console.WriteLine("[3: Join them] [4: Refuse]");
                Choice = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                if (Choice == 3)
                {
                    Console.WriteLine("They hand you a pistol and give you the game plan. Blow up the reactor core like they do in half the episodes of Star Wars and then run away. Seems like a good plan. As you and the insurgents go through the Mantinence Sector, a few bullets fly but for the most part it is rather easy to avoid any real resistance. You arrive at the reactor core, A massive room that is a kilometer high, wide, and deep. You plant the charges and are now setting the timer.");
                    Console.WriteLine("[7: Set it for 0 seconds] [8: Set it for 10 Minutes]");
                    Choice = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                    if (Choice == 7)
                    {
                        Console.WriteLine("The bombs go of instantly and you die. Idiot. GAME OVER.");
                        //Most of these deaths are easily avoidable but I know some people are that stupid.
                    }
                    else if (Choice == 8)
                    {
                        Console.WriteLine("You manage to set the bombs for long enought to where you and your new... er... coworkers can manage to escape to the choppa and as you look back, the explosion goes a mile wide and the cloud even higher. THE END");
                    }
                }
                else if (Choice == 4)
                {
                    Console.WriteLine("They shoot you and you die. No survivores or witnesses you guess. GAME OVER.");
                }
                else if (Choice == 2)
                {
                    Console.WriteLine("The white halls filled with bloodied corpses of medical staff and security are disturbing, but more disturbing is a lack of bullet holes. A strange figure is at the end of the hall, looking like a plague doctor from ye olden times. As he stares down your sole with human yet inhuman eyes, he begins to march towards you, each step like a bomb dropping and each breath like an iron lung. He says he can cure you. Of what? Can you trust him?");
                    Console.WriteLine("[5: Trust it] [6: RUN]");
                    Choice = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                    if (Choice == 5)
                    {
                        Console.WriteLine("As soon as the doctor touches you, all you can see is the pearly gates with Saint Peter looking at you, sighing, and shaking his head. GAME OVER.");
                    }else if (Choice == 6)
                    {
                        Console.WriteLine("As you run, you manage to sneak into the Civil Sector. Inside is a bunch of security guards.");
                        Console.WriteLine("[9: Say hi to them.] [10: Sneak past");
                        Choice = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                        if (Choice == 9)
                        {
                            Console.WriteLine("They shoot you. What did you think would happen? You know, people like you are the reason that they have do not enter the exhibit signs at zoos. GAME OVER.");
                        }else if(Choice == 10)
                        {
                            Console.WriteLine("You manage to sneak past them and make your way to the main gate. As you open it to enjoy your freedom, you see it will be a hike to the nearest town. THE END.");
                        }
                    }
                }
            }
        }

        static void billybob()
        {
            Console.WriteLine("Cotton eye joe.");
        }
    }
}
//I know what a functions is, I am just not rewriting this entire damn game's code.