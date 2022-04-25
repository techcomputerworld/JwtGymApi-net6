using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace JwtGymApi_net6.Data.Entities
{
    public class Technicians
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        [Column("Text")]
        public string Bio { get; set; }
        public string Email { get; set; }
        public string Nif { get; set; }
        public ICollection<Exercises> Exercises { get; set; }


    }
}
