namespace Energy.RestService.Application.Queries
{
    public class GetCountersWithExpiredVerificationPeriod : IQuery<GetCountersWithExpiredVerificationPeriodResponse>
    {
        public long ConsumptionObjectId { get; init; }
    }
}
