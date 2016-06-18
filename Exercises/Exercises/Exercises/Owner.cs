using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsSystem
{
    public class Owner
    {
        string firstName;
        string lastName;
        private List<Cat> cats;

        public Owner(string first, string last)
        {
            this.firstName = first;
            this.lastName = last;
            this.Age = 0;
            this.cats = new List<Cat>();
        }


        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.firstName;
            }
        }

        public int Age { get; private set; }

        public string AllCats
        {
            get
            {
                return string.Join(", ", this.cats.Select(c => c.Name));
            }
        }

        public void IncreaseAge()
        {
            this.Age++;
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.firstName, this.lastName);
            }
        }

        public void AddCat(Cat cat, string name)
        {
            if (this.cats.Contains(cat))
            {
                throw new AggregateException("This owner already owns this cat " + cat.Name);
            }
            cat.Name = name;
            cat.Owner = this;
            this.cats.Add(cat);
        }


    }
}
