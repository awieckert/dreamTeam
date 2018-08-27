using System;

namespace dreamTeam
{
  public class Emily
  {
    public string Specialty {get; } = "CSS";

    private string _firstName = "Emily";

    private string _lastName = "Persons";

    public string FullName => $"{this._firstName} {this._lastName}";

    public void Work(){
      Console.WriteLine($"{FullName} will use {Specialty} to style the shit out of this project");
    }
  }
}