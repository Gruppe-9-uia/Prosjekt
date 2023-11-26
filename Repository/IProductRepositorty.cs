using Prosjekt.Entities;

namespace Prosjekt.Repository
{
    public interface IProductRepositorty
    {
        ProductModel getProductByID(string? id);
        ProductModel? findProductByID(string? id);
        void InsertProductModel(ProductModel model);
        void UpdateProduct(ProductModel model);
        void DeleteParts(string id);
        void Save();
    }
}
