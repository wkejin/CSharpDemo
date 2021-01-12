public class Student : Person
{
    public string ClassName { get; set; }

    public override void SayHi()
    {
        System.Console.WriteLine($"我叫{this.Name}, 我是一名学生.");
    }
}