using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_User
{
    class Employee : User
    {
        public string Position { get; set; }
        public int Experience { get; set; }
        public Employee(string firstName, string secondName, string lastName,
            string dateOfBirth, int age, string position, int experience)
            : base(firstName, secondName, lastName, dateOfBirth, age)
        {
            Position = position;
            Experience = experience;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Стаж работы: " + Experience + " года/лет" + "\n" +
                "Должность: " + Position);
        }
    }
}
