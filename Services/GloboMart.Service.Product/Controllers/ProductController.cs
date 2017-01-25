namespace GloboMart.Service.Product.Controllers
{
    using GloboMart.Framwork.Interface;
    using GloboMart.Framwork.Interface.Business;
    using GloboMart.Framwork.Interface.Entity;
    using GloboMart.Framwork.Interface.Enum;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class ProductController : ApiController
    {
        public IProductDomain product { get; set; }
        public IProduct productModel { get; set; }
        public IProductCategory CategoryModel { get; set; }

        public ProductController(IProductDomain product, IProduct productModel, IProductCategory category)
        {
            this.product = product;
            this.productModel = productModel;
            this.CategoryModel = category;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            productModel.Id = 1;
            productModel.Name = "ABC";

            product.Create(productModel);

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
