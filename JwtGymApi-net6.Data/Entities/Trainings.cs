using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JwtGymApi_net6.Data.Entities
{
    public class Training
    {
        public int Id { get; set; }
        public string Exercise { get; set; }
        //Type sera si es de Espalda, Pecho, Piernas, hombros, biceps, triceps. 
        //type exercise back, chest, legs, shoulders, biceps, triceps, abs 
        public string Type { get; set; }
        //explicacion del ejercicio
        [Column(TypeName = "Text")]
        public string Explanation { get; set; }
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }
        public string Video1 { get; set; }
        public string Video2 { get; set; }

        public ICollection<Exercises> Exercises { get; set; }


    }
}
