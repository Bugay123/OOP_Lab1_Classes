using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Розробити клас Тварина з 4 полями і двома методами.
Поля: ім’я, вага, вік, вид.
Доступ до полів реалізувати через властивості get i set.
Реалізувати конструктор без параметрів, а ініціалізацію полів
виконати через властивості у коді програми.
Методи:
Перший метод виводить на консоль вагу тварини.
Другий метод виводить на консоль запит “Що це за тварина?”
Сформувати рядок “Це тварина” + "вид" + "ім’я" і вивести
його на консоль.*/

namespace Task2;
class Animal
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }
    public string Type { get; set; }

    public Animal() { }

    public void AnimalWeight() { Console.WriteLine(Weight); }
    public void WhoIsIt()
    {
        Console.WriteLine("Цо це за тварина?");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal() { Name = "Мурка" };
        animal.Weight = 60;
        animal.AnimalWeight();
        animal.Type = Console.ReadLine();
        Console.WriteLine($"Це тварина  {animal.Type} {animal.Name}");
    }
}
