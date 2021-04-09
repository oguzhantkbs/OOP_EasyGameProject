using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGameProjectOOP.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CompaignName { get; set; }
        public decimal CampaignPrice { get; set; }
    }
}
