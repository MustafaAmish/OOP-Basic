using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string model;
    private Engine engine;
    private Tire[] tire;
    private Cargo cargo;

    public string Model { get; private set; }
    public Engine Engine { get; private set; }
    public Tire[] Tires { get; set; }
    public Cargo Cargo { get; set; }    

    public Car(string model,Engine engine,Cargo cargo,Tire[] tires)
    {
        this.Model = model;
        this.Engine = engine;
        this.Tires = tires;
        this.Cargo = cargo;

    }




}

