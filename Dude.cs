using System;

namespace dreamTeam
{
  public class Dude : IPerson
  {
    public string Specialty {get; } = "HTML5";

    private string _firstName = "Dude";

    private string _lastName = "Guy";

    public string FullName => $"{this._firstName} {this._lastName}";

    public void Work(){
      Console.WriteLine($"{FullName} will use {Specialty} to boiler plate the heck outta this project");
  }

  }
}