using AutoMapper;
using AutoMapperSample.Domain;
using AutoMapperSample.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMapperSample.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Book, BookDto>()
                .ForMember(a => a.Book_Name, b => b.MapFrom(c => c.Name))
                .ForMember(a => a.Author_Name, b => b.MapFrom(c => c.Author))
                .ForMember(a => a.Book_Price, b => b.MapFrom(c => c.Price));

            CreateMap<BookDto, Book>()
                .ForMember(a => a.Name, b => b.MapFrom(c => c.Book_Name))
                .ForMember(a => a.Author, b => b.MapFrom(c => c.Author_Name))
                .ForMember(a => a.Price, b => b.MapFrom(c => c.Book_Price));

            CreateMap<Catalogue, CatalogueDto>()
                .ForMember(a => a.CatalogueDto_Name, b => b.MapFrom(c => c.Name));
            CreateMap<CatalogueDto, Catalogue>()
                .ForMember(a => a.Name, b => b.MapFrom(c => c.CatalogueDto_Name));
            CreateMap<Library, LibraryDto>()
                .ForMember(a => a.Id, b => b.Ignore());
            CreateMap<LibraryDto, Library>();
        }
    }
}
