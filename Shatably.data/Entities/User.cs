using Microsoft.AspNetCore.Identity;


namespace Shatably.data.Entities
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }

        public string Phone { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }
}






