using AutoMapper;
using BasicEcommerce.Admin.ProductCategories;
using BasicEcommerce.Admin.Products;
using BasicEcommerce.ProductCategories;
using BasicEcommerce.Products;

namespace BasicEcommerce.Admin;

public class BasicEcommerceAdminApplicationAutoMapperProfile : Profile
{
    public BasicEcommerceAdminApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        
        //Product Category
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();

        //Product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();
        CreateMap<CreateUpdateProductDto, Product>();
    }
}
