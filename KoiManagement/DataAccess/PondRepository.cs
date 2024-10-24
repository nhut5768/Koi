using System.Collections.Generic;
using KoiManagement.Entities;

namespace KoiManagement.DataAccess
{
    public class PondRepository
    {
        private List<Pond> _pondList = new List<Pond>();

        public void AddPond(Pond pond)
        {
            _pondList.Add(pond);
        }

        public List<Pond> GetAllPonds()
        {
            return _pondList;
        }
    }
}