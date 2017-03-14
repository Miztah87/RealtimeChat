using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ChatDAL.Context;
using ChatDAL.DomainModel;
using ChatDAL;
using System.Web.Http.Cors;

namespace ChatApi.Controllers
{
    //Enables Cross-Origin Requests for the whole controller
    // Origins should be aimed for the client app.
    [EnableCors(origins: "http://localhost:51660", headers: "*", methods: "*")]
    public class MsgController : ApiController
    {
        // Instantiates Facade 
        private FacadeDAL facade = new FacadeDAL();

        // GET: api/Msg/
        [HttpGet]       
        public IEnumerable<Message> GetMessages()
        {
            //Gets all messages from repository
            return facade.GetMessageRepository().ReadAll();
        }
        [HttpPost]        
        public HttpResponseMessage PostMessage([FromBody]Message msg)
        {
            if(msg != null)
            {
                facade.GetMessageRepository().Add(msg);
                //Sends 200 Http Code 
                return Request.CreateResponse<Message>(HttpStatusCode.OK, msg);
            }else
            {
                // Send 404 Http Code
               return Request.CreateErrorResponse(HttpStatusCode.NotFound, " Could not add message");
            }
           

        }
    
    }
}