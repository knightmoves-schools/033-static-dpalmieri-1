namespace Tests;

using System.Reflection;
using knightmoves;
using Xunit;

public class AutogradingTest
{

    [Fact]
    public void Should_Create_A_Public_Static_Class_Level_String_Variable_Named_Name(){
      Assert.True(Account.Name != null);;
    }

    [Fact]
    public void Should_Create_A_Static_Constructor_That_Sets_The_Name_Varoable_To_Main_Account(){
      Assert.Equal("Main Account", Account.Name);
    }

    [Fact]
    public void Should_Create_A_Public_Static_Method_Named_ChangeName_That_Takes_A_New_Name_Sets_Name_With_The_New_Value_And_Returns_The_New_Name(){
      Assert.Equal("Nancy's Account", Account.ChangeName("Nancy's Account"));
      Assert.Equal("Nancy's Account", Account.Name);
    }
}