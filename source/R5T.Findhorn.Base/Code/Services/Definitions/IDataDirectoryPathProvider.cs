using System;using R5T.T0064;


namespace R5T.Findhorn
{[ServiceDefinitionMarker]
    public interface IDataDirectoryPathProvider:IServiceDefinition
    {
        string GetDataDirectoryPath();
    }
}
