﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public int RentId { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public DateTime RentDate { get; set; } = DateTime.Now;
        public DateTime? ReturnDate { get; set; } = null;
    }
}
