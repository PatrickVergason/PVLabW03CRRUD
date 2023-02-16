using PVLabW03CRRUD.Models.Entities;

namespace PVLabW03CRRUD.Services {
    public class DbPersonRepository : IPersonRepository {
        private readonly ApplicationDbContext _db;

        public DbPersonRepository(ApplicationDbContext db) {
            _db = db;
        }
        public Person Create(Person newPerson) {
            _db.People.Add(newPerson);
            _db.SaveChanges();
            return newPerson;
        }

        public void Delete(int id) {
            
        }

        public Person? Read(int id) {
            // select * from people where id = <<id>>;
            return _db.People.Find(id);
        }

        public ICollection<Person> ReadAll() {
            return _db.People.ToList();
        }

        public void Update(int oldId, Person person) {

        }
    }
}
