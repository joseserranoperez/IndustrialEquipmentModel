using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IndustrialEquipmentModel.DataAccess.FluentConfigurations.Common;
using IndustrialEquipmentModel.Domain.Entities;
using IndustrialEquipmentModel.Domain.Types;
using IndustrialEquipmentModel.Domain.Entities.Equipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IndustrialEquipmentModel.DataAccess.Contexts;

internal class Program
{
    static void Main(string[] args)
    {

        //Creando un contexto para interactuar con la base de datos.
        ApplicationContext appContext = new ApplicationContext("Data Source = InsustrialEquipmentModelDB.sqlite");


        //Verificando si la base de datos no existe
        if(!appContext.Database.CanConnect())
        {
            //Migrando base de datos. Este paso genera la BD con las tablas configuradas en su migración.
            appContext.Database.Migrate();
        }


        Sensor sensor1 = new Sensor(Guid.NewGuid(), "mide en una habitacion la temperatura a partir", DateTime.Now, Variable.Temperature);
        Actuator actuador1 = new Actuator(Guid.NewGuid(), "permite el paso de blablaabla", DateTime.Now);
        Module module1 = new Module(Guid.NewGuid(), "Alonso Puig",);
        Unit unit1 = new Unit(Guid.NewGuid(), "Jose Serrano", DateTime.Now);


        
        
    }
}

