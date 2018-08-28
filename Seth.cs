using System;

namespace dreamTeam
{
  public class Seth : IPerson
  {
    public string Specialty {get; } = "C#";

    private string _firstName = "Seth";

    private string _lastName = "ManGuy";

    public string FullName => $"{this._firstName} {this._lastName}";

    public void Work(){
      Console.WriteLine($"{FullName} is about to lay down the law with some {Specialty} on this bad boy");
    }

  }
}