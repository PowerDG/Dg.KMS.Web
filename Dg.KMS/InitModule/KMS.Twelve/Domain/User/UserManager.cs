namespace KMS.Twelve.Domain.User
{
    public interface IUserManager
    {
        void Register(string name);
    }

    /// <summary>
    /// Autofac自动实现注入到IUermanager接口，程序用扫描IDependency接口用于自动注入
    /// </summary>
    public class UserManager : IUserManager, IDependency
    {
        public void Register(string name)
        {
        }
    }
}