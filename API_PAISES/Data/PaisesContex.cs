using System;
using API_PAISES.Model;
using Microsoft.EntityFrameworkCore;

namespace API_PAISES.Data

{
    public class PaisesContex: DbContext 
    {
        public PaisesContex(DbContextOptions<PaisesContex> opt) : base(opt) 
        {
         
        }
        public DbSet<Paises> paises { get; set; }   
    }
}
