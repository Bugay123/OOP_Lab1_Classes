/*Розробити консольний застосунок для роботи з класом
Student з полями: name, age, course, rating.
Всі поля класу зробити закритими, а доступ до них реалізувати
через шаблони властивостей. Реалізувати конструктор з
параметрами.
Створити методи:
EditStudent для редагування даних. Метод має 3 параметри
для зміни значень полів name, age, rating.
StudentRating(double rating), який виводить рейтинг студента.
GetRole(int course) – повертає рядок: бакалавр чи магістр
залежно від курсу.*/

namespace Task1;
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Role { get; set; }
    public int Course { get; set; }
    public double Rating { get; set; }
    public Student(string name, int age, int course, double rating)
    {
        Name = name;
        Age = age;
        Course = course;
        Rating = rating;
    }

    public void EditStudent(string name, int age, double rating)
    {
        Name = name;
        Age = age;
        Rating = rating;
    }
    public string GetRole(int course)
    {
        if (course <= 4)
            Role = "бакалавр";
        else
            Role = "магістр";
        return Role;
    }
    public void Student_Rating()
    {
        if (Rating >= 82)
            Console.WriteLine("Привіт відмінникам");
        else
            if (Rating <= 60)
            Console.WriteLine("Перездача! Треба краще вчитися!");
        else
            Console.WriteLine("Можна вчитися ще краще!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student stud = new Student("Tom", 23, 4, 85);
        Console.WriteLine($"Студент {stud.Name}, {stud.Course} курсу");
    }
}
