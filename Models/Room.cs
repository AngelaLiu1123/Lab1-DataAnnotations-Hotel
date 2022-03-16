using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab1_DataAnnotations_Hotel.Models
{
    public class Room
    {
        //PrimaryKey
        [Key]
        public string RoomNumber { get; set; }

        public int capacity { get; set; }

        public Section Section { get; set; }

        //[InverseProperty("PreviousRoomId")]
        //public int PreviousClientId { get; set; }

        
        public Client PreviousClient { get; set; }


        //[InverseProperty("CurrentRoomId")]
        //public int CurrentClientId { get; set; }

        
        public Client CurrentClient { get; set; }
    }

    public enum Section
    {
        [Display(Name = "First")]
        First,
        [Display(Name = "Second")]
        Second,
        [Display(Name = "Third")]
        Third
    }
}
