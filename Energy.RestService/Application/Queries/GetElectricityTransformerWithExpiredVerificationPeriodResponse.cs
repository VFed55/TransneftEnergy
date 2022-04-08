using System.Collections.Generic;
using Energy.RestService.Application.Dto;

namespace Energy.RestService.Application.Queries
{
    public class GetElectricityTransformerWithExpiredVerificationPeriodResponse
    {
        public IEnumerable<ElectricityTransformerDto> Transformers { get; init; }
    }
}
