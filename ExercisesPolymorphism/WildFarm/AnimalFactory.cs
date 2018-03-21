using System;
using System.Collections.Generic;
using System.Text;

public class AnimalFactory
{
    public static Animal GetAnimal(string typeAnimal, string name, double weight, string livingRegion, string breed)
    {
        switch (typeAnimal)
        {
            case "Owl":var owl=new Owl(name,weight,double.Parse(livingRegion));
                owl.ProducingSound();
                return owl;
            case "Hen":var hen=new Hen(name, weight, double.Parse(livingRegion));
                hen.ProducingSound();
                return hen;
            case "Mouse": var mouse=new Mouse(name, weight, livingRegion);
                mouse.ProducingSound();
                return mouse;
            case "Cat": var cat= new Cat(name, weight, livingRegion,breed);
                cat.ProducingSound();
                return cat;
            case "Dog": var dog=new Dog(name, weight, livingRegion);
                dog.ProducingSound();
                return dog;
            case "Tiger":
                var tigre=new Tiger(name, weight, livingRegion, breed);
                tigre.ProducingSound();
                return tigre;

                default:
                    return null;
        }
    }
}