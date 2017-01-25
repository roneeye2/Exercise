using GloboMart.Business;
using GloboMart.Framwork.Interface.Business;
using GloboMart.Framwork.Interface.Entity;
using GloboMart.Framwork.Interface.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GloboMart.Service.Order.Controllers
{
    public class OrderController : ApiController
    {
        public IProductDomain product { get; set; }
        public ICategoryDomain categoryDomain { get; set; }
        public IProduct productModel { get; set; }

        public OrderController(IProductDomain product, IProduct productModel, ICategoryDomain categoryDomain)
        {
            this.product = product;
            this.productModel = productModel;
            this.categoryDomain = categoryDomain;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            productModel.Id = 1;
            productModel.Name = "ABC";
            productModel.ProductCategory = categoryDomain.ReadByCategory(eProductCategory.Footware);

            var p = product.Create(productModel);

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
