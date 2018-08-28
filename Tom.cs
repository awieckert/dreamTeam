using System;

namespace dreamTeam
{
  public class Tom : IPerson
  {
    public string Specialty {get; } = "CSS";

    private string _firstName = "Tom";

    private string _lastName = "Boy";

    public string FullName => $"{this._firstName} {this._lastName}";

    public void Work(){
      Console.WriteLine($"{FullName} will use {Specialty} to style the shit out of this project");
    }
  }
}