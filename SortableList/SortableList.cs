using System;

namespace SortableList
{
    public class SortableList
    {

        /// <summary>
        /// Ein Mitarbeiter wird nach Gehalt sortiert (absteigend) in die Liste eingefügt.
        /// Es sind keine Fehlerüberprüfungen notwendig.
        /// </summary>
        /// <param name="data"></param>
        public void Insert(IComparable data)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Wie viele Mitarbeiter befinden sich in der Liste
        /// </summary>
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }



        /// <summary>
        /// Liefert alle Elemente in Form eines Arrays zurück
        /// </summary>
        /// <returns>Array in der richtigen Größe</returns>
        public IComparable[] ToArray()
        {
            throw new NotImplementedException();
        }
    }
}
