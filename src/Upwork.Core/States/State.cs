using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upwork.Countries;

namespace Upwork.States
{
    [Table("States")]
    public class State: FullAuditedEntity
    {
        //[Key]
        //public int Id { get; set; }
        [Key]
        [Required]
        [MaxLength(20)]
        public string Name  { get; set; }
        [MaxLength(100)]
        public string Description  { get; set; }
        [Required]
        public int CountryId { get; set; }
        public Country Country { get; set; }

    }
}
