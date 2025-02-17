using Microsoft.EntityFrameworkCore;

namespace GymApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Workout> Workouts { get; set; }
        public DbSet<Models.WorkoutExercise> WorkoutExercises { get; set; }
        public DbSet<Models.Exercise> Exercises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Models.WorkoutExercise>()
                .HasKey(we => new { we.WorkoutId, we.ExerciseId });
        }
    }
}
