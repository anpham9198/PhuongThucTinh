using PhuongThucTinh;

public class Program : Shap
{
    private static void Main(string[] args)
    {
        Student s1 = new Student(123, "An", 20);
        Student s2 = new Student(123, "Chau", 19);
        Student s3 = new Student(123, "Minh", 18);
        Student.Show();
    }
}