﻿using AutoMapper;
using Shop.Common.DTO;
using Shop.Entities.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Mapping
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            EntityToDto();
            DtoToEntity();
        }
        private void EntityToDto()
        {
            CreateMap<Account, AccountDTO>();
            CreateMap<CategoryProduct, CategoryProductDTO>();
            CreateMap<Comment, CommentDTO>();
            CreateMap<File, FileDTO>();
            CreateMap<OrderDetail, OrderDetailDTO>();
            CreateMap<Order, OrderDTO>();
            CreateMap<Product, ProductDTO>();
            CreateMap<Menu, MenuDTO>();
            CreateMap<Rate, RateDTO>();
            CreateMap<Slide, SlideDTO>();
        }
        private void DtoToEntity()
        {
            CreateMap<SlideDTO, Slide>();
            CreateMap<AccountDTO, Account>();
            CreateMap<CategoryProductDTO, CategoryProduct>();
            CreateMap<CommentDTO, Comment>();
            CreateMap<FileDTO, File>();
            CreateMap<OrderDetailDTO, OrderDetail>();
            CreateMap<OrderDTO, Order>();
            CreateMap<ProductDTO, Product>();
            CreateMap<MenuDTO, Menu>();
            CreateMap<RateDTO, Rate>();
        }
    }
}
