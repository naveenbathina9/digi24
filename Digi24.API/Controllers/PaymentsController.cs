using Digi24.BusinessLogic.Contracts;
using Digi24.Entities;
using Digi24.Repository.Contracts;
using Digi24.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Digi24.API.Controllers
{
    [RoutePrefix("api/Payments")]
    public class PaymentsController : ApiController
    {
        private readonly IFeesPaymentService _feesPaymentService;
        public PaymentsController(IFeesPaymentService feesPaymentService)
        {
            _feesPaymentService = feesPaymentService;
        }
        public HttpResponseMessage PayFees(FeesPaymentEntity feesPaymentData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var response = _feesPaymentService.PayFees(feesPaymentData);
                    return Request.CreateResponse(HttpStatusCode.OK, response);

                }else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
