﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public string ColourName { get; set; }
        public short ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
