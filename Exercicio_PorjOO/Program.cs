using Exercicio_PorjOO;

internal class Program
{
    private static void Main(string[] args)
    {
        //Person person = new Person();

        //person.PurchaseParkingPass();

        Student student = new Student();

        student.getStudentNumber();

        Console.WriteLine(student);


        Professor professor = new Professor();

        professor.getSalary();

        Console.WriteLine(professor);
    }
}

