namespace Lecture_12
{
    internal class Program
    {
        public class Exercise
        { 
        
            // Public fields for the Exercise class
            public string Name;
            public int Reps;
            public double Weight;

            // Default Constructor
            public Exercise()
            {
                Name = "No Exercise";
                Reps = -1;
                Weight = -1;
            }

            // Constructor with 3 Parameters
            public Exercise(string name, int reps, double weight)
            {
                Name = name;
                Reps = reps;
                Weight = weight;
            }
        }

        class Program1
        {
            static void Main(string[] args)
            {
                // Create an array of Exercise with a size of 5
                Exercise[] exercises = new Exercise[5];

                // Populate the array with Exercise instances
                exercises[0] = new Exercise("Bench Press", 10, 135);
                exercises[1] = new Exercise("Squat", 15, 225);
                exercises[2] = new Exercise("Deadlift", 12, 275);
                exercises[3] = new Exercise("Overhead Press", 8, 95);
                exercises[4] = new Exercise("Barbell Row", 10, 115);

                // Display all exercises
                DisplayAllExercises(exercises);
            }

            // Method to display a single exercise
            static void DisplayExercise(Exercise exercise)
            {
                Console.WriteLine($"{exercise.Name} | {exercise.Reps} | {exercise.Weight}");
            }

            // Method to display all exercises
            static void DisplayAllExercises(Exercise[] exercises)
            {
                Console.WriteLine("Name | Reps | Weight");
                Console.WriteLine("--------------------");
                foreach (Exercise exercise in exercises)
                {
                    DisplayExercise(exercise);
                }
            }
        }
    }
}