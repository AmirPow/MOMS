using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOMS.DefinitionContext.ApplicationService.Contracts.Procedures;
using MOMS.DefinitionContext.FacadeContracts.Procedures;
using MOMS.ReadModel.Facade.Contracts.Definitions;
using MOMS.ReadModel.Facade.Contracts.Definitions.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefinitionController : ControllerBase
    {
        private readonly IProcedureQueryFacade procedureQueryFacade;

        public DefinitionController(
            IProcedureQueryFacade procedureQueryFacade
            
            )
        {
            this.procedureQueryFacade = procedureQueryFacade;
        }
        [HttpGet]
        [Route("GetDoctors")]
        public IList<DoctorListDto> GetDoctors()
        {
            return procedureQueryFacade.GetDoctors();
        }
        [HttpGet]
        [Route("GetTherapists")]
        public IList<TherapistListDto> GetTherapists()
        {
            return procedureQueryFacade.GetTherapists();
        }
        [HttpGet]
        [Route("GetProcedure")]
        public IList<ProcedureListDto> GetProcedure()
        {
            return procedureQueryFacade.GetProcedures();
        }
        //[HttpPost]
        //[Route("CreateProcedure")]
        //public void CreateProcedure(CreateProcedureCommand command)
        //{
        //    procedureCommandFacade.Create(command);
        //}

    }
}
