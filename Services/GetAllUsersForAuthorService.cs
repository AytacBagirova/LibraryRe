using Entities;
using Repositories.Contracts;
using Services.Contracts;
using Services.Model.Request;
using Services.Model.Response;
using System.Collections.Generic;

namespace Services
{
    public class UserService : IUserService
    {

        readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void CreateUser(UserRequest user)
        {
            var userDTO = new User()
            {
                DateOfBirth = user.DateOfBirth,
                EMAIL=user.EMAIL,
                FIRSTNAME=user.FIRSTNAME,
                LASTNAME=user.LASTNAME,
                PASSWORD=user.PASSWORD,
                USERTYPEID=1
            };
            userRepository.CreateAsync(userDTO);

        }

        public List<UserResponse> GetAllUserFilter(UserRequest request)
        {
            List<UserResponse> response = new List<UserResponse>();
            userRepository.GetAll().Where(p=>p.FIRSTNAME==request.FIRSTNAME).ToList().ForEach(p => response.Add(new UserResponse
            {
                Email = p.EMAIL,
                DateOfBirth = p.DateOfBirth,
                FirstName = p.FIRSTNAME,
                LastName = p.LASTNAME,
                Password = p.PASSWORD,
                UserTypeId = p.USERTYPEID
            }));

            return response;
        }

        public List<UserResponse> GetAllUsers()
        {
            List<UserResponse> response = new List<UserResponse>();
            userRepository.GetAll().ToList().ForEach(p => response.Add(new UserResponse
            {
                Email=p.EMAIL,
                DateOfBirth=p.DateOfBirth,
                FirstName=p.FIRSTNAME, 
                LastName=p.LASTNAME,
                Password=p.PASSWORD,
                UserTypeId=p.USERTYPEID
            }));

            return response;

        }
    }
}
