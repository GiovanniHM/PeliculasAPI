using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Validations
{
    public class TypeFileValidation : ValidationAttribute
    {
        private readonly string[] fileType;

        public TypeFileValidation(string[] FileType) {
            fileType = FileType;
        }

        public TypeFileValidation(FileGroup fileGroup) {

            if (fileGroup == FileGroup.Imagen) {

                fileType = new string[] { "image/jpg", "image/png", "image/gif" };
            }

            if (fileGroup == FileGroup.MicrodoftFile){ 
                fileType = new string[] { "application/vnd.openxmlformats-officedocument.wordprocessingml.document" };
            }
        
        }



        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            IFormFile formFile = value as IFormFile;

            if (formFile == null)
            {

                return ValidationResult.Success;

            }


            if (!fileType.Contains(formFile.ContentType)) {
                return new ValidationResult($"Tiene que se uno de los siguientes archivos: {string.Join(",", fileType)}");
            }
            return ValidationResult.Success;
        }
    }
}
