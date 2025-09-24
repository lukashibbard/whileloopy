using System.Collections;
// the code starts by while true so the game can loop
string decis = "";
while (true)

{
    Console.WriteLine("you entered the castle of the king,");
    // line 7-14 asks if they would like to start the game and if they do they enter 
    Console.WriteLine("the castle is full of dragons continue if you dare but if you find the crown you will become the lord of the land");
    Console.WriteLine("would you like to journy into the castle yes or no");
    Console.WriteLine("Enter here:");
    decis = Console.ReadLine() + "";
    if (decis == "yes")
        if (decis == "no")
        {
            break;
        }
    {
        bool doorloop = (true);
        while (doorloop == true)
        {
            Random randomloop = new Random();
            int ldoor = randomloop.Next(1, 4);
            switch (ldoor)
            {
                case 1:
                    Console.WriteLine("you enter the the door of your choice and enter a room with three doors this door was safe but there is no crown in front of you but your not dead so you must continue");
                    break;
                case 2:
                    Console.WriteLine("you enter the room feeling a little shook but you keep walking. you enter a room with three doors that feel nestolgic");
                    break;
                case 3:
                    Console.WriteLine("you walk into a room the three doors in front of you call you");
                    break;
            }

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
            Console.WriteLine("which door do you choose");
            Console.WriteLine("1)door 1");
            Console.WriteLine("2)door 2");
            Console.WriteLine("3)door 3");
            Console.WriteLine("Enter here:");
            string door_choice = Console.ReadLine() + "";
            switch (door_choice)
            {
                case "1":
                    switch (kdoor)
                    {
                        case 1:
                            Console.WriteLine("you walk into the room, you flinch as something falls but it was nothing you walk close to the middle of room and see it, the crown youve been dreaming of, your the king now");
                            doorloop = false;
                            break;
                    }
                    switch (ddoor)
                    {
                        case 1:
                            Console.WriteLine("you walk into the room, excited yet scared, your worst fears come true as your body is quickly put to rest. it found you and it only takes one mistake");
                            doorloop = false;
                            break;
                    }
                    switch (ndoor)
                    {
                        case 1:
                            break;
                    }
                    break;
                case "2":
                    switch (kdoor)
                    {
                        case 2:
                            Console.WriteLine("you walk into the room, you flinch as something falls but it was nothing you walk close to the middle of room and see it, the crown youve been dreaming of, your the king now");
                            doorloop = false;
                            break;
                    }
                    switch (ddoor)
                    {
                        case 2:
                            Console.WriteLine("you walk into the room, excited yet scared, your worst fears come true as your body is quickly put to rest. it found you and it only takes one mistake");
                            doorloop = false;
                            break;
                    }
                    switch (ndoor)
                    {
                        case 2:
                            break;
                    }
                    break;
                case "3":
                    switch (kdoor)
                    {
                        case 3:
                            Console.WriteLine("you walk into the room, you flinch as something falls but it was nothing you walk close to the middle of room and see it, the crown youve been dreaming of, your the king now");
                            doorloop = false;
                            break;
                    }
                    switch (ddoor)
                    {
                        case 3:
                            Console.WriteLine("you walk into the room, excited yet scared, your worst fears come true as your body is quickly put to rest. it found you and it only takes one mistake");
                            doorloop = false;
                            break;
                    }
                    switch (ndoor)
                    {
                        case 3:
                            break;
                    }
                    break;

            }

        }
        break;
    }
}
if (decis == "no")
    {
        Console.WriteLine("you decided to not enter you loser");

    }
