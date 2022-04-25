namespace JwtGymApi_net6.Data.Entities
{
    public class Exercises
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TrainingId { get; set; }
        public int TechnicianId { get; set; }
        public Training trainings { get; set; }
        public User users { get; set; }
        public Technicians technician { get; set; }
        //public string TrainingJob { get; set; }
        //[Column(TypeName = "Text")]
        //public string Explanation { get; set; }


    }
}
