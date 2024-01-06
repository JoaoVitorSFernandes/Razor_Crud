using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppCrud.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(80, ErrorMessage = "O nome deve conter até 80 caracteres")]
        [MinLength(5, ErrorMessage = "O nome deve conter no minimo 5 caracteres")]
        [DisplayName("Nome completo: ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe o email")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        [DisplayName("Email")]
        public string Email { get; set; }


        public List<Premium> Premiums { get; set; } = new();
    }
}

