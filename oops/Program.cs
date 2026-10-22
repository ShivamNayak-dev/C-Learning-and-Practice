/*Console.WriteLine("Hello, World!");

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

*/

Student s1 = new Student();
Student s2 = new Student();
Student s3 = new Student();

s1.name = "Shivam";
s2.name = "Aman";
s3.name = "gopla";

s1.Introduce();
s2.Introduce();
s3.Introduce();


public class Student{

    public string name = "Amit Kumar";

    public void Introduce(){
        Console.WriteLine($"My name if {name}");
    }


}


