using AutoMapper;
using Day29Concepts.Data;
using Day29Concepts.Model;

namespace Day29Concepts.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Books, BookModel>().ReverseMap();
        }
    }
}
