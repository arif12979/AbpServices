using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upwork.States.Dto;

namespace Upwork.Countries.Dto
{
    [AutoMapFrom(typeof(Country))]
    public class CountryListOutputDto : FullAuditedEntityDto
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string Currency { get; set; }
        public List<StateListOutputDto> States { get; set; }
    }
}
