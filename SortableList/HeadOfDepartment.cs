namespace SortableList
{
    /// <summary>
    /// Abteilungsleiter ist ein Abteilungsmitarbeiter, der die Abteilung leitet
    /// Er gibt einen speziellen Text als Info aus und erhält 20% Leitungszuschlag auf seinen Monatslohn
    /// </summary>
    public class HeadOfDepartment : DepartmentalEmployee
    {

        /// <summary>
        /// Konstruktor des Abteilungsleiters verwendet den Konstruktor des 
        /// Abteilungsmitarbeiters.
        /// Spezielles bleibt nichts übrig
        /// </summary>
        /// <param name="name"></param>
        /// <param name="department"></param>
        /// <param name="monthlyWage"></param>
        public HeadOfDepartment(string name, string department, double monthlyWage)
            : base(name, department, monthlyWage)
        {
        }

        /// <summary>
        /// Abteilungsleiter schreibt Text komplett neu (100% Änderung)
        /// Verwendet den Text der Basisklasse (Abteilungsmitarbeiter) nicht
        /// </summary>
        /// <returns>Info des Abteilungsleiters</returns>
        public override string GetInfo()
        {
            return string.Format("Ich heiße {0} und leite die Abteilung {1}", Name, Department);
        }

        /// <summary>
        /// Abteilungsleiter ist ein Angestellter und bekommt 20% Zuschlag
        /// für die Leitung der Abteilung
        /// </summary>
        /// <returns></returns>
        public override double GetSalary()
        {
            return base.GetSalary() * 1.2;
        }
    }
}
