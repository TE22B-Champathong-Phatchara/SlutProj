using System.Security.Cryptography.X509Certificates;

public class InvitedPerson : People
{
    
    public static List<string> NameList =  ["John Smite", "Christ Backer", "Josh Wallington", "Khan Kodaberg", "Marry Meplaese", "Micke Versuski", "Jane Doera", "Luise Elcarte"];





    

    
   public InvitedPerson()
   {
        Name = NameList[Random.Shared.Next(NameList.Count)];
   }
}
