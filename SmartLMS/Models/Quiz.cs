using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartLMS.Models
{
    public class Quiz
    {
        [Key]
        [Required]
        public int QuizId { get; set; }
        [Required]
        public string QuizName { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        [Required]
        public DateTime? StartTime { get; set; }
        [Required]
        public TimeSpan? Duration { get; set; }
        [Required]
        public DateTime? EndTime { get; set; }
        [Required]
        public int Score { get; set; }

        public ICollection<Question> Question { get; set; }
        public ICollection<StudentQuiz> Students { get; set; }
    }
}