using WebApi.DTO;
using WebApi.Model;

namespace WebApi.BLL
{
    public interface IService
    {
        public int add(KeyboardDTO keyboard);
        public bool remove(int id);
        public List<Keyboards> get();
    }
}
