using System;
using System.ComponentModel.DataAnnotations;

namespace LinqApp
{
    public class ApplicationUser
    {
        [Required]
        public Guid ApplicationUserId { get; set; }
        [StringLength(55)]
        public string FirstName { get; set; }
        [StringLength(55)]
        public string LastName { get; set; }
        public int FavoriteNumber { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string MobilePhone { get; set; }
        public string FavoriteActivity { get; set; }
        public DateTime CreatedOn { get; set; }

        public ApplicationUser()
        {

        }
        public ApplicationUser(string firstName, string lastName, int favoriteNumber, string mobilePhone, string favoriteActivity)
        {
            ApplicationUserId = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            FavoriteNumber = favoriteNumber;
            MobilePhone = mobilePhone;
            FavoriteActivity = favoriteActivity;
            CreatedOn = DateTime.Now;
        }

        public override string ToString()
        {
            return string.Format($"Name:{FirstName + ' ' + LastName}, favorite number:{FavoriteNumber}," +
                $" favorite activity:{FavoriteActivity}, phone number:{MobilePhone}, created on :{CreatedOn}\n");
        }
    }
}
