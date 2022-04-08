using System.Collections.Generic;
using Energy.RestService.Application.Dto;

namespace Energy.RestService.Application.Queries
{
    public class GetCountersWithExpiredVerificationPeriodResponse
    {
        public IReadOnlyCollection<ElectricityMeterDto> Counters { get; init; }
    }
}
