using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sales(Gamer gamer, Sale sale, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName+" adlı kullanıcı "+sale.Name+" oyunu için %"+campaign.Discount+" indirime hak kazandı!");
        }
    }
}
