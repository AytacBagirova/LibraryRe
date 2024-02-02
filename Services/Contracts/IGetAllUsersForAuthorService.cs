using Entities;
using Services.Model.Request;
using Services.Model.Response;

namespace Services.Contracts
{
    public interface IUserService
    {
        void CreateUser(UserRequest user);

        List<UserResponse> GetAllUsers();

      //  List<UserResponse> GetAllUserFilter(User user);

    }
}
