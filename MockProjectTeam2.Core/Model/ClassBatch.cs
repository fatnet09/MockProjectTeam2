using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MockProjectTeam2.Core.Model
{
    public class ClassBatch
    {
        [Key]
        public int ClassId { get; set; }
        [Required(ErrorMessage = "The {0} must be required")]
        [StringLength(255, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 3)]
        [Column(TypeName = "varchar(255)")]
        public string ClassName  { get; set; }
        [Required(ErrorMessage = "The {0} must be required")]
        [StringLength(255, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 3)]
        [Column(TypeName = "varchar(255)")]
        public string ClassCode { get; set; }
        [Required(ErrorMessage = "The {0} must be required")]
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 3)]
        [Column(TypeName = "varchar(100)")]
        public string GroupEmail { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public enum Location {
            [Description("Hà Nội")] HaNoi = 1,
            [Description("Hòa Lạc")] HoaLac = 2,
            [Description("Thành Công")] ThanhCong = 3,
            [Description("Cầu Giấy")] CauGiay = 4,
            [Description("Keangnam")] Keangnam = 5
        }
        [Required(ErrorMessage = "The {0} must be required")]
        [StringLength(255, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 3)]
        [Column(TypeName = "nvarchar(255)")]
        public string DetailLocation { get; set; }
        public int ClassAdminId { get; set; }
        public virtual ICollection<ClassAdmin> ClassAdmins { get; set; }
        public int TrainerId { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
        enum Status
        {
            [Description("Plan")] New = 1,
            [Description("Start")] Start = 2,
            [Description("In Progress")] InProgress = 3,
            [Description("Finish")] Finish = 4,
            [Description("Close")] Close = 5,
            [Description("Waiting for more information")] Wait = 5,
            [Description("Pending for review")] Pending = 6,
            [Description("Rejected")] Rejected = 7,
            [Description("Declined")] Declined = 8,
            [Description("Draft")] Draft = 9

        }
        [StringLength(255, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 3)]
        [Column(TypeName = "nvarchar(255)")]
        public string Remarks { get; set; }
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 2)]
        [Column(TypeName = "varchar(100)")]
        public string AuditTrail { get; set; }
        [DefaultValue(false)]
        public Boolean IsDeleted { get; set; }
        
    }
}