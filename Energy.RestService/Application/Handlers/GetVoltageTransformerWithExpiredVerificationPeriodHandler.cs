using Energy.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Energy.RestService.Application.Dto;
using Energy.RestService.Application.Queries;

namespace Energy.RestService.Application.Handlers
{
    public class GetVoltageTransformerWithExpiredVerificationPeriodHandler : 
        IRequestHandler<GetVoltageTransformerWithExpiredVerificationPeriod, 
            GetVoltageTransformerWithExpiredVerificationPeriodResponse>
    {
        private readonly DatabaseContext _databaseContext;

        public GetVoltageTransformerWithExpiredVerificationPeriodHandler(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Task<GetVoltageTransformerWithExpiredVerificationPeriodResponse> Handle(
            GetVoltageTransformerWithExpiredVerificationPeriod request, CancellationToken cancellationToken)
        {
            var expiredTransformers = _databaseContext.ElectricityMeasurementPoints
                .AsNoTracking()
                .Where(p => p.ConsumptionObject.Id == request.ConsumptionObjectId)
                .Select(p => p.VoltageTransformer)
                .AsEnumerable()
                .Where(p => (p.VerificationDate + p.VerificationValidityPeriod) <= DateTime.Now)
                .ToList();

            return Task.FromResult(new GetVoltageTransformerWithExpiredVerificationPeriodResponse
            {
                Transformers = expiredTransformers.Select(p => new VoltageTransformerDto
                {
                    Number = p.Number,
                    VerificationDate = p.VerificationDate,
                    VerificationValidityPeriod = p.VerificationValidityPeriod,
                    TransformCoefficient = p.TransformCoefficient,
                    TransformerType = p.TransformerType
                }).ToList()
            });
        }
    }
}
