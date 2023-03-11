using Microsoft.EntityFrameworkCore;

namespace Assessment6c.Models
{
    public class Planet
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public int Order { get; set; }

        public DbSet<Planet> Planets { get; set; }

        internal static object OrderBy(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
    
    

}

