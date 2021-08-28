using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upwork.States.Dto
{
   public class StateListOutputDto : FullAuditedEntityDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
