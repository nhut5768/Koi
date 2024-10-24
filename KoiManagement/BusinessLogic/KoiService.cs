using System.Collections.Generic;
using KoiManagement.DataAccess;
using KoiManagement.Entities;

namespace KoiManagement.BusinessLogic
{
    public class KoiService
    {
        private KoiRepository _koiRepository = new KoiRepository();

        public void AddKoi(Koi koi)
        {
            _koiRepository.AddKoi(koi);
        }

        public List<Koi> GetAllKoi()
        {
            return _koiRepository.GetAllKoi();
        }

        public double CalculateFoodAmount(Koi koi)
        {
            return koi.Size; // g
        }
    }
}