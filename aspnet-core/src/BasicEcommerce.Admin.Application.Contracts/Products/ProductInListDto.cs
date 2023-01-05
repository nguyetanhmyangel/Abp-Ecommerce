using System;
using BasicEcommerce.Products;
using Volo.Abp.Application.Dtos;

namespace BasicEcommerce.Admin.Products;

public class ProductInListDto : EntityDto<Guid>
{
    public Guid ManufacturerId { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string Slug { get; set; }
    public ProductType ProductType { get; set; }
    public string SKU { get; set; }
    public int SortOrder { get; set; }
    public bool Visiblity { get; set; }
    public bool IsActive { get; set; }
    public Guid CategoryId { get; set; }
    public string ThumbnailPicture { get; set; }
}