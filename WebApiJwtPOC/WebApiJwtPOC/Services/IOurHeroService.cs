using WebApiJwtPOC.Model;

namespace WebApiJwtPOC.Services
{
    public interface IOurHeroService
    {
        List<OurHero> GetAllHeros(bool? isActive);

        OurHero? GetHerosByID(int id);

        OurHero AddOurHero(AddUpdateOurHero obj);

        OurHero? UpdateOurHero(int id, AddUpdateOurHero obj);

        bool DeleteHerosByID(int id);
    }
}
