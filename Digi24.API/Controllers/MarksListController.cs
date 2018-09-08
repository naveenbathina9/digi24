using Digi24.BusinessLogic.Contracts;
using Digi24.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Digi24.API.Controllers
{
    public class MarksListController : ApiController
    {
        private readonly IMarksListService _marksListService;
        public MarksListController(IMarksListService marksListService)
        {
            _marksListService = marksListService;
        }

        [HttpPost]
        [Route("CreateMarksList")]
        public HttpResponseMessage CreateMarksList(MarksListEntity marksListEntity)
        {
            try
            {
                var response = _marksListService.CreateMarksList(marksListEntity);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
