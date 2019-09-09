﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.App.AspNet.Models
{
    [Table("TB_PRODUTO")]
    public class Corrida
    {

        public int CorridaId { get; set; }
        public string Nome { get; set; }

        public float distancia { get; set; }

        public bool Premiacao { get; set; }

        public Categoria Categoria { get; set; }
    }
}
