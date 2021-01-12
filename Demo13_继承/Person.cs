public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }

    public virtual void SayHi()
    {
        System.Console.WriteLine($"Hi,我叫{this.Name}.");
    }
}