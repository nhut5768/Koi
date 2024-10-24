using System.Collections.Generic;
using KoiManagement.DataAccess;
using KoiManagement.Entities;

namespace KoiManagement.BusinessLogic
{
    public class PondService
    {
        private PondRepository _pondRepository = new PondRepository();

        public void AddPond(Pond pond)
        {
            _pondRepository.AddPond(pond);
        }

        public List<Pond> GetAllPonds()
        {
            return _pondRepository.GetAllPonds();
        }
    }
}