using BlazorIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorIdentity.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: IdentityDbContext<ApplicationUser>(options)
	{
		public DbSet<Item> Items { get; set; }
	}
}
