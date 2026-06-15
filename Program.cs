namespace Kartlegging_Backend;

class Program
{
    static void Main(string[] args)
    {
        // old way of assigning objects
        // Person john = new Person();
        // new way
        var jane = new Person()
        {
            Name = "Jane Doe",
            Age = 32,
            HomeAddress = "Narnia",
            Occupation = "Magic",
            Hobbies = []
        };
        var tony = new Person("Tony Soprano", 48, "New Jersey", "Mafia boss", ["Making people miserable", "gambling", "extorsion"]);
        var dale = new Person("Dale Cooper", 32, "Twin Peaks", "FBI Agent", ["the occult", "solving crime"]);

        jane.PrintPersonInformation();
        tony.PrintPersonInformation();
        dale.PrintPersonInformation();
    }
}
