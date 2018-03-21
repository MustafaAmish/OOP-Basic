using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CleansingCenter
{
    public CleansingCenter(string name)
    {
        Name = name;
        Animals = new List<Animal>();
    }


    public string Name { get; private set; }
    public List<Animal> Animals { get;private set; }

    public void AddForClining(List<Animal> animals)
    {
        Animals.AddRange(animals);
    }

    public void CliningAnimal()
    {
        foreach (var animal in Animals)
        {
            animal.Status = true;
        }
        Animals.Clear();
    }
}
