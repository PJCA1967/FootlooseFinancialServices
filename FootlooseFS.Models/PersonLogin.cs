﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootlooseFS.Models
{
    public class PersonLogin
    {
        public int PersonID { get; set; }
        public String LoginID { get; set; }
        public String Password { get; set; }

        public virtual Person Person { get; set; }
    }
}
