using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MockProjectTeam2.Core.Model
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        public enum RequestType
        {
            [Description("Late comming")] LateComing = 1,
            [Description("Early leave")] EarlyLeave = 2,
            [Description("Paid leave")] PaidLeave = 3
        }
        [Required(ErrorMessage = "The {0} must be required")]
        public string Reason { get; set; }
        public int ApprovedId { get; set; }
        public virtual ClassAdmin ClassAdmin { get; set; }
        public int TraineeId { get; set; }
        public virtual Trainee Trainee { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan CommingTime { get; set; }
        public TimeSpan LeaveTime { get; set; }
        
        public DateTime ExpextedApproval { get; set; }
        public DateTime ApprovedTime { get; set; }
        
        public enum Status {
            [Description("Save Draft")] SaveDraft = 1,
            Submit,
            Approve,
            Reject,
            Return,
            Cancel,
            Close
        }
        [StringLength(100, ErrorMessage = "The {0} must be between {1} and {2} characters", MinimumLength = 2)]
        [Column(TypeName = "varchar(100)")]
        public string AuditTrail { get; set; }
        [DefaultValue(false)]
        public Boolean IsDeleted { get; set; }
    }
}

