using System.Collections.Generic;
using Energy.RestService.Application.Dto;

namespace Energy.RestService.Application.Queries
{
    public class GetCalculationAccountingDeviceResponse
    {
        public IReadOnlyCollection<CalculationAccountingDeviceDto> CalculationAccountingDevices { get; init; }
    }
}
