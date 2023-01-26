using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EnocaChallengeV2.Commands;
using EnocaChallengeV2.Models;
using EnocaChallengeV2.Queries;
using EnocaChallengeV2.Repositories;
using MediatR;
using System;

namespace EnocaChallengeV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmController : ControllerBase
    {
        private readonly IMediator mediator;
        public FirmController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [Route("getAllFirms")]
        [HttpGet]
        public async Task<List<Firm>> GetFirmListAsync()
        {
            var firmDetails = await mediator.Send(new GetFirmListQuery());

            return firmDetails;
        }
        [Route("addFirm")]
        [HttpPost]
        public async Task<Firm> AddFirmAsync(Firm firm)
        {
            var addedFirm = await mediator.Send(new CreateFirmCommand(
                firm.FirmName,
                firm.isVerified,
                firm.startTime,
                firm.endTime));
            return addedFirm;
        }
        [Route("date")]
        [HttpPatch]
        public async Task<int> UpdateFirmDateAsync(Firm firm)
        {
            var updatedFirm = await mediator.Send(new UpdateFirmDateCommand(firm.Id, firm.startTime, firm.endTime));
            return updatedFirm;
        }
        [Route("verification")]
        [HttpPatch]
        public async Task<int> UpdateFirmVerificationAsync(Firm firm)
        {
            var updatedVerificationFirm = await mediator.Send(new UpdateFirmVerificationCommand(firm.Id, firm.isVerified));
            return updatedVerificationFirm;
        }
    }
}
