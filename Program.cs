using System;
using System.Collections.Generic;

namespace dreamTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

          Adam adam = new Adam();
          Tom tom = new Tom();
          Seth seth = new Seth();
          Emily emily = new Emily();
          Guy guy = new Guy();
          Dude dude = new Dude();

          List<IPerson> frontEnd = new List<IPerson>();
          List<IPerson> backEnd = new List<IPerson>();

          frontEnd.Add(dude);
          frontEnd.Add(guy);
          frontEnd.Add(emily);

          backEnd.Add(adam);
          backEnd.Add(tom);
          backEnd.Add(seth);

          foreach (IPerson person in frontEnd)
          {
              person.Work();
          }

          foreach (IPerson person in backEnd)
          {
              person.Work();
          }
        }
    }
}
