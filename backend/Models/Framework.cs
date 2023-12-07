using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Framework
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Level { get; set; } = "";
        public int Year { get; set; }
    }
}