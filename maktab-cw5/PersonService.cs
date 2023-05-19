using maktab_cw5.Entities;
using maktab_cw5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maktab_cw5
{
    public class PersonService
    {
        public List<person> getFemalByAge(int age) 
        {
        return PeopleList.people.FindAll(x => x.Age >= age);
        }
        public List<person> getRipoSortedByAge() 
        {
        return PeopleList.people.OrderBy(person => person.Age).ToList();
        }
        public List<string>getRipoByCity(string city) 
        {
        return PeopleList.people.FindAll(person => person.City == city).Select(person => person.Name +  person.LastName).ToList();
        
        }
    }
}
