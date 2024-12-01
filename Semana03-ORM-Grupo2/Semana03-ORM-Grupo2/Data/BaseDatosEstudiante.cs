using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Semana03_ORM_Grupo2.Models;

    public class BaseDatosEstudiante : DbContext
    {
        public BaseDatosEstudiante (DbContextOptions<BaseDatosEstudiante> options)
            : base(options)
        {
        }

        public DbSet<Semana03_ORM_Grupo2.Models.Estudiante> Estudiante { get; set; } = default!;
    }
