namespace ProductShop.App
{
    using System.Linq;
    using AutoMapper;

    using Dtos;
    using Models;

    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            CreateMap<Product, ProductInRangeDto>()
                .ForMember(dest => dest.SellerFullName,
                    from => from.MapFrom(p => (p.Seller.FirstName ?? "") + " " + p.Seller.LastName));

            CreateMap<User, UserSoldProductsDto>()
                .ForMember(dest => dest.SoldProducts,
                    from => from.MapFrom(u => u.ProductsSold));

            CreateMap<Product, SoldProductBuyerDto>()
                .ForMember(dest => dest.BuyerFirstName,
                    from => from.MapFrom(p => p.Buyer.FirstName))
                .ForMember(dest => dest.BuyerLastName,
                    from => from.MapFrom(p => p.Buyer.LastName));

            CreateMap<Category, CategoryProductsDto>()
                .ForMember(dest => dest.ProductsCount,
                    from => from.MapFrom(c => c.CategoryProducts.Count))
                .ForMember(dest => dest.AveragePrice,
                    from => from.MapFrom(c => c.CategoryProducts.Average(cp => cp.Product.Price)))
                .ForMember(dest => dest.TotalRevenue,
                    from => from.MapFrom(c => c.CategoryProducts.Sum(cp => cp.Product.Price))); 
        }
    }
}
