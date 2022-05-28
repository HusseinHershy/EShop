using EShop.Application.Features.Products;
using EShop.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Application.Features.Products.Commands.CreateProduct;
using EShop.Application.Features.Products.ViewModels;

namespace EShop.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Product 
           
            CreateMap<ProductDetail, ProductDetailVM>().ReverseMap()
             .ForAllMembers(x => x.Ignore());
            CreateMap<ProductDetail, ProductDetailVM>().ReverseMap()
                         .ForMember(dest => dest.ActualCost, opt => opt.MapFrom(src => src.ActualCost))
                         .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price));

            CreateMap<ProductDetail, CreateProductDetailVM>().ReverseMap()
                       .ForAllMembers(x => x.Ignore());
            CreateMap<ProductDetail, CreateProductDetailVM>().ReverseMap()
                         .ForMember(dest => dest.ActualCost, opt => opt.MapFrom(src => src.ActualCost))
                         .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price));


            CreateMap<Product, ProductVM>().ReverseMap()
                        .ForAllMembers(x => x.Ignore());
            CreateMap<Product, ProductVM>().ReverseMap()
                         .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                         .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                         .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.Color))
                         .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                         .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
                         .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName))
                         .ForMember(dest => dest.ProdutPriceDetails, opt => opt.MapFrom(src => src.ProdutPriceDetails));


            CreateMap<Product, CreateProductCommand>().ReverseMap()
                        .ForAllMembers(x => x.Ignore());
            CreateMap<Product, CreateProductCommand>().ReverseMap()
                          .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                         .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.Color))
                         .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                         .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
                         .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName))
                         .ForMember(dest => dest.ProdutPriceDetails, opt => opt.MapFrom(src => src.ProductDetail));
                        

            #endregion
        }
    }
}
