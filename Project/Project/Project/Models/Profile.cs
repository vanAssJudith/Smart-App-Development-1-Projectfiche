using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Models
{
    public class Profile
    {
        public string Title { get; set; }
        public string IconSource { get; set; }
        public Type TargetType { get; set; }
        public float Rating { get; set; }
    }
}
