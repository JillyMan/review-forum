using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Models.Create
{
    public class RateCreateModel
    {
        public int ThingId { get; set; }

        public float Rate { get; set; }
    }
}
