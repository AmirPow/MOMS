using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOMS.CustomerContext.ApplicationServiceContracts.Sequencing;
using MOMS.CustomerContext.Facade.Contracts.Sequencings;


namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SequencingController : ControllerBase
    {
        private readonly ISequencingCommandFacade sequencingCommandFacade;

        public SequencingController(ISequencingCommandFacade sequencingCommandFacade)
        {
            this.sequencingCommandFacade = sequencingCommandFacade;
        }
        [HttpPost]
        [Route("CreateSequencing")]
        public void Create(CreateSequencingCommand createSequencingCommand)
        {
            sequencingCommandFacade.CreateSequencing(createSequencingCommand);
        }

        [HttpPut]
        [Route("UpdateSequencing")]
        public void Update(UpdateSequencingCommand updateSequencingCommand)
        {
            sequencingCommandFacade.UpdateSequencing(updateSequencingCommand);
        }

        [HttpDelete]
        [Route("DeleteSequencing")]
        public void Delete (DeleteSequencingCommand deleteSequencingCommand)
        {
            sequencingCommandFacade.DeleteSequencing(deleteSequencingCommand);
        }
    }
}
