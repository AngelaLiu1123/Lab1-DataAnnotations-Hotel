using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab1_DataAnnotations_Hotel.Models
{
    public class Client
    {
        public int Id { get; set; }

        [StringLength(25, MinimumLength =3, ErrorMessage = "The minimum length is 3 and maximum is 25 characters.")]
        [Column(TypeName = "nvarchar(50)")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "The minimum length is 3 and maximum is 25 characters.")]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        [Phone(ErrorMessage = "Phone Number is not correct!")]
        public string PhoneNumber { get; set; }

        //public int PreviousRoomId { get; set; }

        [InverseProperty("PreviousClient")]
        public virtual ICollection<Room> PreviousRooms { get; set; }

        //public int CurrentRoomId { get; set; }
        [InverseProperty("CurrentClient")]
        public virtual ICollection<Room> CurrentRooms { get; set; }
    }
}
