using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upwork.States.Dto;

namespace Upwork.Countries.Dto
{
   public class CreateCountryInputDto : FullAuditedEntityDto
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string Currency { get; set; }
        public List<StateListOutputDto> States { get; set; }
    }
}
