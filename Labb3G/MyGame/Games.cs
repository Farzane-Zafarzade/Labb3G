namespace Labb3G.MyGame
{
    using Labb3G.Monsters;
    using Labb3G.Players;
    using System;
    using System.Collections.Generic;

    internal class Games
    {
        private bool lostGame, wonGame;

        private IPlayer CurrentPlayer = new Player();

        // starts game and shows wellcome message
        public void startGame() 
        {
            Console.WriteLine("************************");
            Console.WriteLine("* Welcome to The Game! *");
            Console.WriteLine("************************");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            CurrentPlayer.name = name;
            Console.Clear();
            Console.WriteLine($"\n** Hi {CurrentPlayer.GetName()}, Select an option : **");


            int input = -1;
            while (!wonGame && !lostGame)
            {
                Console.Clear();
                printMainMenu(); // shows menu 
                Console.Write("> ");
                input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (input) // shows selected option
                {
                    case 1:
                        goAdventure();
                        break;
                    case 2:
                        goCharacter(CurrentPlayer);
                        break;
                    case 3:
                        Console.WriteLine("Bye!");
                        lostGame = true;
                        break;
                }
            }
        }

        // Prints all menu options
        private void printMainMenu() 
        {
            Console.WriteLine("\n.......................................");
            Console.WriteLine("1. Go adventuring");
            Console.WriteLine("2. Show details about your character");
            Console.WriteLine("3. Exit game");
        }

        //First menu option - fighting monsters
        private void goAdventure() 
        {
            Console.WriteLine("\n Your adventure starts here, get ready to attack...\n\n");
            Console.ReadKey();
            int chanse = MyRandomHelper.RandomHelper.RandomNumber(1, 100);
            if (chanse < 10) //With a probability of less than 10%, nothing will be displayed
            {

                Console.WriteLine(" You see nothing but swaying grass all around you... \n [Press enter to continue]");
                Console.ReadLine();
            }
            else //battle with random monster
            {
                IMonster myMonster = PickUpMonster();
                Battle(myMonster);
            }
        }

        //Initiates a battle between the player and the given monster
        private void Battle(IMonster monster) 
        {
            Console.WriteLine($" Uh oh! A {monster.GetName()} appeared!");
            while (!monster.IsDead() && !CurrentPlayer.IsDead())
            {
                Console.WriteLine();
                int dmg = CurrentPlayer.Attack();
                monster.TakeDamage(dmg);
                Console.WriteLine($"You hit the monster, dealing {dmg} damage\n");

                if (monster.IsDead()) // Player's level ups if monster dies
                {
                    Console.WriteLine($"** You killed the monster, gaining {CurrentPlayer.GainExp(monster.GetExp())} experience! **");
                    CurrentPlayer.LevelUp();
                    Console.WriteLine($"           ****You leveled up!!!****\n");
                    Console.WriteLine($"You are level {CurrentPlayer.GetLevel()} and, you have {CurrentPlayer.GetExp()} experience, and {CurrentPlayer.GetHp()} hp ");
                    Console.WriteLine("=====================================================\n");
                    Console.WriteLine(" [ Press enter to go to the next level...]");
                    Console.ReadKey();

                    if (CurrentPlayer.GetLevel() == 10) // Player wins the game if level is 10
                    {
                        wonGame = true;
                        Console.WriteLine("\n              **************");
                        Console.WriteLine("          **********************");
                        Console.WriteLine("      ******************************");
                        Console.WriteLine("   Congratulations!!! You Won The Game!!!");
                        Console.WriteLine("      ******************************");
                        Console.WriteLine("          **********************");
                        Console.WriteLine("              **************");
                    }
                    return;
                }
                Console.ReadKey();

                dmg = monster.Attack();
                CurrentPlayer.TakeDamage(dmg);
                Console.WriteLine($"The monster hit you, dealing {dmg} damage\n");
                Console.WriteLine($"{CurrentPlayer.GetName()} : {CurrentPlayer.GetHp()} hp"); // Displays player's details
                if (CurrentPlayer.IsDead()) // If player dies game will over
                {
                    Console.WriteLine("You were killed by The monster :( ");
                    Console.WriteLine("****** GAME OVER ******");
                    lostGame = true;
                    return;
                }


                Console.WriteLine($"{monster.GetName()} : {monster.GetHp()} hp"); // Displays monster's details
                Console.WriteLine("==========================================\n");
                Console.WriteLine(" [Press enter to continue...] ");
                Console.ReadKey();




            }
        }

        //Second menu option - show details about character
        private void goCharacter(IPlayer player) 
        {
            player.PrintInfo();
            Console.WriteLine(" Press enter to back to menu: \n");
            Console.ReadKey();
            Console.Clear();
        }

        //Creates a list of monsters and selects a random monster to battle
        internal IMonster PickUpMonster() 
        {
            List<IMonster> listOfMonsters = new List<IMonster>();
            DarkDragon DarkDgn = new DarkDragon();
            FireDragon FireDgn = new FireDragon();
            IceDragon IceDgn = new IceDragon();
            listOfMonsters.Add(DarkDgn);
            listOfMonsters.Add(FireDgn);
            listOfMonsters.Add(IceDgn);
            int selectedDragon = MyRandomHelper.RandomHelper.RandomNumber(0, 2);
            return listOfMonsters[selectedDragon];
        }
    }
}
