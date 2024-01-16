namespace CostumersApi.Models
{
    public class Reservation
    {
       public int Id { get; set; }  
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int VeicleId {  get; set; }
        public Vehicle vehicle { get; set; }
    }
}
