﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Entities
{
    public class Sales
    {
        public virtual int Id { get; set; }
        public virtual Products ProductId { get; set; }
        public virtual Customer CustomerId { get; set; }
        public virtual Employee EmployeeId { get; set; }
        public virtual DateTime Date {  get; set; }
        public virtual int Piece { get; set; }
    }
}