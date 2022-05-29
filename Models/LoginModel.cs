using System.ComponentModel.DataAnnotations;

namespace CRUDCORE.Models
{
    public class LoginModel
    {
        public int IdContacto { get; set; }

        [Required(ErrorMessage ="El campo Nombre es obligatorio")]
        public string? Nombre { get; set; }
        
        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        public string? Telefono { get; set; }



    }
}
