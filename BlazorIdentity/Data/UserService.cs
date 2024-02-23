using Microsoft.EntityFrameworkCore;

namespace BlazorIdentity.Data
{
	public class UserService
	{
		private readonly ApplicationDbContext _context;

		public UserService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task UpdateUser(ApplicationUser user)
		{
			_context.Update(user);
			_context.SaveChanges();
		}

		public async Task<ApplicationUser> GetUserItemsInfo(ApplicationUser user)
		{
			return _context.Users.Include(u => u.Items).First(u => u.Id == user.Id);
		}
	}
}
