///*
/**Program Name: Dog, Cat, or Panda maker
* Programmer: Hunter Thornsberry
 * Date: 12 / 19 / 2022
 *
 *Description: My program creates a list and then lets the user 
 * decide if they want to be a Dog, Panda, or Cat
 * The program then asks multiple questions about the animal
 * the program displays this information and makes a list
 */
bool isLooping = true;

List<Dog> dogs = new List<Dog>();
List<Cat> cats = new List<Cat>();
List<Panda> pandas = new List<Panda>();

while(isLooping)
{
    Console.WriteLine("Press 1 to be a Dog");
    Console.WriteLine("Press 2 to be a Cat");
    Console.WriteLine("Press 3 to be a Panda");
    string userInput = Console.ReadLine();
    

    Console.WriteLine("Name:");
    string n = Console.ReadLine();

    Console.WriteLine("Color:");
    string c = Console.ReadLine();

    Console.WriteLine("Gender:");
    string g = Console.ReadLine();

    Console.WriteLine("Breed:");
    string b = Console.ReadLine();

    Console.WriteLine("Owner Name:");
    string on = Console.ReadLine();

    Console.WriteLine("Favorite Food:");
    string f = Console.ReadLine();
 Console.Clear();
    if (userInput == "1")
    {
        Dog dog = new Dog(b, on, f);
        dogs.Add(dog);
        Console.WriteLine("You are a dog, ");
        eat();
    }
    else if (userInput == "2")
    {
        Cat cat = new Cat(b, on, f);
        cats.Add(cat);
        Console.WriteLine("You are a cat, ");
        eat();
    }
    else if (userInput == "3")
    {
        Panda panda = new Panda(b, on, f);
        pandas.Add(panda);
        Console.WriteLine("You are a panda, ");
        eat();
    }
    else
    {
        Console.WriteLine("Invalid Selection...");
    }

    void eat()
    {
        Console.WriteLine("your name is " + n + ", " + "your color is " + c + ", " +
     "your gender is " + g + ", " + "your breed is " + b + ", " + "your owners name is " +
     on + ", " + "and your favorite food is " + f + ".");
    }
    Console.WriteLine("Dogs:");
    foreach (Dog dog in dogs)
    {
        Console.WriteLine(dog.name);
    }
    Console.WriteLine("Cats:");
    foreach (Cat cat in cats)
    {
        Console.WriteLine(cat.name);
    }
    Console.WriteLine("Pandas:");
    foreach (Panda panda in pandas)
    {
        Console.WriteLine(panda.name);
    }
}