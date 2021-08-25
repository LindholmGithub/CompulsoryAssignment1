
using PetShop.Core.IRepositories;
using PetShop.Core.Services;
using PetShop.Domain.IServices;
using PetShop.Infrastructure.Repositories;

namespace PetShop.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPetRepository repoOne = new PetShopRepository();
            IPetService serviceOne = new PetService(repoOne);
            
            var menu = new Menu(serviceOne, serviceTwo);
            menu.Start();
            //Cheapish DI (Dependency Injection)
            //IVideoRepository repo = new VideoRepositoryInMemory();
            //IVideoService service = new VideoService(repo);
            //var menu = new Menu(service);
            //menu.Start();
        }
    }
}