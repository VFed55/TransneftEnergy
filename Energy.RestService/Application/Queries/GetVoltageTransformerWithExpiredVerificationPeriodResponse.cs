using System.Collections.Generic;
using Energy.RestService.Application.Dto;

namespace Energy.RestService.Application.Queries
{
    public class GetVoltageTransformerWithExpiredVerificationPeriodResponse
    {
        public IEnumerable<VoltageTransformerDto> Transformers { get; init; }
    }
}
