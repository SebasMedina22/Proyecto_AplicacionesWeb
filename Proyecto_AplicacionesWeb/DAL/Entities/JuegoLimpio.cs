using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Proyecto_AplicacionesWeb.DAL.Entities
{
    public class JuegoLimpio:AuditBase
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Hotel")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string Name { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
        public int? Phone { get; set; }
        public int Stars { get; set; }
    }
}
