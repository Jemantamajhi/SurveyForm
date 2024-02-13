using Microsoft.EntityFrameworkCore;
using SurveyForm.Models;
using SurveyForm.Models.DbEntities;


namespace SurveyForm.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<People> people { get; set; }
        public object People { get; internal set; }
        public DbSet<State> state { get; set; }
        public DbSet<City> City { get; set; }

      
    }
}
