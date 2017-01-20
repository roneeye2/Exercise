namespace GloboMart.Service.Product.Controllers
{
    using GloboMart.Framwork.Interface;
    using GloboMart.Framwork.Interface.Business;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class ProductController : ApiController
    {
        public IProductDomain product { get; set; }

        public ProductController(IProductDomain product)
        {
            this.product = product;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            product.

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post(string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
