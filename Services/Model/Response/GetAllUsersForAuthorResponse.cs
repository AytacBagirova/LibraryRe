

namespace Services.Model.Response
{
    public class UserResponse
    {
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public required  string LastName { get; set; }

        public required  string Email { get; set; }

        public required DateTime DateOfBirth { get; set; }
        public int Age { get { return (int)((DateTime.Today.Date - DateOfBirth.Date).TotalDays / 365.12); } }


        public int UserTypeId { get; set; }

        public required string Password { get; set; }
        public string UserTypeName { get; set; }

    }
}
