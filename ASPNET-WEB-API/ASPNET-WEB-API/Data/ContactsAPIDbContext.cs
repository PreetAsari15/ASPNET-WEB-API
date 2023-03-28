using ASPNET_WEB_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNET_WEB_API.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts{ get; set; }
    }
}
