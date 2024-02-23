using BlazorIdentity.Models;
using Microsoft.AspNetCore.Identity;

namespace BlazorIdentity.Data
{
	// Add profile data for application users by adding properties to the ApplicationUser class
	public class ApplicationUser : IdentityUser
	{
		public ICollection<Models.Item> Items { get; set; } = new List<Item>();
	}

}
