using Microsoft.AspNetCore.Authorization;
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
    //[Authorize]
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
        public IList<DoctorListDto> GetDoctors(string searchText)
        {
            return procedureQueryFacade.GetDoctors(searchText);
        }
        [HttpGet]
        [Route("GetTherapists")]
        public IList<TherapistListDto> GetTherapists(string searchText)
        {
            return procedureQueryFacade.GetTherapists(searchText);
        }
        [HttpGet]
        [Route("GetProcedure")]
        public IList<ProcedureListDto> GetProcedure(string searchText)
        {
            return procedureQueryFacade.GetProcedures(searchText);
        }
        //[HttpPost]
        //[Route("CreateProcedure")]
        //public void CreateProcedure(CreateProcedureCommand command)
        //{
        //    procedureCommandFacade.Create(command);
        //}

    }
}
