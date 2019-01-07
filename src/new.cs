using System;

public class Person {
    public Person(){
        Name = "Unknown";
    }
    public Person(string name){
        this.Name = name;
    }

    // Auto-implemented readonly property:
    public string Name { get; }

    public override ToString(){
        return Name;
    }


}

class TestPerson {
    static void main() {
        var person1 = new Person();
        Console.WriteLine(person1.Name);

        var person2 = new Person("sarah jane");
        Console.WriteLine(person2.Name);

        Console.WriteLine("press any key to exit");
        Console.ReadKey();
    }
}