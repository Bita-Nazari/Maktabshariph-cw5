using maktab_cw5.Entities;
using maktab_cw5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public List <person> getByNameStartChar(char firstchar) 
        {
            return PeopleList.people.FindAll(x => x.Name.StartsWith(firstchar));

        }
        public List<string>getInvalidEmail() 
        {

            return PeopleList.people.FindAll(x => checkEmail (x.EmailAddress)).Select(x=> x.EmailAddress).ToList();
        }

        private bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }
    }
}
