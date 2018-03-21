using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CastrationCenter
{
    public CastrationCenter(string name)
    {
        Name = name;
        Animals =new List<Animal>();
    }

    public string Name { get; set; }
    public List<Animal> Animals { get; set; }

    public void AddAnimalCastration(List<Animal> animals)
    {
        Animals.AddRange(animals);
    }

    public void Castration()
    {
        Animals.Clear();
    }
}