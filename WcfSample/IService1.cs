using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfSample
{
    [ServiceContract]
   public interface IService1
    {
        [OperationContract]
        IEnumerable<Person> GetPersons();
        [OperationContract]
        void InsertPerson(Person personObject);
        [OperationContract]
        void UpdatePerson(Person personObject);
        [OperationContract]
        void DeletePerson(int Id);
    }
    [DataContract]
    public class Person
    {
        [DataMember]
        [Required]
        [Key]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string Name { get; set; }
        [DataMember]
        [Required]
        public string Address { get; set; }
    }
}
