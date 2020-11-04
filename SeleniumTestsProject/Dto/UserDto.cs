
namespace SeleniumTestsProject.Dto
{
    class UserDto
    {
        public string userEmail { get; set; }
        public string userPassword { get; set; }


        public UserDto GetValidUser()
        {
            UserDto validUserDto = new UserDto();
            if (this.userEmail != null)
            {
                validUserDto.userEmail = userEmail;
            } else {
                validUserDto.userEmail = string.Empty;

            }
            
            if (this.userPassword != null)
            {
                validUserDto.userPassword = userPassword;
            }
            else
            {
                validUserDto.userPassword = string.Empty;

            }
            return validUserDto;
        }
    }


}
