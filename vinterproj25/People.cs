using System.Security.Cryptography.X509Certificates;

public class People
{
    private bool NameAlreadyAsked = false;
    private bool AgeAlreadyAsked = false;
    private bool DoBAlreadyAsked = false;
    public string Name;
    public int Age;
    
    public int Height;
    public int Weight;
    public string DateOfbirth;

    public string Address;

    public string Attribute;

    public bool IsImposter;

    public bool ImposterCheck()
    {
        return false;
    }

    public string AskingName()
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

}