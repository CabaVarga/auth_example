using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T7_P2_1.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }

        [JsonIgnore]
        public virtual ICollection<Student> Students { get; set; }
    }
}