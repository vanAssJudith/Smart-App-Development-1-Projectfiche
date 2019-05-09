using System.Threading.Tasks;

namespace Project.Repositories
{
    public interface IShareRepository
    {
        Task ShareText(string text);
    }
}