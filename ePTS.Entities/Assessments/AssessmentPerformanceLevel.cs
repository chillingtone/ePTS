using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ePTS.Entities.Assessments
{
    [Table("AssessmentPerformanceLevel")]
    public class AssessmentPerformanceLevel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "The {0} field is required.")]
        [Display(Name = "Assessment Performance Level")]
        [Comment("Unique identifier for each assessment performance level record in the table")]
        [Column(Order = 1)]
        public Guid AssessmentPerformanceLevelId { get; set; }

        [Display(Name = "Gradebook Assessment", Prompt = "Select the gradebook assessment")]
        [Comment("Reference to the gradebook assessment to which the assessment performance level belongs to. This is a foreign key that references the GradebookAssessment table")]
        [Column(Order = 2)]
        public Guid? GradebookAssessmentId { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [Display(Name = "Registration Date", Prompt = "Enter the registration date")]
        [Comment("Date on which the assessment performance level was registered or added to the database")]
        [Column(Order = 3)]
        public DateTime RegistrationDate { get; set; }

        [Display(Name = "Performance Level")]
        [Comment("A reference to the performance level of an assessment, such as minimum, desirable, or outstanding. This is a foreign key that references the RefPerformanceLevel table")]
        [Column(Order = 4)]
        public int? RefPerformanceLevelId { get; set; }

        [Display(Name = "Sex", Prompt = "Select the sex")]
        [Comment("A reference to the sex of a learner or teacher, such as male, or female. This is a foreign key that references the RefSex table")]
        [Column(Order = 5)]
        public int? RefSexId { get; set; }

        [Display(Name = "Possible Value", Prompt = "Enter the possible value")]
        [Column(Order = 6)]
        public int PossibleValue { get; set; }

        [Display(Name = "Score Value", Prompt = "Enter the score value")]
        [Column(Order = 7)]
        public int ScoreValue { get; set; }

        [Display(Name = "Assessment Result Data Type", Prompt = "Select the assessment result data type")]
        [Comment("A reference to the data type of the assessment result score value. This is a foreign key that references the RefAssessmentResultDataType table")]
        [Column(Order = 8)]
        public int? RefAssessmentResultDataTypeId { get; set; }

        [Display(Name = "Score Metric Type", Prompt = "Select the score metric type")]
        [Comment("The specific method used to report the performance and achievement of the assessment.")]
        [Column(Order = 9)]
        public int? RefScoreMetricTypeId { get; set; }


    }
}

