using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationWEBAPI.Models;

namespace WebApplicationWEBAPI.Controllers
{
    /// <summary>
    /// The main PeopleController entry
    /// </summary>
    public class PeopleController : ApiController
    {

        public PeopleController()
        {
           
        }

        /// <summary>
        /// This is changed the route location api 
        /// </summary>
        /// <param name="people">people object</param>
        [Route("api/People/GetHisName")] // add custom route
        [HttpPost]
        public void PersonName(People people)
        {

        }


        /// <summary>
        /// dual parameter requeat
        /// </summary>
        /// <param name="a">param 1</param>
        /// <param name="b">param 2</param>
        [Route("api/People/CalCulate/{a:int}/{b:int}")]   ///api/People/CalCulate/2/4
        [HttpPost]
        public void Numbers(int a,int b)
        {
               
        }

        // GET: api/People
        /// <summary>
        /// Get API method
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/People/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/People
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
