using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AdoptionCenter
{
    public AdoptionCenter(string name)
    {
        Name = name;
        Animals = new List<Animal>();
    }


    public string Name { get;private set; }
    public List<Animal> Animals { get;private set; }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public void Adopt(List<string> adopted)
    {
        foreach (var animal in adopted)
        {
           var ani= Animals.First(n=>n.Name==animal);
            Animals.Remove(ani);
        }
    }

}
