using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;

ICampaignService campaignService = new CampaignManager();
IVerifyService verifyService = new VerifyManager();
IGamerService gamerService = new GamerManager(verifyService);
ISalesService salesService = new SalesManager();

Gamer gamer = new Gamer
{
    FirstName = "Muhammet Ali",
    LastName = "Baran",
    DateOfBirth = 2001,
    NationalityId = "12345678912"
};

Campaign campaign = new Campaign
{
    Id = 1,
    Discount = 15
};

Sale sale = new Sale
{
    Name = "Resident Evil 4 Remake",
    Price = 900
};

gamerService.Add(gamer);
gamerService.Update(gamer);
gamerService.Delete(gamer);
campaignService.Add(campaign);
salesService.Sales(gamer, sale, campaign);

Console.ReadLine();