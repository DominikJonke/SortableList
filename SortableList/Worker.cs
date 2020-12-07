namespace SortableList
{
    /// <summary>
    /// Arbeiter ist ein Mitarbeiter, der aber nach Arbeitsstunden und Stundenlohn bezahlt wird
    /// </summary>
    public class Worker : Employee
    {
        double _hours;           // Spezielle Daten des Arbeiters
        double _hourlyWage;      // Stundenlohn

        /// <summary>
        /// Überladener Konstruktor
        /// Stunden und Stundenlohn werden später zugebracht
        /// Verwendet den Konstruktor der Basisklasse Data
        /// </summary>
        /// <param name="name"></param>
        /// <param name="department"></param>
        public Worker(string name, string department)
            : base(name, department)
        {
        }

        /// <summary>
        /// Überladener Konstruktor des Arbeiters verwendet wieder den Konstruktor der eigenen Klasse mit
        /// (Deltaprogrammierung)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="department"></param>
        /// <param name="hours"></param>
        /// <param name="hourlyWage"></param>
        public Worker(string name, string department, double hours, double hourlyWage)
            : this(name, department)
        {
            Hours = hours;
            HourlyWage = hourlyWage;
        }

        /// <summary>
        /// Arbeiter fügt sein Dienstverhältnis hinzu
        /// </summary>
        /// <returns>Info des Arbeiter</returns>
        public override string GetInfo()
        {
            return base.GetInfo() + " und bin Arbeiter";
        }

        public double HourlyWage
        {
            get
            {
                return _hourlyWage;
            }
            set // wird ein negativer Stundenlohn angegeben, wird 0 übernommen
            {
                if (value > 0)
                {
                    _hourlyWage = value;
                }
                else
                {
                    _hourlyWage = 0;
                }
            }
        }

        /// <summary>
        /// Die Monatsstunden dürfen nicht negativ sein. Ausserdem ist die
        /// Tagesarbeitszeit auf 16 Stunden beschränkt
        /// </summary>
        public double Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value > 0 && value < 16 * 31)  // Stunden sind möglich
                {
                    _hours = value;
                }
                else
                {
                    _hours = 0;
                }
            }
        }

        /// <summary>
        /// Das Gehalt des Arbeiters unterscheidet sich in der Berechnung
        /// vom Gehalt des Mitarbeiters und Angestellten.
        /// </summary>
        public override double GetSalary()
        {
            return _hours * _hourlyWage;
        }

    }
}
