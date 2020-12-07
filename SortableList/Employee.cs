using System;

namespace SortableList
{
    /// <summary>
    /// Abstrakter Mitarbeiter
    /// Codeverdopplung wird vermieden, indem in dieser Klasse alles implementiert wird,
    /// was alle Arten von Mitarbeitern (Arbeiter, Angestellte, Abteilungsleiter) gemeinsam haben
    /// </summary>
    public abstract class Employee : IComparable
    {
        string _name;        // Konkrete Felder jedes Mitarbeiters
        string _department;

        /// <summary>
        /// Konstruktor erzeugt Mitarbeiter mit Namen und Abteilung
        /// </summary>
        /// <param name="name"></param>
        /// <param name="department"></param>
        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
        }

        /// <summary>
        /// Jeder Mitarbeiter kann seine Grunddaten bekanntgeben
        /// </summary>
        /// <returns></returns>
        public virtual string GetInfo()
        {
            return string.Format("Ich heiße {0} und arbeite in der Abteilung {1}",
                Name, Department);
        }


        /// <summary>
        /// Liefert das Gehalt des Mitarbeiters. Dieses ist aber für Arbeiter,
        /// Angestellte und Abteilungsleiter unterschiedlich und kann daher
        /// in der Basisklasse nicht implementiert werden.
        /// </summary>
        /// <returns></returns>
        public abstract double GetSalary();


        public string Department
        {
            get { return _department; }
            private set { _department = value; }
        }

        public string Name
        {
            get { return _name; }
            private set
            {
                if (value.Length >= 2 && char.IsUpper(value[0]) && char.IsLetter(value[0]))
                {
                    _name = value;
                }
                else
                {
                    _name = "ERROR";
                }
            }
        }

        public int CompareTo(object other)
        {
            var employee = other as Employee;
            if (employee==null)
            {
                throw new ArgumentException("Illegaler Typ");
            }
            return employee.GetSalary().CompareTo(GetSalary());
        }
    }
}
