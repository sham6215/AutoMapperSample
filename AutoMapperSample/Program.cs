using AutoMapper;
using AutoMapperSample.Domain;
using AutoMapperSample.Dto;
using AutoMapperSample.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMapperSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DoMapping();
        }

        static void DoMapping()
        {
            Mapper.Initialize(cfg => { cfg.AddProfile<AutoMapperProfile>(); });

            List<Book> books = GetBooks(10, 5);
            List<Catalogue> catalogues = GetCatalogues(5, 1);
            List<Library> libs = GetLibraries(3, 3);

            var booksDto = Mapper.Map<List<BookDto>>(books);
            var books2 = Mapper.Map<List<Book>>(booksDto);
            var cataloguesDto = Mapper.Map<List<CatalogueDto>>(catalogues);
            var libDto = Mapper.Map<List<LibraryDto>>(libs);
        }

        static List<Book> GetBooks(int count, int startsFrom)
        {
            var result = new List<Book>();
            for (int i = 0; i < count; i++)
            {
                int curNo = startsFrom + i;
                result.Add(new Book() { Author = $"Book Author {curNo}", Name = $"Book Name {curNo}", Price = curNo });
            }
            return result;
        }

        static List<Catalogue> GetCatalogues(int count, int startsFrom)
        {
            var result = new List<Catalogue>();
            for (int i = 0; i < count; i++)
            {
                int curNo = startsFrom + i;
                int subCurNo = (startsFrom + i) * 10;
                int subCount = (count + curNo) % 7;
                result.Add(new Catalogue() {
                    Code = $"Catalogue Code {curNo}",
                    Id = curNo,
                    Name = $"Catalogue Name {curNo}",
                    Title = $"Catalogue Title {curNo}",
                    Type = $"Catalogue Type {curNo}",
                    Books = GetBooks(subCount, subCurNo)
                });
            }
            return result;
        }

        static List<Library> GetLibraries(int count, int startsFrom)
        {
            var result = new List<Library>();
            for (int i = 0; i < count; i++)
            {
                int curNo = startsFrom + i;
                int subCurNo = (startsFrom + i) * 10;
                int subCount = (count + curNo) % 7;
                result.Add(new Library()
                {
                    Address = $"Library Address {curNo}",
                    Name = $"Library Name {curNo}",
                    Catalogues = GetCatalogues(subCount, subCurNo)
                });
            }
            return result;
        }
    }
}
