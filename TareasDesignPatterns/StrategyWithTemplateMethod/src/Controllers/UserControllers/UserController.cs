using StrategyWithTemplateMethod.src.Entities;
using StrategyWithTemplateMethod.src.Repositories.Interfaces.DataManager;
using StrategyWithTemplateMethod.src.Repositories.Interfaces.Users;

namespace StrategyWithTemplateMethod.src.Controllers.UserControllers;

public class UserController : IUserManager
{
    private readonly IDataManager<User> _dataManager;

    public UserController(IDataManager<User> dataManager)
    {
        _dataManager = dataManager;
    }

    public bool AddUser(User user)
    {
        return _dataManager.AddItem(user);
    }

    public bool RemoveUser(int memberNumber)
    {
        return _dataManager.RemoveItem("MemberNumber", memberNumber);
    }

    public User SearchUserByMemberNumber(int memberNumber)
    {
        return _dataManager.SearchById("MemberNumber", memberNumber);
    }

    public List<User> SearchUserByName(string nameUser)
    {
        return _dataManager.SearchByAttribute("Name", nameUser);
    }

    public User SearchUserByContactInfo(string contactInfo)
    {
        return _dataManager.SearchById("ContactInfo", contactInfo);
    }

    public bool UpdateUser(int memberNumber, User updatedUser)
    {
        return _dataManager.UpdateItem("MemberNumber", memberNumber, updatedUser);
    }
}
