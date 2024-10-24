using System.Collections.Generic;
using KoiManagement.DataAccess;
using KoiManagement.Entities;

namespace KoiManagement.BusinessLogic
{
    public class WaterParameterService
    {
        private WaterParameterRepository _waterParameterRepository = new WaterParameterRepository();

        public void AddWaterParameter(WaterParameter parameter)
        {
            _waterParameterRepository.AddWaterParameter(parameter);
        }

        public List<WaterParameter> GetAllWaterParameters()
        {
            return _waterParameterRepository.GetAllWaterParameters();
        }
    }
}