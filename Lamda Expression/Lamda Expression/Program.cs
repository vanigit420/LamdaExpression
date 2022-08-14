public class Person
{
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Email { get; set; }
    public long Mobile { get; set; }
    public string Password { get; set; }
    public Person(string first_Name, string last_Name, string email, long mobile, string password)
    {
        First_Name = first_Name;
        Last_Name = last_Name;
        Email = email;
        Mobile = mobile;
        Password = password;
    }
    public override string ToString()
    {
        return First_Name + " " + Last_Name + " " + Email + " " + Mobile + " " + Password;
    }



}

class Program
{
    static void Main(string[] args)
    {
        {
            List<Person> list = new List<Person>();
            AddPerson(list);


        }
        static void AddPerson(List<Person> list)
        {

            list.Add(new Person("Sudhanshu", "Yadav", "Sy7040@gmail.com", 8960606269, "Jsh@123"));
            list.Add(new Person("Prakhar", "Pradhan", "Prakhar@gmail.com", 8967544569, "Prakhhh@123"));
            list.Add(new Person("Himanshu", "Yadav", "Himanshu@gmail.com", 9897544566, "Himmag@123"));


        }
        static void Search(List<Person> list)
        {
            foreach (Person person in list.FindAll(s => s.First_Name.Equals("Sudhanshu")))
            {
                Console.WriteLine(person.ToString);
            }

        }
    }
}