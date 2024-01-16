using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservationApi.Models
{
    public class Reservation
    {
        public int Id { get; set; }
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClientId { get; set; }  
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int VeicleId {  get; set; }
        public Vehicle vehicle { get; set; }
    }
}
