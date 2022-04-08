using System;

namespace Energy.RestService.Application.Queries
{
    public class GetCalculationAccountingDevice : IQuery<GetCalculationAccountingDeviceResponse>
    {
        public DateTime StartSearchPeriod { get; init; }

        public DateTime EndSearchPeriod {  get; init; }
    }
}
