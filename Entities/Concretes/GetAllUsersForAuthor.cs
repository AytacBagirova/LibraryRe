﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    internal class GetAllUsersForAuthor
    {
        public int ID { get; set; }

        public string FIRSTNAME { get; set; }

        public string LASTNAME { get; set; }

        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
