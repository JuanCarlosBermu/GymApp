namespace GymApp.Models
{
    public class User // For storing user information
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public ICollection<Workout> Workouts { get; set; }

    }
}
