namespace CarDealer.App
{
    using AutoMapper;

    using Dtos;
    using Models;

    public class CarDealerProfile : Profile
    {
        public CarDealerProfile()
        {
            CreateMap<Car, ToyotaCarDto>()
                .ForMember(dest => dest.Id,
                    from => from.MapFrom(c => c.CarId));

            CreateMap<Supplier, NotImporterSupplierDto>()
                .ForMember(dest => dest.Id,
                    from => from.MapFrom(s => s.SupplierId))
                .ForMember(dest => dest.PartsCount,
                    from => from.MapFrom(s => s.Parts.Count));            
        }
    }
}
