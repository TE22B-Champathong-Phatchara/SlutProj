using System.Security.Cryptography.X509Certificates;

public class InvitedPerson : People
{
    
    public List<string> NameList =  new List<string>{
     
     "John Smite", "Christ Backer", "Josh Wallington", "Khan Kodaberg", "Marry Meplaese", "Micke Versuski", "Jane Doera", "Luise Elcarte"
     
     };




    

    
   public InvitedPerson()
   {
        Name = NameList[Random.Shared.Next(NameList.Count)];
   }

}
