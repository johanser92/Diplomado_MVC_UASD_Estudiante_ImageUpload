//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace Diplomado_MVC_UASD_Estudiante_ImageUpload
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEstudiante
    {
        
        public int EstudianteId { get; set; }

        [Required(ErrorMessage = "El Nombre es Obligatorio")]
        [MinLength(3, ErrorMessage = "El nombre del estudiante debe tener al menos 3 caracteres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El Apellido es Obligatorio")]
        [MinLength(5, ErrorMessage = "El Apellido del estudiante debe tener al menos 5 caracteres")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "La Direccion es Obligatorio")]
        [MinLength(6, ErrorMessage = "La Direccion del estudiante debe tener al menos 6 caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage ="Debes ingresar un numero de telefono valido")]
        [Phone(ErrorMessage = "Debe ingrsar un telefono valido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La cedula es Obligatoria")]
        [MinLength(11, ErrorMessage = "Ingrese una cedula valida")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "La imagen es Obligatoria")]
        
        public string ImageUrl { get; set; }
    }
}
