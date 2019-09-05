using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    [Table("TB_ANIMAL")]
    public class Animal
{
        public int AnimalId { get; set; }

        public string Nome { get; set; }

        public bool Carnivoro { get; set; }

        public TipoAnimal Tipo { get; set; }
    }
}
