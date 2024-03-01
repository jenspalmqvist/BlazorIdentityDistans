using Microsoft.AspNetCore.Identity;

namespace BlazorIdentity.Models
{
	// Add profile data for application users by adding properties to the ApplicationUser class
	public class ApplicationUser : IdentityUser
	{
		public ICollection<Item> Items { get; set; } = new List<Item>();
	}

}
