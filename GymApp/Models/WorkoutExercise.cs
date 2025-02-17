namespace GymApp.Models
{
    public class WorkoutExercise // Many to many realtionship between Workout and Exercise
    {
        public int Id { get; set; }
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public float Weight { get; set; } // In kg/lbs
    }
}
