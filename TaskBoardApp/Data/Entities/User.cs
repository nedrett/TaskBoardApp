namespace TaskBoardApp.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;
    using static TaskBoardApp.Data.DataConstants.User;

    public class User : IdentityUser
    {
        [Required]
        [MaxLength(MaxUserFirstName)]
        public string FirstName { get; init; }

        [Required]
        [MaxLength(MaxUserLastName)]
        public string LastName { get; init; }
    }
}
