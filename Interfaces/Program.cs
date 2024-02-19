using System.Collections.Immutable;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person("Иванов Иван Иванович", new DateOnly(1990,05,02)),
                new Person("Тарасов Игорь Петрович", new DateOnly(2000,09,15)),
                new Person("Семенова Ирина Викторовна", new DateOnly(1998,06,30)),
                new Person("Петров Петр Семенович", new DateOnly(1965,12,02)),
                new Person("Сидорова Татьяна Владимировна", new DateOnly(1970,02,20)),
            };
            //после реализации интерфейса IComporable стало возможным применения метода Sort
            Array.Sort(people);
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            //установка родителей
            people[0].SetParent(people[4]);
            people[1].SetParent(people[3]);

            //клонирование 1 объекта из массива и вывод данных
            Person people0Cloned = (Person)people[0].Clone();
            Console.WriteLine("\n\nДанные склонированного объекта:\n" +
                people0Cloned + "\n\tРодитель: " + people0Cloned.Parent);

            Person person1 = people[0]; //копирование ссылки на объект
            Person person2 = (Person)people[1].Clone(); //клонирование данных объекта

            //смена данных в одном объекте влечет изменения в другом при копировании ссылки на объект
            person1.Birthday = new DateOnly(2005, 05, 05); 
            //смена данных в одном объекте ни как не вляет на второй при клонировании
            person2.Birthday = new DateOnly(1900, 02, 02);

           
        }
    }
}