using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entitites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore
{    public class BookConfig : IEntityTypeConfiguration<BookModel>
    {
        public void Configure(EntityTypeBuilder<BookModel> builder)
        {
           /* builder.HasData(
                new BookModel{bookId=1,bookName="Karagöz",bookPrice=21},
                new BookModel{bookId=2,bookName="Ve",bookPrice=21},                
                new BookModel{bookId=3,bookName="Hacivar",bookPrice=21}
            );
            */
        
        }
    }
}