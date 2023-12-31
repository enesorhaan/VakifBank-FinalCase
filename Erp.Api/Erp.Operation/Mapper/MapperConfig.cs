﻿using AutoMapper;
using Erp.Data.Entities;
using Erp.Dto;

namespace Erp.Operation.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<CompanyRequest, Company>();
            CreateMap<Company, CompanyResponse>()
                .ForMember(dest => dest.Role,
                    opt => opt.MapFrom(src => src.Role));

            CreateMap<DealerRequest, Dealer>();
            CreateMap<Dealer, DealerResponse>();

            CreateMap<CurrentAccountRequest, CurrentAccount>();
            CreateMap<CurrentAccountUpdateRequest, CurrentAccount>();
            CreateMap<CurrentAccount, CurrentAccountResponse>()
                .ForMember(dest => dest.Dealer,
                    opt => opt.MapFrom(src => src.Dealer.DealerName));

            CreateMap<ProductRequest, Product>();
            CreateMap<Product, ProductResponse>();
            CreateMap<Product, ProductDetailResponse>();

            CreateMap<OrderCreateRequest, Order>();
            CreateMap<OrderUpdateRequest, Order>();
            CreateMap<Order, OrderResponse>()
                .ForMember(dest => dest.Dealer,
                    opt => opt.MapFrom(src => src.Dealer.DealerName))
                .ForMember(dest => dest.OrderItems,
                    opt => opt.MapFrom(src => src.OrderItems));

            CreateMap<OrderItemRequest, OrderItem>();
            CreateMap<OrderItem, OrderItemResponse>()
                .ForMember(dest => dest.Product,
                    opt => opt.MapFrom(src => src.Product.ProductName));

            CreateMap<AdminMessageRequest, Message>();
            CreateMap<DealerMessageRequest, Message>();
            CreateMap<Message, MessageResponse>()
                .ForMember(dest => dest.Dealer,
                    opt => opt.MapFrom(src => src.Dealer.DealerName));

            CreateMap<ExpenseRequest, Expense>();
            CreateMap<Expense, ExpenseResponse>()
                .ForMember(dest => dest.DealerName,
                    opt => opt.MapFrom(src => src.Dealer.DealerName));

            CreateMap<LoginRequest, Company>();
            CreateMap<Company, LoginResponse>()
                .ForMember(dest => dest.User,
                    opt => opt.MapFrom(src => src.CompanyName));

            CreateMap<LoginRequest, Dealer>();
            CreateMap<Dealer, LoginResponse>()
                .ForMember(dest => dest.User,
                    opt => opt.MapFrom(src => src.DealerName));

            CreateMap<AdminMessageRequest, MessageResponse>();
            CreateMap<DealerMessageRequest, MessageResponse>();
        }
    }
}
