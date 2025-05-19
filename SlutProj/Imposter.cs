using System.Security.Cryptography.X509Certificates;

public class Imposter : People
{   
    public Imposter()
    {
    }
    public override string AskingName()
    {
        
        
        return $"I'm Mario!"; 
    }

    public  bool IsImposter()
    {
        return true;
    }
}


