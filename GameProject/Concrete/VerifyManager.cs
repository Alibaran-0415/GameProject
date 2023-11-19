using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class VerifyManager : IVerifyService
    {
        public bool Verify(Gamer gamer)
        {
            if (gamer.FirstName=="Muhammet Ali" && gamer.LastName=="Baran" && gamer.DateOfBirth==2001 && gamer.NationalityId=="12345678912")
            {
                Console.WriteLine(gamer.FirstName+" adlı kullanıcı doğrulandı!");
                return true;
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulanamadı!");
                return false;
            }
        }
    }
}
