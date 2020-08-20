using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockProjectTeam2.Core.Model
{
    public class Trainer
    {
        [Key]
        public int TrainerId { get; set; }
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
        [Required(ErrorMessage = "The {0} must be required")]
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 2)]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }
        [Required(ErrorMessage = "The {0} must be required")]
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 2)]
        [Column(TypeName = "varchar(100)")]
        public string Account { get; set; }
        enum Status
        {
            [Description("New")] New = 1,
            [Description("Wait for class")] WaitForClass = 2,
            [Description("Teaching")] Teaching = 3
        }
        [Required(ErrorMessage = "The {0} must be required")]
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 2)]
        [Column(TypeName = "varchar(100)")]
        public string Type { get; set; }
        [Required(ErrorMessage = "The {0} must be required")]
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 2)]
        [Column(TypeName = "varchar(100)")]
        public string Unit { get; set; }
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 2)]
        [Column(TypeName = "varchar(100)")]
        public string Major { get; set; }
        [Required(ErrorMessage = "The {0} must be required")]
        [Column(TypeName = "INT(50)")]
        public int Experience { get; set; }
        [StringLength(255, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 3)]
        [Column(TypeName = "nvarchar(255)")]
        public string Remarks { get; set; }
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 2)]
        [Column(TypeName = "varchar(100)")]
        public string AuditTrail { get; set; }
        [DefaultValue(false)]
        public Boolean IsDeleted { get; set; }
        public virtual ICollection<ClassBatch> ClassBatchs { get; set; }
    }
}
