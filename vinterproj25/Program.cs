


System.Console.WriteLine("Day: 0\n");

Console.WriteLine("\nHi, you must be the new security checker. \nYour duty is to check if people that want to enter my party is actually invited.");
Console.ReadLine();
System.Console.WriteLine("Last time, some bastards just fake their name and the old security checker messed it up. \nSo, I've added more identity specification and I hope this time you won't disappoint me.");
Console.ReadLine();
System.Console.WriteLine("Well, since this is your first day I'll help to teach you how it works.");
System.Console.WriteLine("[Enter] when you're ready");
Console.ReadLine();

Console.Clear();

int PersonInvited = 3;
string Command;
bool IsAsking;
bool HidText = true;
string ans;
while(true)
{
    System.Console.WriteLine("Day: 0\n");
    System.Console.WriteLine($"Person invited: {PersonInvited}");
    
    People guest1 = new People{Name = "Jeff Wilson", Age = 24, DateOfbirth = "19/10/2001"};

    System.Console.WriteLine($"\nHi, I'm looking forwart to your party!");
    Console.ReadLine();
    System.Console.WriteLine("Now you'll need to check this guest information while asking to see if it matches or not.");
    
    while(true)
    {
        if (!HidText)
        {
            System.Console.WriteLine("Day: 0\n");
            System.Console.WriteLine($"Person invited: {PersonInvited}");
        }
        System.Console.WriteLine("\nType [Check] to check information in my invited guest list and [Ask] to open asking options.\n");
        Command =  Console.ReadLine().ToLower();
        HidText = false;

        if(Command == "check" || Command.Contains("che"))
        {
            System.Console.WriteLine("\nDate: 10/2/2025\n");
            System.Console.WriteLine($"\nInformation:\nName: {guest1.Name}\nAge: {guest1.Age}\nDate of Birth:{guest1.DateOfbirth}");
            System.Console.WriteLine("\n[Enter] to continue");
            Console.ReadLine();
            Console.Clear();
            continue;
        }
        if(Command == "ask" || Command.Contains("as"))
        {
            IsAsking = true;

            while(IsAsking)
            {
                System.Console.WriteLine("What do you want to ask?\n[1] Name.\n[2] Age.\n[3] Date of Birth.\n[4] Nevermind.");
                System.Console.WriteLine("\nYou can just press number and [Enter] to perform command.\n");
                Command = Console.ReadLine();
                if(Command == "1")
                {
                    ans = guest1.AskingName();
                    AnswerRepeat(ans, IsAsking);
                    IsAsking = false;
                }
                if (Command == "2")
                {
                    ans = guest1.AskingAge();
                    AnswerRepeat(ans, IsAsking);
                    IsAsking = false;
                }
                if (Command == "4")
                {
                    IsAsking = false;
                }
            }
            Console.Clear();
            continue;
        }
        else
        {
            System.Console.WriteLine("Type the right command.");
            System.Console.WriteLine("\n[Enter] to continue");
            Console.ReadLine();
            Console.Clear();
            continue;
        }
        
    }
}

static void AnswerRepeat(string ans, bool IsAsking)
{
    System.Console.WriteLine($"{ans}");
    Console.ReadLine();
}