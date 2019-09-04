using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
       private List<Person> listPerson = new List<Person>();

        public void AddMember(Person member)
        {
            this.listPerson.Add(member);

        }
        public Person GetOldestMember()
        {
            return this.listPerson.OrderByDescending(x => x.Age).FirstOrDefault();
        }
        public List<Person> OlderThan30()
        {
            return this.listPerson.Where(x=>x.Age > 30).ToList();
        }
    }
}
