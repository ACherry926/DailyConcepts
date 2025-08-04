using AutoMapper;
using Day28Concepts.Data;
using Day28Concepts.Model;

namespace Day28Concepts.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Books, BookModel>().ReverseMap();
        }
    }
}
