using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace HospitalManagement.Models
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Speciality { get; set; }
        public string Qualification { get; set; }
        public string DoctorUserName { get; set; }
        public string DoctorPassword { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
 
    }
}
