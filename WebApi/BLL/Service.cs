using WebApi.DTO;
using WebApi.Model;

namespace WebApi.BLL
{
    public class Service : IService
    {
        private static List<Keyboards> keyboards = new List<Keyboards> { 
            new Keyboards {Id = 1, Model = "k1", Rodzaj = KeyboardType.hybrydowa},
            new Keyboards {Id = 2, Model = "k2", Rodzaj = KeyboardType.mechaniczna},
            new Keyboards {Id = 3, Model = "k3", Rodzaj = KeyboardType.nozycowa},
            new Keyboards {Id = 4, Model = "k4", Rodzaj = KeyboardType.optyczna},
            new Keyboards {Id = 5, Model = "k5", Rodzaj = KeyboardType.membranowa},
            new Keyboards {Id = 6, Model = "k6", Rodzaj = KeyboardType.hybrydowa},
        };
        public int add(KeyboardDTO keyboard)
        {
            try
            {
                int keyboardId = keyboards.Any() ? keyboards.Max(keyboard => keyboard.Id) + 1 : 1;
                keyboards.Add(new Keyboards { Id = keyboardId, Model = keyboard.Model, Rodzaj= keyboard.Rodzaj });  
                return keyboardId;
            }
            catch(Exception e) {
                return -1;
            }
        }
        public bool remove(int id)
        {
            var keyboard = keyboards.FirstOrDefault(keyboard => keyboard.Id == id);
            if(keyboard == null) 
            {
                return false;
            }

            keyboards.Remove(keyboard);
            return true;
        }
        public List<Keyboards> get()
        {
            return keyboards;
        }
    }
}
