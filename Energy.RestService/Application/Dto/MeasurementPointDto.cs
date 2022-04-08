namespace Energy.RestService.Application.Dto
{
    public class MeasurementPointDto
    {
        public string Name { get; init; }

        public ElectricityMeterDto ElectricityMeter { get; init; }

        public VoltageTransformerDto VoltageTransformer { get; protected set; }

        public ElectricityTransformerDto ElectricityTransformer { get; protected set; }
    }
}
