using System.ComponentModel.DataAnnotations;

namespace CRUDCORE.Models
{
    public class CineModel
    {
        public int ID{ get; set; }

        [Required(ErrorMessage ="El campo Titulo es obligatorio")]
        public string? Titulo{ get; set; }
        
        [Required(ErrorMessage = "El campo Comentario es obligatorio")]
        public string? Comentario { get; set; }

        [Required(ErrorMessage = "El campo Imagen es obligatorio")]
        public string? Imagen { get; set; }

        [Required(ErrorMessage ="El campo Fecha es obligatorio")]
        public string? Fecha{ get; set; }

        [Required(ErrorMessage = "El campo Director es obligatorio")]
        public string? Director { get; set; }

        [Required(ErrorMessage = "El campo Guion es obligatorio")]
        public string? Guion { get; set; }

        [Required(ErrorMessage ="El campo Sinopsis es obligatorio")]
        public string? Sinopsis{ get; set; }

        [Required(ErrorMessage = "El campo Trailer es obligatorio")]
        public string? Trailer { get; set; }

        [Required(ErrorMessage = "El campo Categoria es obligatorio")]
        public string? Categoria { get; set; }

    }
}
