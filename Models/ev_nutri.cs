//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CyS___DeportesConcepcioin_v2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ev_nutri
    {
        public int id_calc_grasa { get; set; }
        public double peso { get; set; }
        public double talla_estatura { get; set; }
        public double porcent_masa_adiposa { get; set; }
        public double kilo_masa_adiposa { get; set; }
        public int estado_uno { get; set; }
        public int estado_uno_dos { get; set; }
        public double porcent_musculo { get; set; }
        public double kilo_musculo { get; set; }
        public int estado_dos { get; set; }
        public int estado_dos_dos { get; set; }
        public double sumatoria_pliegue { get; set; }
        public int estado_tres { get; set; }
        public double imo { get; set; }
        public int estado_cuatro { get; set; }
        public int nutricionista_id_nutri { get; set; }
        public int futbolista_id_futbolista { get; set; }
    
        public virtual futbolista futbolista { get; set; }
        public virtual nutricionista nutricionista { get; set; }
    }
}
