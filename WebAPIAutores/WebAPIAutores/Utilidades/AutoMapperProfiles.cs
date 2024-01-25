using AutoMapper;
using WebAPIAutores.DTOs;
using WebAPIAutores.Entidades;

namespace WebAPIAutores.Utilidades
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AutorCreacionDTO, Autor>();  //Configura un mapeo de <dato1, a dato2>
            CreateMap<Autor, AutorDTO>();
            CreateMap<LibroCreacionDTO, Libro>();
            CreateMap<Libro, LibroDTO>();
        }
    }
}
