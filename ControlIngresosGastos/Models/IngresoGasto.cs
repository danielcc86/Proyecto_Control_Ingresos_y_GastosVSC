﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlIngresosGastos.Models
{
    public class IngresoGasto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        [Required]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        [Required]
        [Range(1,10000000)]
        [DisplayFormat(DataFormatString ="{0:C}")]
        [Display(Name ="Valor")]
        public double Valor { get; set; }
    }
}
