using Microsoft.EntityFrameworkCore;
using Apice_ll_Trimestre.Models;

namespace Apice_ll_Trimestre.Datos
{
    public class ApplicationDbContex : DbContext
    {

        public ApplicationDbContex(DbContextOptions
          <ApplicationDbContex> options) : base(options)
        {

        }


    }
}
