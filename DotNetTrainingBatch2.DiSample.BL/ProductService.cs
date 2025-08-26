using DotNetTrainingBatch2.DiSample.DA;
using DotNetTrainingBatch2.DiSample.Database.AppDbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch2.DiSample.BL
{
    public class ProductService
    {
        private readonly ProductDataAccess _productDataAaccess;

        public ProductService(ProductDataAccess productDataAccess)
        {
            _productDataAaccess = productDataAccess;
        }

        public List<TblProduct> GetProducts(int PageNo, int PageSize) 
        {
            if(PageNo == 0)
            {
                throw new Exception("Page number cannot be zero");
            }
            if(PageSize == 0)
            {
                throw new Exception("Page size cannot be zero");
            }
            return _productDataAaccess.GetProducts(PageNo, PageSize);
        }
    }
}
