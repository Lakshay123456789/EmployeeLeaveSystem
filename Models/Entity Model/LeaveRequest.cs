using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entity_Model
{
    public enum LeaveType
    {
        Privilege_Leave=1,
        Earned_Leave,
        Casual_Leave,
        Sick_Leave,
        Maternity_Leave,
        Compensatory_Off,
        Marriage_Leave,
        Paternity_Leave,
        Bereavement_Leave,
        Loss_of_Pay,
        Leave_Without_Pay,
        Other

    }
    public enum Status
    {
        Pending,
        Approved,
        Rejected
    }
    public class LeaveRequest
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public LeaveType Type { get; set; }

        [Required]
        public Status Status { get; set; }

        public string ? Description { get ; set; }

        [Required]
        public DateTime? StartDate { get; set; }

        [Required]
        public DateTime? EndDate { get; set;}

        [ForeignKey("Employee")]

        public Guid EmployeeId { get;set; }
    }
}
