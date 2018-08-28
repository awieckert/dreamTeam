using System;

namespace dreamTeam
{
  public class Adam : IPerson
  {

    public string Specialty {get; } = "JavaScirpt";

    private string _firstName = "Adam";

    private string _lastName = "Wieckert";

    public string FullName => $"{this._firstName} {this._lastName}";

    public void Work(){
      Console.WriteLine($"{FullName} will beast mode through the {Specialty} on this project");
    }

  }
}