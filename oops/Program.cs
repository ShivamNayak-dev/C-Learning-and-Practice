Console.WriteLine("Hello, World!");

Dog dog = new Dog();
dog.Name="Tommy";

dog.Eat();
dog.Bark();


public class Animal{
   public  String Name = "";

    public void Eat(){
        Console.WriteLine($"{Name} is eating");


    }
}

public class Dog : Animal{
    public void Bark(){
        Console.WriteLine($"{Name} is Barking");
    }
}

