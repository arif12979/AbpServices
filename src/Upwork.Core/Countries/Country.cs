using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upwork.States;

namespace Upwork.Countries
{
    [Table("Countries")]

    public class Country : FullAuditedEntity
    {

        //[Key]
        //public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MaxLength(5)]
        public int Code { get; set; }
        [Required]
        [MaxLength(10)]
        public string Currency { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}
