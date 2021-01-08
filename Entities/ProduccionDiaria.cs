using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Consensus.Entities
{
    public class ProduccionDiaria
    {
        [Key]
        public int idProd { get; set; }
        [Required]
        public int cuadradoQty { get; set; }
        public int rectanguloQty { get; set; }
        public int trianguloQty { get; set; }
        public int circuloQty { get; set; }
        public int produccionGenerada { get; set; }
        public DateTime fechaProd { get; set; }
    }
}
