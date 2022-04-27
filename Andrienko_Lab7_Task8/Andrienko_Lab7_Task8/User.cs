namespace Andrienko_Lab7_Task8
{ 
public class User
{
    public string LoginName { get; set; }
}

public interface IUserRepository
{
    void Add(User newUser);
    User FetchByLoginName(string loginName);
    void SubmitChanges();
}

public class DefaultUserRepository : IUserRepository
{

    public void Add(User newUser)
    {
        //Необходимо реализовать
    }
    public User FetchByLoginName(string loginName)
    {
        return new User() { LoginName = loginName };
    }

    public void SubmitChanges()
    {
        //Необходимо реализовать
    }
}
}