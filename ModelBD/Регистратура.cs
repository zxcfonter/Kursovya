namespace Регистратура_поликлиники.ModelBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Регистратура
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string ФИО { get; set; }

        [StringLength(50)]
        public string Врач { get; set; }

        [StringLength(50)]
        public string Кабинет { get; set; }

        [StringLength(50)]
        public string Время { get; set; }
    }
}
