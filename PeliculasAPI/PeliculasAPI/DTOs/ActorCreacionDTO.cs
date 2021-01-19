using Microsoft.AspNetCore.Http;
using PeliculasAPI.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.DTOs
{

    //DTOS
    public class ActorCreacionDTO: ActorPatchDTO
    {
      
        [PesoArchivoValidacion(PesoMaximoEnMegaBytes: 4)]
        [TypeFileValidation(FileGroup.Imagen)]
        public IFormFile Foto { get; set; }

    }
}
