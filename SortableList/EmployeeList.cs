using System;

namespace SortableList
{
    /// <summary>
    /// Verwaltet Mitarbeiter in selbst codierter Liste
    /// </summary>
    public class EmployeeList
    {

        /// <summary>
        /// Leere Liste erzeugen
        /// </summary>
        public EmployeeList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Wie viele Mitarbeiter sind in der Liste
        /// </summary>
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Fügt einen Mitarbeiter absteigend sortiert nach Gehalt hinzu
        /// </summary>
        /// <param name="employee">Mitarbeiter</param>
        public void Insert(Employee employee)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Der Mitarbeiter mit dem Namen wird in der Liste
        /// gesucht und dessen Index wird zurückgegeben.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Position oder -1 wenn nicht gefunden</returns>
        public int FindByName(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gibt die Position des ersten Mitarbeiters mit dem Namen in
        /// der Liste zurück.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Index oder -1 falls nicht gefunden</returns>
        public int FindEmployeeByName(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Liefert alle Mitarbeiter zurück
        /// </summary>
        /// <returns></returns>
        public Employee[] GetEmployees()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gibt die Summe der Gehälter für die Mitarbeiter der Abteilung zurück
        /// </summary>
        /// <param name="department"></param>
        /// <returns>Summe der Gehälter oder 0, falls Abt. nicht existiert</returns>
        public double GetSalaryOfDepartment(string department)
        {
            throw new NotImplementedException();
        }
    }
}
