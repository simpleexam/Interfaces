using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Person : IComparable<Person>, ICloneable
    {
        string name; //имя  
        string surname; //фамилия
        string patronymic; //отчество

        public string FIO //свойство ФИО только на чтение - собирает данные из трех полей
        {
            get => new string(surname+ " " + name + " " + patronymic);
        }
        DateOnly birthday; // поле даты рождения
        public DateOnly Birthday //свойство даты рождения с проверкой на корректность
        {
            get => birthday;
            set
            {
                if(value < new DateOnly(1900, 01, 01))
                {
                    Console.WriteLine("incorrect birthday, please enter data since 1900.01.01");
                    birthday = DateOnly.Parse(Console.ReadLine());
                }
                else birthday = value;
            }
        } 

        public Person Parent { get; set; } //родитель текущего объекта 

        public Person(string fio, DateOnly bd)
        {
            string[] temp = fio.Split(' ');
            surname = temp[0];  
            name = temp[1];
            patronymic = temp[2];  
            
            Birthday = bd;
        }
        
        public void SetParent(Person parent) //мсетод привязки к родителю
        {
            this.Parent = parent;
        }
       
        public override string ToString()
        {
            return $"{surname} {name} {patronymic}. Дата рождения: {Birthday}";
        } 

        /// <summary>
        /// реализация интерфейса IComporable
        /// </summary>
        /// <param name="other">другой объект для сравнения с текущим</param>
        /// <returns>0 есоои равны -1 и 1 в соответствии по правилам сравнения метода CompareTo</returns>
        public int CompareTo(Person other)
        {
            //return Birthday.CompareTo(other.Birthday);  //сравнение по дате рождения
            return surname.CompareTo(other.surname);   // сравнение по фамилии
        }
        /// <summary>
        /// реализация интерфейса IClonable
        /// </summary>
        /// <returns>склонированный объект</returns>
        public object Clone()
        {
            Person clonedPerson = new Person(this.FIO, this.Birthday);
            clonedPerson.Parent = new Person(this.Parent.FIO, this.Parent.Birthday); //реализация глубокого клонирования
            return clonedPerson;
        }
    }
}
