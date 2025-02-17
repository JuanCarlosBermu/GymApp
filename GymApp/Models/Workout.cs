namespace GymApp.Models
{
    public class Workout //Tracks workouts sessions
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
