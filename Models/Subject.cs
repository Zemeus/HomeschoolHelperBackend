using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeschoolHelperApi.Models
{
    public class Subject
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCore { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public ICollection<Record> Records { get; set; }
     
 
    }
}