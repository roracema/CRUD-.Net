using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    [Table("TB_ZOO")]
    public class Zoo
    {
        
        [Column("Id"), HiddenInput]
        public int ZooId { get; set; }
        public int Jaulas { get; set; }

        [Required, DataType(DataType.Date),Display(Name ="Data Abertura")]
        public DateTime DataAbertura { get; set; }

        [Required, MaxLength(50)]
        public string Nome { get; set; }

        [Display(Name = "Tipo")]
        public Tipo EntidadeAdministradora { get; set; }
    }
}
