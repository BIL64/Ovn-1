using System.Collections;

namespace Ovn_5_Garage.Garage
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private readonly int capacity;

        private T[] vehicles; // The vehicle array.

        public Garage(int capacity)
        {
            this.capacity = Math.Max(capacity, 2);
            vehicles = new T[this.capacity];
        }

        public int Count
        {
            get
            {
                return vehicles.Count();
            }
        }

        public bool IsFull
        {
            get
            {
                int tal = 0;
                foreach (var item in vehicles)
                {
                    if (item is not null) tal++;
                }
                if (tal >= capacity) return true; else return false;
            }
        }

        public bool Add(T newVehic) // Not by myself
        {
            for (var i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] is null)
                {
                    vehicles[i] = newVehic;
                    return true;
                }                
            }
            return false;
        }

        public bool Remove(int index) // By myself. Tar bort via index med kopieringsmetoden.
        {
            T[] temp = new T[vehicles.Length];
            bool findindex = false;

            for (var i = 0; i < vehicles.Length; i++)
            {
                if (index == i) findindex = true;

                if (findindex && i < vehicles.Length - 1)
                {
                    temp[i] = vehicles[i + 1];
                }

                if (!findindex && i < vehicles.Length)
                {
                    temp[i] = vehicles[i];
                }           
            }
            
            if (findindex) vehicles = temp; 
            return findindex;
        }

        public IEnumerator<T> GetEnumerator() // Extra. David hjälpte mig med det här plus en hel del annat!
        {
            foreach (var item in vehicles)
            {
                if (item is not null)
                {
                    //if (vehicles.Contains(item))
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
