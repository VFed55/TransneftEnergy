using System;
using Energy.RestService.Application.Dto;

namespace Energy.RestService.Application.Commands
{
    public class CreateMeasurementPointCmd : ICommand
    {
        public ElectricityMeterDto ElectricityMeter { get; init; }

        public VoltageTransformerDto VoltageTransformer { get; init; }

        public ElectricityTransformerDto ElectricityTransformer { get; init; }

        public string MeasurementPointName { get; init; }

        public long ConsumptionObjectId { get; init; }
    }

    
}
