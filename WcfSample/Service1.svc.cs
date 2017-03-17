using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfSample
{   
    public class Service1 : IService1
    {
        public void DeletePerson(int Id)
        {
            PersonContext po = new PersonContext();
            var c = (from per in po.Persons
                     where per.Id == Id
                     select per).First();
            po.Persons.Remove(c);
            po.SaveChanges();
        }

        public IEnumerable<Person> GetPersons()
        {
            List<Person> li = new List<Person>();
            PersonContext po = new PersonContext();
            li= po.Persons.ToList();
            return li;
        }

        public void InsertPerson(Person personObject)
        {
            PersonContext po = new PersonContext();
            po.Persons.Add(personObject);
            po.SaveChanges();
        }

        public void UpdatePerson(Person personObject)
        {
            PersonContext po = new PersonContext();
            var c = (from per in po.Persons
                     where per.Id == personObject.Id
                     select per).First();
            c.Name = personObject.Name;
            c.Address = personObject.Address;
            po.SaveChanges();
        }
    }
}
