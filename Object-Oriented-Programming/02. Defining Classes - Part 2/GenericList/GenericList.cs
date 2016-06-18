namespace GenericList
{
    using System;
    using System.Linq;

    class GenericList<T> where T : IComparable
    {
        private T[] list;

        public GenericList()
        {
            this.Capacity = 4;
            this.Counter = 0;
            this.list = new T[Capacity];
        }

        public int Capacity { get; set; }
        public int Counter { get; private set; }
        public T this[int index]
        {
            get
            {
                return this.list[index];
            }
            set
            {
                this.list[index] = value;
            }
        }

        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            this.Counter = 0;
            this.list = new T[capacity];
        }


        public void AddElement(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Invalid item value (null)");
            }
            GrowList(this.Capacity);

            this.list[Counter] = element;
            Counter++;
        }

        public T GetElementByIndex(int index)
        {
            if (index > this.Capacity || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return this.list[index];
        }

        public void RemoveElementByIndex(int index)
        {
            if (index > this.Capacity || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            while (index <= Capacity)
            {
                T temp = this.list[index];
                this.list[index] = this.list[index - 1];
                this.list[index - 1] = temp;
                index++;
            }
            Counter--;
        }

        public void InsertAt(int index, T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Invalid item value (null)");
            }
            if (index > this.Capacity || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            GrowList(this.Capacity);

            if (index > Counter)
            {
                this.list[index] = element;
                Counter++;
            }
            else
            {
                this.list[index] = element;
            }
        }

        public void ClearList()
        {
            this.list = new T[Capacity];
            Counter = 0;
        }

        public T FindElement(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Invalid item value (null)");
            }

            for (int i = 0; i < this.list.Count(); i++)
            {
                if (this.list[i].ToString() == element.ToString())
                {
                    return this.list[i];
                }
            }

            return default(T);
        }

        private void GrowList(int capacity)
        {
            if (this.Counter >= capacity)
            {
                this.Capacity *= 2;
                T[] tempArray = new T[this.Capacity];
                Array.Copy(list, 0, tempArray, 0, list.Length);
                list = tempArray;
            }
        }

        public T Min<T>() where T : IComparable<T>
        {
            dynamic min = list[0];
            for (int i = 1; i < this.list.Length; i++)
            {
                if (this.list[i].CompareTo(min) >= 0)
                {
                    min = this.list[i];
                }
            }
            return min;
        }

        public T Max<T>() where T : IComparable<T>
        {
            dynamic max = list[0];
            for (int i = 1; i < this.list.Length; i++)
            {
                if (this.list[i].CompareTo(max) <= 0)
                {
                    max = this.list[i];
                }
            }
            return max;
        }


        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < this.Capacity; i++)
            {
                result += this.list[i].ToString() + " ";
            }

            return result;
        }

    }
}
