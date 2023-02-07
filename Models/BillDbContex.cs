using Microsoft.EntityFrameworkCore;

namespace MassBill.Models
{
    public class BillDbContex :DbContext
    {
        public BillDbContex(DbContextOptions<BillDbContex> options) : base(options) 
        { }

        public DbSet<Bill> Bills { get; set;}
    }
}
