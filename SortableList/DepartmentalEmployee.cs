
namespace SortableList
{
    /// <summary>
    /// Abteilungsmitarbeiter ist ein Mitarbeiter
    /// Als Gehalt erhält er einen fixen Monatslohn
    /// </summary>
    public class DepartmentalEmployee : Employee
    {
        double _monthlyWage;

        /// <summary>
        /// Konstruktor des Abteilungsmitarbeiter
        /// Verwendet den Konstruktor der Basisklasse und ergänzt diesen um spezielle
        /// Aufgaben für den Angestellten
        /// </summary>
        /// <param name="name"></param>
        /// <param name="department"></param>
        /// <param name="monthlyWage"></param>
        public DepartmentalEmployee(string name, string department, double monthlyWage)
            : base(name, department)
        {
            _monthlyWage = monthlyWage;
        }

        /// <summary>
        /// Abteilungsmitarbeiter fügt sein Dienstverhältnis hinzu
        /// </summary>
        /// <returns>Info des Angestellten</returns>
        public override string GetInfo()
        {
            return base.GetInfo() + " und bin Angestellter";
        }

        /// <summary>
        /// Abteilungsmitarbeiter überschreibt GetSalary() indem er seinen
        /// Monatslohn zurückgibt.
        /// </summary>
        /// <returns></returns>
        public override double GetSalary()
        {
            return _monthlyWage;
        }
    }
}
