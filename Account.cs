namespace knightmoves;

public class Account {
   // Add your code here
   public static string Name;
   
   static Account(){
      Name = "Main Account";
   }
   
   public static string ChangeName(string newName){
      Name = newName;
      return Name;
   }
}



