using System.ComponentModel.DataAnnotations;

namespace Clase_Layouts_PartialView_Validaciones.Models
{
    public class Usuario
    {
        [Required(ErrorMessage ="El nombre es requerido")]
        public string Nombre { get; set; }
        [Url(ErrorMessage = "El AvatarURL debe ser al menos de 7 caracteres")]
        [Required(ErrorMessage = "El AvatarURL es requerido")]

        public string AvatarURL { get; set; }
        public string Email { get; set; }
        [Range(1,10000,ErrorMessage = "Puntos debe ser un valor entre 1 y 10000")]

        [Required(ErrorMessage = "Puntos es requerido")]

        public int Puntos { get; set; }

    }
}
