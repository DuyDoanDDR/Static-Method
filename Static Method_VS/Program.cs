using System.Security.Cryptography;

public class Student
{
    private int rollno;
    private string name;
    private static string college = "BBDIT";

    public Student(int r, string n) //Constructor
    {
        rollno = r;
        name = n;
    }

    public static void Change()
    {
        college = "CODEGYM";
    }

    public void Display()
    {
        Console.WriteLine(rollno + "" + name + "" + college);
    }
}

public class program
{
    public static void Main(string[] args)
    {
        Student.Change();

        Student s1 = new Student(111, "Hoang"); //s1 la mot bien tham chieu, tham chieu den doi tuong Student(111,"Hoang") duoc luu trong Heap 
        Student s2 = new Student(222, "Thanh");
        Student s3 = new Student(333, "Lam");
        s1.Display();
        s2.Display();
        s3.Display();
    }
    
}