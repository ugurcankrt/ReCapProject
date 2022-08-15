using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTos
{
    public class CarDetailDto:IDto
    {
        public int Id { get; set; }

        public string BrandName { get; set; }

        public int ModelYear { get; set; }

        public string Description { get; set; }

    }
}
