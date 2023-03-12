using TheCaffinationStation.Models;

namespace TheCaffinationStation.Repositories
{
    public interface IBeanVarietyRepository
    {
        void Add(BeanVariety variety);
        void Delete(int id);
        BeanVariety Get(int id);
        List<BeanVariety> GetAll();
        void Update(BeanVariety variety);
    }
}