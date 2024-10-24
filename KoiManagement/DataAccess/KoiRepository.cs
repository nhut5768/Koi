using System.Collections.Generic;
using KoiManagement.Entities;

namespace KoiManagement.DataAccess
{
    public class KoiRepository
    {
        private List<Koi> _koiList = new List<Koi>();

        public void AddKoi(Koi koi)
        {
            _koiList.Add(koi);
        }

        public List<Koi> GetAllKoi()
        {
            return _koiList;
        }
    }
}