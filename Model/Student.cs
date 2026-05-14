using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Mobile { get; set; }
}
