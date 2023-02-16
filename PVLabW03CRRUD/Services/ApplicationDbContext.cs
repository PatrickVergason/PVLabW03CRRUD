using Microsoft.EntityFrameworkCore;
using PVLabW03CRRUD.Models.Entities;

namespace PVLabW03CRRUD.Services {
	public class ApplicationDbContext : DbContext {
		public DbSet<Person> People => Set<Person>();

		public ApplicationDbContext(DbContextOptions options) : base(options) {

		}
	}
}
