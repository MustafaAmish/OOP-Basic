using System;
using System.Collections.Generic;
using System.Text;

public interface ICitizen
{
    string Name { get; }
    int Age { get; }
    string Id { get; }
    string Birthdate { get; }
   int Food { get; }
}