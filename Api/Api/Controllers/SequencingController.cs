using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOMS.CustomerContext.ApplicationServiceContracts.Sequencing;
using MOMS.CustomerContext.Facade.Contracts.Sequencings;
using MOMS.ReadModel.Facade.Contracts.Sequencings;
using MOMS.ReadModel.Facade.Contracts.Sequencings.DataContracts;
using System;
using System.Collections.Generic;

namespace Api.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SequencingController : ControllerBase
    {

        private readonly ISequencingCommandFacade sequencingCommandFacade;
        private readonly ISequencingQueryFacade sequencingQueryFacade;

        public SequencingController(
            ISequencingCommandFacade sequencingCommandFacade,
            ISequencingQueryFacade sequencingQueryFacade
            )
        {
            this.sequencingCommandFacade = sequencingCommandFacade;
            this.sequencingQueryFacade = sequencingQueryFacade;
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
        public void Delete(DeleteSequencingCommand deleteSequencingCommand)
        {
            sequencingCommandFacade.DeleteSequencing(deleteSequencingCommand);
        }

        [HttpGet]
        [Route("GetAllSequencing")]
        public IList<SequencingDto> GetSequencing(DateTime startDate, DateTime endDate)
        {
            return sequencingQueryFacade.GetAll(startDate, endDate);
        }

        [HttpGet]
        [Route("GetCustomerSequencing")]
        public IList<CustomerSequencingDto> GetCustomerSequencing(string customerFileNumber)
        {
            return sequencingQueryFacade.GetCustomerSequencing(customerFileNumber);
        }

    }
}
