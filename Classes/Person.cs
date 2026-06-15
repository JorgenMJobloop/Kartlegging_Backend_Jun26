public class Person
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string HomeAddress { get; set; } = string.Empty;
    public string Occupation { get; set; } = string.Empty;
    public List<string> Hobbies { get; set; } = new List<string>();


    public Person()
    {

    }

    public Person(string name, int age, string homeAddress, string occupation, List<string> hobbies)
    {
        Name = name;
        Age = age;
        HomeAddress = homeAddress;
        Occupation = occupation;
        Hobbies = hobbies;
    }

    public void PrintPersonInformation()
    {
        Console.WriteLine($"Name: {Name}. Age: {Age}. Address: {HomeAddress}. Occupation: {Occupation}. Hobbies: {string.Join(", ", Hobbies)}");
    }
}