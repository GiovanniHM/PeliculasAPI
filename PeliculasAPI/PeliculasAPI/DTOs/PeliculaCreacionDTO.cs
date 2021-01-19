﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeliculasAPI.Helpers;
using PeliculasAPI.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.DTOs
{
    public class PeliculaCreacionDTO: PeliculasPatchDTO
    {
       
        [PesoArchivoValidacion(4)]
        [TypeFileValidation(FileGroup.Imagen)]
        public IFormFile Poster { get; set; }


        [ModelBinder(BinderType = typeof(TypeBinder<List<int>>))]
        public List<int> GenerosIDs { get; set; }

        [ModelBinder(BinderType = typeof(TypeBinder<List<ActorPeliculasCreacionDTO>>))]
        public List<ActorPeliculasCreacionDTO> Actores { get; set; }


    }
}
