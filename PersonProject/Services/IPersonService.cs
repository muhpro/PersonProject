using PersonProject.Model;

namespace PersonProject.Services
{
    public interface IPersonService
    {
        List<PersonModel> GetPerson();
        PersonModel GetPersonById(int Id);
        PersonModel InsertPerson(PersonModel person);
    }
}