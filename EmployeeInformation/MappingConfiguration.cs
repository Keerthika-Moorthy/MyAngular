using Dapper.FluentMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInformation
{
    public static class MappingConfiguration
    {
        public static bool IsInitialized { get; private set; }

        public static void Initialize()
        {
            if(!IsInitialized)
            {
                FluentMapper.Initialize(config => { config.AddMap(new EmployeeDtoMap()); });
            }
        }
    }
}
