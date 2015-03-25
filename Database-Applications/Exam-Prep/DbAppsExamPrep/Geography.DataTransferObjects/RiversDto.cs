﻿
namespace Geography.DataTransferObjects
{
    using System;
    using System.Collections.Generic;

    using Geography.Data;

    public class RiversDto
    {
        private IEnumerable<string> countries;

        public RiversDto()
        {
            this.countries = new HashSet<string>();
        }

        public string RiverName { get; set; }

        public int RiverLength { get; set; }

        public virtual IEnumerable<string> Countries
        {
            get
            {
                return this.countries;
            }

            set
            {
                this.countries = value;
            }
        }
    }
}
