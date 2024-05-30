namespace coreObjectOrientedConcepts
{
    internal class Student
    {
        int studentId;
        string studentName;

        public void acceptDetails()
        {
            Console.Write("Enter Student Id:");
            studentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name:");
            studentName = Console.ReadLine();
        }
        public void displayDetails()
        {
            Console.WriteLine("Student Id:" + studentId);
            Console.WriteLine("Student Name:" + studentName);
        }
    }
}