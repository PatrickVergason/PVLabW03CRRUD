using PVLabW03CRRUD.Models.Entities;

namespace PVLabW03CRRUD.Services {
    public interface IPersonRepository {
        Person Create(Person newPerson);
        Person? Read(int id);
        ICollection<Person> ReadAll();
        void Update(int oldId, Person person);
        void Delete(int id);
    }
}
