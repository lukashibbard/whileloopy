/*
string decis = "";
bool death = true;
while (true)

{
    Console.WriteLine("you entered the castle of the king,");
    Console.WriteLine("the castle is full of dragons continue if you dare but if you find the crown you will become the lord of the land");
    Console.WriteLine("would you like to journy into the castle yes or no");
    Console.WriteLine("Enter here:");
    decis = Console.ReadLine() + "";
    if (decis == "yes")
    {
        bool doorloop = (true);
        while (doorloop == true)
        {
            Console.WriteLine("you enter the the door of your choice and enter a room with three doors this door was safe but there is no crown in front of you but your not dead so you must continue");
            Random drandom = new Random();
            int ddoor = drandom.Next(1, 4);
            Random krandom = new Random();
            int kdoor = krandom.Next(1, 4);
            Random nrandom = new Random();
            int ndoor = nrandom.Next(1, 4);
            while (ddoor == kdoor)
            {
                kdoor = krandom.Next(1, 4);
            }
            while (ndoor == kdoor || ndoor == ddoor)
            {
                ndoor = krandom.Next(1, 4);
            }
            bool decdoor = true;
            while (decdoor == true)
            {
                Console.WriteLine("which door do you choose");
                Console.WriteLine("1)door number 1");
                Console.WriteLine("2)door number 2");
                Console.WriteLine("3)door number 3");
                Console.WriteLine("Enter here:");
                string door_choice = Console.ReadLine() + "";
                switch (door_choice)
                {
                    case "1":
                        Console.WriteLine("are you sure you want door number one? 1)yes 2)no");
                        Console.WriteLine("Enter here:");
                        string door_choice1 = Console.ReadLine() + "";
                        switch (door_choice1)
                        {
                            case "1":
                            {
                                switch (ndoor)
                                {
                                    case 1:
                                        decdoor = false;
                                        break;
                                }
                                switch (kdoor)
                                {
                                    case 1:
                                        Console.WriteLine("you found the crown you are now the king");
                                        bool win = true;
                                        break;
                                }
                                switch (ddoor)
                                {
                                    case 1:
                                        Console.WriteLine("you walk into the room expecting the great reward but the only reward for you was death");
                                        death = true;
                                        break;
                                        break;
                                }
                            }
                            case "2":
                            {
                                break;
                            }
                                break;
                    case "2":
                        Console.WriteLine("are you sure you want door number two? 1)yes 2)no");
                        Console.WriteLine("Enter here:");
                        string door_choice2 = Console.ReadLine() + "";
                        switch (door_choice1)
                                        {
                        case "1":
                            switch (ndoor)
                            {
                                case 2:
                                    decdoor = false;
                                    break;
                            }
                            switch (kdoor)
                            {
                                case 2:
                                    Console.WriteLine("you found the crown you are now the king");
                                    bool win = true;
                                    break;
                            }
                            switch (ddoor)
                            {
                                case 2:
                                    Console.WriteLine("you walk into the room expecting the great reward but the only reward for you was death");
                                    death = true;
                                    break;
                                    break;
                            }
                                    case "2":

                                        break;
                                    }
                                        break;
                    case "3":
                        Console.WriteLine("are you sure you want door number three? 1)yes 2)no");
                        Console.WriteLine("Enter here:");
                        string door_choice3 = Console.ReadLine() + "";
                        switch (door_choice1)
                        {
                            case "1":
                            switch (ndoor)
                            {
                                case 3:
                                    decdoor = false;
                                    break;
                            }
                            switch (kdoor)
                            {
                                case 3:
                                    Console.WriteLine("you found the crown you are now the king");
                                    bool win = true;
                                    break;
                            }
                            switch (ddoor)
                            {
                                case 3:
                                    Console.WriteLine("you walk into the room expecting the great reward but the only reward for you was death");
                                    death = true;
                                    break;
                                    break;
                            }
                            
                                    case "2":

                                        break;
                                    }
                                        break;

                                        }
                                                        break;
                                                    }

                                            }
                                        }
    if (decis == "no")
    {
        break;
    }
}
if (decis == "no")
{
    Console.WriteLine("you decided to not enter you loser");
}
*/