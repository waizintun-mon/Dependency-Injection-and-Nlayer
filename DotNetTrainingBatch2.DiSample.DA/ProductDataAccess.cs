using DotNetTrainingBatch2.DiSample.Database.AppDbContextModels;

namespace DotNetTrainingBatch2.DiSample.DA
{
    public class ProductDataAccess
    {
        private readonly AppDbContext _db;

        public ProductDataAccess(AppDbContext db)
        {
            _db = db;
        }

        public List<TblProduct> GetProducts(int PageNo, int PageSize)
        {
          return  _db.TblProducts
                .Where(x=>x.DeleteFlag == false)
                .Skip((PageNo -1) * PageSize)
                .Take(PageSize)
                .ToList();
        }
    }
}
