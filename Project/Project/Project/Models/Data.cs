using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Models
{

    public class Data
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public Movie[] results { get; set; }
    }

}
