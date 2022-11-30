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

        //public bool Add(T item, int index)
        //{
        //    ArgumentNullException.ThrowIfNull(item, nameof(item));

        //    if (IsFull) return false;
        //    else
        //    {
        //    vehicles[index] = item;
        //    return true;
        //    }
        //}

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

        //public bool Remove(T item) // Krånglig.
        //{
        //    try
        //    {
        //        vehicles = vehicles.Where(val => val != item).ToArray();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

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
            vehicles = temp;
            return findindex;            
        }

        //public T[] Remove(int index) // Fuskis.
        //{
        //    for (int i = index; i < vehicles.Length - 1; i++)
        //    {
        //        vehicles[i] = vehicles[i + 1];
        //    }
        //    Array.Resize(ref vehicles, vehicles.Length - 1);
        //    return vehicles;
        //}

        //public void Search()
        //{
        //    var myLinqQuery = from name in vehicles
        //                      where name.Contains("Car")
        //                      select name;
        //}

        public void Print(Action<Vehicle> action)
        {
            foreach (var item in vehicles)
            {
                action?.Invoke(item);
            }
        }

        public IEnumerator<T> GetEnumerator() // David fixade till detta, plus en hel del annat!
        {
            foreach(var item in vehicles)
            {
                if(item is not null)
                {
                    //if (vehicles.Contains(item))
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
