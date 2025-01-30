using System.Security.Cryptography.X509Certificates;

public class People
{
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

}
