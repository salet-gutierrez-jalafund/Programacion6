using System;
using StrategyWithTemplateMethod.src.Entities;

namespace StrategyWithTemplateMethod.src.Repositories.Interfaces.Users;

public interface IUserManager
{
    List<User> SearchUserByName(string nameUser);

    User SearchUserByMemberNumber(int memberNumber);

    User SearchUserByContactInfo(string contactInfo);

    bool AddUser(User user);

    bool RemoveUser(int memberNumber);

    bool UpdateUser(int memberNumber, User updatedUser);
}
