using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTutorial.Models.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; } 


        // pangcreate ng foreign key ni student sa address
        public StudentAddress StudentAddress { get; set; }

       

        [NotMapped]
        public string NotMappedColumn {  get; set; }
    }
}
