﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class RootObject
    {

        public List<Search> Search { get; set; }

        //public Search[] Search { get; set; }

        public string totalResults { get; set; }
        public string Response { get; set; }


    }
}
