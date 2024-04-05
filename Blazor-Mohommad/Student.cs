using System.ComponentModel.DataAnnotations;
using Blazor_Mohommad;


namespace Blazor_Mohommad
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string? Name { get; set; }

        [Required]      
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
    }
}