using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccess.Models
{
    public class Title
    {
        public int Id { get; set; }
        [StringLength(80)]
        public string name { get; set; }
        [StringLength(300)]
        public string description { get; set; }
        public DateTime? releaseDate { get; set; }
        public bool released { get;set; } = true;
        [StringLength(80)]
        public string developer { get;set; }
        [StringLength(120)]
        public string platforms { get; set; }



    }
}
