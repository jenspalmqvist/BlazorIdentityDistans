namespace BlazorIdentity.Models
{
    public class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public ApplicationUser User { get; set; }
	}
}
