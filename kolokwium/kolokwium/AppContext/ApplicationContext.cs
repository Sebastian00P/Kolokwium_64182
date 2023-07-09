using Microsoft.EntityFrameworkCore;

namespace kolokwium.AppContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :base(options)
        { 

        }
    }
}
