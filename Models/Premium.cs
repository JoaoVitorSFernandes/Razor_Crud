using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppCrud.Models;

public class Premium
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o titulo do premium")]
    [StringLength(80, ErrorMessage = "O nome deve conter até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O nome deve conter no minimo 5 caracteres")]
    [DisplayName("Title")]
    public string Title { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayName("Inicio")]
    public DateTime StarDate { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayName("Termino")]
    public DateTime EndDate { get; set; }

    [Required(ErrorMessage = "Aluno inválido")]
    [DisplayName("Aluno")]
    public int StudentId { get; set; }
    public Student? Student { get; set; }
}