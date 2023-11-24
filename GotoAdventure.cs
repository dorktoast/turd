using System;

class GotoAdventure
{
    private string invalidInputMsg = "Invalid input. Please enter a number.";
    static void Main()
    {
    Start:
        Console.WriteLine("Welcome to the Great Goto Adventure!");
        Console.WriteLine("Choose your path: 1. Forest, 2. Mountain, 3. Lake, 4. Cave, 5. Exit");

        // Choose wisely, adventurer!
        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine(invalidInputMsg);
            goto Start;
        }

        switch (choice)
        {
            case 1:
                goto Forest;
            case 2:
                goto Mountain;
            case 3:
                goto Lake;
            case 4:
                goto Cave;
            case 5:
                goto End;
            default:
                Console.WriteLine("Unknown path. Try again.");
                goto Start;
        }

    Forest:
        Console.WriteLine("You are in a spooky forest. Choose: 1. Go deeper, 2. Go back");
        if (!int.TryParse(Console.ReadLine(), out choice) || choice == 2)
        {
            goto Start;
        }
        else
        {
            goto DeepForest;
        }

    DeepForest:
        Console.WriteLine("You venture deeper into the forest. Choose your path: 1. Mysterious Cave, 2. Ancient Tree, 3. Strange Path, 4. Go back");
        int forestChoice;
        if (!int.TryParse(Console.ReadLine(), out forestChoice))
        {
            Console.WriteLine(invalidInputMsg);
            goto DeepForest;
        }

        switch (forestChoice)
        {
            case 1:
                goto MysteriousCave;
            case 2:
                goto AncientTree;
            case 3:
                goto StrangePath;
            case 4:
                goto Forest;
            default:
                Console.WriteLine("Unknown path. Try again.");
                goto DeepForest;
        }

    MysteriousCave:
        Console.WriteLine("You find a cave with glowing crystals. Touch them? Y/N");
        if (Console.ReadLine().ToUpper() == "Y")
        {
            Console.WriteLine("You gain magical powers but are teleported to a random place!");
            goto RandomTeleport;
        }
        else
        {
            Console.WriteLine("You avoid potential danger and head back.");
            goto DeepForest;
        }

    AncientTree:
        Console.WriteLine("An ancient tree speaks to you, offering wisdom or treasure. Choose: 1. Wisdom, 2. Treasure");
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            goto DeepForest;
        }
        else
        {
            if (choice == 1)
            {
                Console.WriteLine("You gain wisdom and realize you should probably go back.");
                goto Forest;
            }
            else
            {
                Console.WriteLine("You find treasure but it's cursed! You run back.");
                goto Forest;
            }
        }

    StrangePath:
        Console.WriteLine("The path leads to a fairy circle. Enter? Y/N");
        if (Console.ReadLine().ToUpper() == "Y")
        {
            Console.WriteLine("You enter a magical realm! But alas, you are lost forever. Game over.");
            goto End;
        }
        else
        {
            Console.WriteLine("You wisely stay on the known path, returning to the forest.");
            goto DeepForest;
        }

    RandomTeleport:
        Console.WriteLine("You are teleported to a random location! 1. Lake, 2. Mountain, 3. Start");
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            goto RandomTeleport;
        }
        else
        {
            switch (choice)
            {
                case 1:
                    goto Lake;
                case 2:
                    goto Mountain;
                case 3:
                    goto Start;
                default:
                    goto RandomTeleport;
            }
        }


    Mountain:
        Console.WriteLine("You are climbing the treacherous mountain. Choose your path: 1. Rocky Trail, 2. Mysterious Cave, 3. Snowy Peak, 4. Go back");
        int mountainChoice;
        if (!int.TryParse(Console.ReadLine(), out mountainChoice))
        {
            Console.WriteLine(invalidInputMsg);
            goto Mountain;
        }

        switch (mountainChoice)
        {
            case 1:
                goto RockyTrail;
            case 2:
                goto MountainCave;
            case 3:
                goto SnowyPeak;
            case 4:
                goto Start;
            default:
                Console.WriteLine("Unknown path. Try again.");
                goto Mountain;
        }

    RockyTrail:
        Console.WriteLine("The rocky trail is slippery. Continue carefully? Y/N");
        if (Console.ReadLine().ToUpper() == "Y")
        {
            Console.WriteLine("You navigate safely but find nothing. Returning to the mountain base.");
            goto Mountain;
        }
        else
        {
            Console.WriteLine("You wisely decide to turn back.");
            goto Start;
        }

    MountainCave:
        Console.WriteLine("You find a hidden cave with mysterious paintings. Explore further? Y/N");
        if (Console.ReadLine().ToUpper() == "Y")
        {
            Console.WriteLine("You discover ancient artifacts! But you get lost. Teleporting randomly!");
            goto RandomTeleport;
        }
        else
        {
            Console.WriteLine("You leave the cave and return to the mountain path.");
            goto Mountain;
        }

    SnowyPeak:
        Console.WriteLine("You reach the snowy peak. Build a snowman or continue? 1. Snowman, 2. Continue");
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            goto SnowyPeak;
        }
        else
        {
            if (choice == 1)
            {
                Console.WriteLine("You build a snowman, but it comes to life and chases you down the mountain!");
                goto Start;
            }
            else
            {
                goto HighMountain;
            }
        }

    HighMountain:
        Console.WriteLine("You are at the high mountain, facing the dragon. Choose: 1. Negotiate, 2. Fight, 3. Flee");
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine(invalidInputMsg);
            goto HighMountain;
        }
        else
        {
            switch (choice)
            {
                case 1:
                    goto NegotiateWithDragon;
                case 2:
                    goto FightDragon;
                case 3:
                    Console.WriteLine("You flee back down the mountain!");
                    goto Start;
                default:
                    goto HighMountain;
            }
        }

    NegotiateWithDragon:
        Console.WriteLine("The dragon offers you a riddle. Solve it? Y/N");
        if (Console.ReadLine().ToUpper() == "Y")
        {
            Console.WriteLine("You solve the riddle! The dragon grants you a wish. Wish to go: 1. Lake, 2. Forest, 3. Start");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine(invalidInputMsg);
                goto NegotiateWithDragon;
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        goto Lake;
                    case 2:
                        goto Forest;
                    case 3:
                        goto Start;
                    default:
                        goto NegotiateWithDragon;
                }
            }
        }
        else
        {
            Console.WriteLine("The dragon respects your decision and lets you leave. Back to the mountain base.");
            goto Mountain;
        }

    FightDragon:
        Console.WriteLine("You bravely decide to fight the dragon. Choose your weapon: 1. Sword, 2. Magic, 3. Wits");
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine(invalidInputMsg);
            goto FightDragon;
        }
        else
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your sword is no match for the dragon. You're defeated. Game over.");
                    goto End;
                case 2:
                    Console.WriteLine("Your magic spell works! The dragon is defeated, and you find treasure. Returning to start with riches.");
                    goto Start;
                case 3:
                    Console.WriteLine("You outsmart the dragon, but it flies away with the treasure. Returning to the mountain base.");
                    goto Mountain;
                default:
                    goto FightDragon;
            }
        }



    Lake:
        Console.WriteLine("You arrive at a serene lake. Choose: 1. Swim, 2. Fish, 3. Go back");
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine(invalidInputMsg);
            goto Start;
        }
        else
        {
            switch (choice)
            {
                case 1:
                    goto Swim;
                case 2:
                    goto Fish;
                case 3:
                    goto Start;
                default:
                    goto Lake;
            }
        }

    Swim:
        Console.WriteLine("You swim and find a treasure chest! Open it? Y/N");
        if (Console.ReadLine().ToUpper() == "Y")
        {
            Console.WriteLine("You found gold but a sea monster appears! Swim back? Y/N");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                goto Start;
            }
            else
            {
                Console.WriteLine("The sea monster was friendly and gave you more gold! Returning to start.");
                goto Start;
            }
        }
        else
        {
            Console.WriteLine("You missed out on treasure. Returning to start.");
            goto Start;
        }

    Fish:
        Console.WriteLine("You catch a magical talking fish. Release it? Y/N");
        if (Console.ReadLine().ToUpper() == "Y")
        {
            Console.WriteLine("The fish grants you a wish! You wish to return to start.");
            goto Start;
        }
        else
        {
            Console.WriteLine("The fish curses you for greed. Game over.");
            goto End;
        }

    Cave:
        Console.WriteLine("You enter a dark cave. Choose: 1. Explore deeper, 2. Leave cave");
        if (!int.TryParse(Console.ReadLine(), out choice) || choice == 2)
        {
            goto Start;
        }
        else
        {
            goto DeepCave;
        }

    DeepCave:
        Console.WriteLine("You find a sleeping giant! Sneak by? Y/N");
        if (Console.ReadLine().ToUpper() == "Y")
        {
            Console.WriteLine("You successfully sneak by and find an exit! Returning to start.");
            goto Start;
        }
        else
        {
            Console.WriteLine("The giant wakes up and you run back to start!");
            goto Start;
        }

    End:
        Console.WriteLine("Thank you for playing!");
    }
}

//dorktoast
