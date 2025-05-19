using System.Security.Cryptography.X509Certificates;

public class People
{
    private bool NameAlreadyAsked = false;
    private bool AgeAlreadyAsked = false;
    private bool DoBAlreadyAsked = false;
    public string Name;
    public int Age;
    public string DateOfbirth;
    public virtual string AskingName()
    { 
       
        int random = Random.Shared.Next(1,3);
        

        if(NameAlreadyAsked)
        {
            return "You already asked me?";
        }
        else if(random == 1)
        {
            NameAlreadyAsked = true;
            return $"My name? my name is {Name}!";
        }
        else if(random == 2)
        {
            NameAlreadyAsked = true;
            return $"My name is {Name}.";
        }
        else
        {
            return null;
        }
    
    }
    public string AskingAge()
    {

        if(!AgeAlreadyAsked)
        {
            AgeAlreadyAsked = true;
            return $"My age is {Age}.";
        }
        return "You already asked my age.";
    }
    public string AskingDoB()
    {
         if(!DoBAlreadyAsked)
        {
            DoBAlreadyAsked = true;
            return $"I was born in {DateOfbirth}.";
        }
        return "You already asked me that.";
    }

    public void ResetQuestions()
    {
        NameAlreadyAsked = false;
        AgeAlreadyAsked = false;
        DoBAlreadyAsked = false;
    }

    public override string ToString()
    {
        return $"Name: {Name} \nAge: {Age}\nDate of Birth: {DateOfbirth}";
    }

}