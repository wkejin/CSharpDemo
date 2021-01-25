public class Teacher : Person
{
    public string Subject { get; set; }
    public decimal Salary { get; set; }
    public override void SayHi()
    {
        System.Console.WriteLine($"我叫{this.Name}, 我是一名老师.");
    }
}