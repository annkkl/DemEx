namespace Dem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drivers
    {
        [Key]
        public int ID_Driver { get; set; }

        [StringLength(20)]
        public string Middlename { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Patronymic { get; set; }

        public int? PassportSerial { get; set; }

        public int? PassportNumber { get; set; }

        [StringLength(30)]
        public string Address { get; set; }

        [StringLength(10)]
        public string AddressLife { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        [StringLength(40)]
        public string Jobname { get; set; }

        [StringLength(19)]
        public string Phone { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(30)]
        public string Photo { get; set; }
    }
}
