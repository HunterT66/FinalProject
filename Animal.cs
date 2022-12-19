using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
// Base Class

public class Animal
{
    public string name;
    public string color;
    public string gender;
   

    public Animal(string n, string c, string g)
    {
        name = n;
        color = c;  
        gender = g; 
    }
}

//Derived Class

public class Dog : Animal
{
    public string breed;
    public string ownerName;
    public string favFood;
    public Dog(string b, string on, string f) :base(b, on, f)
    {

        breed = b;
        ownerName = on;
        favFood = f;
    }
    
}


public class Cat : Animal
{
    public string breed;
    public string ownerName;
    public string favFood;
    public Cat(string b, string on, string f) : base(b, on, f)
    {
        breed = b;
        ownerName = on;
        favFood = f;
    }
}

public class Panda : Animal
{
    public string breed;
    public string ownerName;
    public string favFood;
    public Panda(string b, string on, string f) :base(b, on, f)
    {
        breed = b;
        ownerName = on;
        favFood = f;
    }

   
}
