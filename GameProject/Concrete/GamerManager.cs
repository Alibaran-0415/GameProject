using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IVerifyService _verifyService;

        public GamerManager(IVerifyService verifyService)
        {
            _verifyService = verifyService;
        }

        public void Add(Gamer gamer)
        {
            if (_verifyService.Verify(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName + " adlı kullanıcı  sisteme kaydedildi!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı kullanıcı sistemden silindi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı kullanıcının bilgileri güncellendi!");
        }
    }
}
