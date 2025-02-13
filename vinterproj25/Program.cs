


System.Console.WriteLine("Day: 0\n");

Console.WriteLine("\nHi, you must be the new security checker. \nYour duty is to check if people that want to enter my party is actually invited.");
Console.ReadLine();
System.Console.WriteLine("Last time, some bastards just fake their name and the old security checker messed it up. \nSo, I've added more identity specification and I hope this time you won't disappoint me.");
Console.ReadLine();
System.Console.WriteLine("Well, since this is your first day, those people are my staff and I'll help to teach you how it works.");
System.Console.WriteLine("[Enter] when you're ready");
Console.ReadLine();

Console.Clear();

string Command;
bool IsAsking;
bool HidText = true;
string ans;
bool NameInfo = false;
bool AgeInfo = false;
bool DoBInfo = false;

bool IsTurtorial = true;


List<People> guests = new List<People>{  new InvitedPerson { Age = 24, DateOfbirth = "19/10/2001" },
    new InvitedPerson { Age = 30, DateOfbirth = "05/06/1995" },
    new InvitedPerson { Age = 27, DateOfbirth = "12/08/1997" }
};

// List<string> InvitedNames = 

int GuestIndex = 0;


while(GuestIndex < guests.Count)
{
    System.Console.WriteLine("Day: 0\n");
    System.Console.WriteLine($"Person invited: {guests.Count - GuestIndex}");



    System.Console.WriteLine($"\nHi, I'm looking forward to your party!");
    Console.ReadLine();
    System.Console.WriteLine("Now you'll need to check this guest information while asking to see if it matches or not.");
    
    while(true)
    {
        if (!HidText)
        {
            System.Console.WriteLine("Day: 0\n");
            System.Console.WriteLine($"Person invited: {guests.Count - GuestIndex}");
        }
        if (NameInfo && AgeInfo && DoBInfo&&IsTurtorial)
        {
            while(true)
            {
                System.Console.WriteLine("Now you've checked and asked for all the information. Make sure you REMEMBER it well some questions you're able to ask twice but not thrice.\nIf more than that will count as \u001b[31munusual behaviour\u001b[0m. \nAll other such as false name, age, date of birth or even some unusual sentecnes and words also count.\nSo please pay attention.");
                System.Console.WriteLine("\nIf you're sure that this guest can pass type [Pass] else [Kick]\n");
                Command =  Console.ReadLine().ToLower();
                if (Command.Contains("pa"))
                {
                    GuestIndex++; 
                    Console.Clear();
                    NameInfo = false; AgeInfo = false; DoBInfo = false;
                    guests[GuestIndex].ResetQuestions();
                    IsTurtorial = false;
                    break;
                }
                

               
            }
            continue;
        }
        else
        {
            System.Console.WriteLine("\nType [Check] to check information in my invited guest list and [Ask] to open asking options.\n");
        }
        Command =  Console.ReadLine().ToLower();
        HidText = false;

        if(Command == "pass" || Command.Contains("pa") && !IsTurtorial)
        {
            System.Console.WriteLine("Thanks for leting me in. \n[Enter] to continue.");
            GuestIndex++;             
            guests[GuestIndex].ResetQuestions();
            Console.ReadLine();
            Console.Clear();
            continue;

        }
        if(Command == "check" || Command.Contains("che"))
        {
            System.Console.WriteLine("\nDate: 10/2/2025\n");
            System.Console.WriteLine($"\nInformation:\nName: {guests[GuestIndex].Name}\nAge: {guests[GuestIndex].Age}\nDate of Birth:{guests[GuestIndex].DateOfbirth}");
            System.Console.WriteLine("\n[Enter] to continue");
            Console.ReadLine();
            Console.Clear();
            continue;
        }
        if(Command == "ask" )
        {
            IsAsking = true;

            while(IsAsking)
            {
                System.Console.WriteLine("What do you want to ask?\n[1] Name.\n[2] Age.\n[3] Date of Birth.\n[4] Nevermind.");
                System.Console.WriteLine("\nYou can just press number and [Enter] to perform command.\n");
                Command = Console.ReadLine();
                if(Command == "1")
                {
                    NameInfo = true;
                    ans = guests[GuestIndex].AskingName();
                    AnswerRepeat(ans, IsAsking);
                    IsAsking = false;
                }
                if (Command == "2")
                {
                    AgeInfo = true;
                    ans = guests[GuestIndex].AskingAge();
                    AnswerRepeat(ans, IsAsking);
                    IsAsking = false;
                }
                if(Command == "3")
                {
                    DoBInfo = true;
                    ans = guests[GuestIndex].AskingDoB();
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