using PersonProject.Model;

namespace PersonProject.Services
{
    public class PersonService : IPersonService
    {
        private List<PersonModel> persons;

        public PersonModel InsertPerson(PersonModel person)
        {
            persons.Add(person);
            return person;
        }

        public PersonModel GetPersonById(int Id)
        {
            var person = persons.Find(x => x.Id == Id);
            return person;

        }

        public List<PersonModel> GetPerson()
        {
            return persons;
        }
    }
}
