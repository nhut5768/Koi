using System.Collections.Generic;
using KoiManagement.Entities;

namespace KoiManagement.DataAccess
{
    public class WaterParameterRepository
    {
        private List<WaterParameter> _waterParameters = new List<WaterParameter>();

        public void AddWaterParameter(WaterParameter parameter)
        {
            _waterParameters.Add(parameter);
        }

        public List<WaterParameter> GetAllWaterParameters()
        {
            return _waterParameters;
        }
    }
}