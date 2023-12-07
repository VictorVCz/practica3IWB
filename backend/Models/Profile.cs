using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Lastname { get; set; } = "";
        public string Email { get; set; } = "";
        public string City { get; set; } = "";
        public string Country { get; set; } = "";
        public string Summary { get; set; } = "";
        public List<Framework> Frameworks { get; set; } = new List<Framework>();
        public List<Hobby> Hobbies { get; set; } = new List<Hobby>();

    }
}