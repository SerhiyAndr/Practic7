using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
namespace Andrienko_Lab7_Task8.Tests
{
    [TestClass]
public class AdminControllerTests
{
    [TestMethod]
    public void CanChangeLoginName()
    {

        // Организация (настройка сценария)
        User user = new User() { LoginName = "Bob" };
        FakeRepository repositoryParam = new FakeRepository();
        repositoryParam.Add(user);
        AdminController target = new AdminController(repositoryParam);
        string oldLoginParam = user.LoginName;
        string newLoginParam = "Joe";

        // Действие (попытка выполнения операции)
        target.ChangeLoginName(oldLoginParam, newLoginParam);

        // Утверждение (проверка результатов)
        Assert.AreEqual(newLoginParam, user.LoginName);
        Assert.IsTrue(repositoryParam.DidSubmitChanges);
    }
}
class FakeRepository : IUserRepository
{
    public List<User> Users = new List<User>();
    public bool DidSubmitChanges = false;

    public void Add(User user)
    {
        Users.Add(user);
    }
    public User FetchByLoginName(string loginName)
    {
        return Users.First(m => m.LoginName == loginName);
    }
    public void SubmitChanges()
    {
        DidSubmitChanges = true;
    }
}
}