using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoWebApp.Models
{
    // Main class for Todo app
    public class Todo
    {
        private IDictionary<string, double> pointsDictionary = new Dictionary<string, double>();

        public Todo()
        {
            // Populate category list
            pointsDictionary.Add("Self Development", 3);
            pointsDictionary.Add("Yoga", 3);
            pointsDictionary.Add("Microsoft", 2);
            pointsDictionary.Add("Cardio", 1); // 1 mile = 1 point
            pointsDictionary.Add("Nano", 0.25);
            pointsDictionary.Add("Tennis Sessions", 1);
            pointsDictionary.Add("Tennis Swings", 0.50);
            pointsDictionary.Add("Weekly Analysis", 3);
            pointsDictionary.Add("Weekly Plan", 1);
            pointsDictionary.Add("Daily Plan", 1);
        }

        public int ID { get; set; }

        [Required]
        [StringLength(45, MinimumLength = 3)]
        public string Subject { get; set; }

        [Required]
        [StringLength(45, MinimumLength = 3)]
        public string Category { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(30, MinimumLength = 4)]
        public string Goal { get; set; }

        // TODO: Check if this can be removed since this is a weekly goal
        public DateTime DueDate { get; set; }

        public int PlannedSessions { get; set; }
        public int ExecutedSessions { get; set; }

        private decimal percentageAccomplished = 0;
        public decimal PercentageAccomplished
        {
            get => percentageAccomplished = (100 * ExecutedSessions) / (decimal)PlannedSessions;
        }

        private double points = 0;
        public double Points
        {
            get => points;
            set => points = pointsDictionary[Subject];
        }

        public string Comments { get; set; }
    }
}
