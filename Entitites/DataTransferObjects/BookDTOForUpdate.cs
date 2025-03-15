using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entitites.DataTransferObjects
{
    public record BookDTOForUpdate(int Id,String Title,decimal Price);

}