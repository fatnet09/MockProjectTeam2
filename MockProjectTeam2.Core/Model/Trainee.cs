using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MockProjectTeam2.Core.Model
{
    public class Trainee
    {
        [Key]
        public int TraineeId { get; set; }
        [Required(ErrorMessage = "The {0} must be required")]
        [StringLength(255, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 3)]
        [Column(TypeName = "nvarchar(255)")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "The {0} must be required")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "The {0} must be required")]
        public Boolean Gender { get; set; }

        [Required(ErrorMessage = "The {0} must be required")]
        [StringLength(11, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 9)]
        [Column(TypeName = "varchar(11)")]
        public string PhoneNumber { get; set; }
        [StringLength(11, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 9)]
        [Column(TypeName = "varchar(11)")]
        public string FamillyPhoneNumber { get; set; }
        [Required(ErrorMessage = "The {0} must be required")]
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 2)]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 2)]
        [Column(TypeName = "varchar(100)")]
        public string ExternalEmail { get; set; }
        [Required(ErrorMessage = "The {0} must be required")]
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 2)]
        [Column(TypeName = "varchar(100)")]
        public string Account { get; set; }
        public DateTime OnboardDate { get; set; }

        enum Status
        {
            [Description("New")] New = 1,
            [Description("Wait for class")] WaitForClass = 2,
            [Description("Enrolled")] Teaching = 3
        }

        [StringLength(255, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 3)]
        [Column(TypeName = "nvarchar(255)")]
        public string Remarks { get; set; }

        [StringLength(255, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 3)]
        [Column(TypeName = "nvarchar(255)")]
        public string University { get; set; }
        [StringLength(255, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 3)]
        [Column(TypeName = "nvarchar(255)")]
        public string Faculty { get; set; }
        [StringLength(255, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 3)]
        [Column(TypeName = "varchar(255)")]
        public string Skill { get; set; }
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 3)]
        [Column(TypeName = "varchar(100)")]
        public string ForeignLanguage { get; set; }
        // range level ???
        public int Level { get; set; }
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 3)]
        [Column(TypeName = "varchar(100)")]
        public string CV { get; set; }
        // Data type Enum ???
        public string AllocationStatus { get; set; }
        public int ClassBatchId { get; set; }
        public virtual ClassBatch ClassBatch { get; set; }
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 2)]
        [Column(TypeName = "varchar(100)")]
        public string AuditTrail { get; set; }
        [DefaultValue(false)]
        public Boolean IsDeleted { get; set; } 
    }
}
