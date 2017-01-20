using GloboMart.Business;
using GloboMart.Framwork.Interface.Business;
using GloboMart.Framwork.Interface.Entity;
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
        public IProduct productModel { get; set; }
        public IProductCategory CategoryModel { get; set; }

        public OrderController(IProductDomain product, IProduct productModel, IProductCategory category)
        {
            this.product = product;
            this.productModel = productModel;
            this.CategoryModel = category;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            //productModel.Id = 1;
            //productModel.Name = "ABC";
            //productModel.ProductCategory = CategoryModel;
            //productModel.ProductCategory.Name = "Shoes";
            //productModel.ProductCategory.Id = 1;

            var p = product.Read();

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
