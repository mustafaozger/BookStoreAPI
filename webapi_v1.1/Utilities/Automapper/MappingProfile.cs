using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Entitites.DataTransferObjects;
using Entitites.Models;

namespace webapi_v1._1.Utilities.Automapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<BookDTOForUpdate,BookModel>();   
        }
    }
}