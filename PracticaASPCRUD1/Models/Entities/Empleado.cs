using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaASPCRUD1.Models.Entities
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }
        [Column("NombreEmpleado", TypeName = "nvarchar(50)")]
        [Required(ErrorMessage ="El nombre es requerido")]
        public String Nombre { get; set; }
        public int Documento { get; set; }
        public int CargoId { get; set; }
        public String Telefono { get; set; }



    }
}
