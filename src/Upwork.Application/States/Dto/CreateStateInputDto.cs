using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upwork.States.Dto;

namespace Upwork.States.Dto
{
   public class CreateStateInputDto : FullAuditedEntityDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CountryId { get; set; }
       // public String CountryName { get; set; }
    }
}
