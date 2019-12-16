
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    [Table("emp")]
    public class Employee
    {
        public int ID { get; set; }
        public string EmpName { get; set; }
        public decimal EmpSal { get; set; }
    }
}