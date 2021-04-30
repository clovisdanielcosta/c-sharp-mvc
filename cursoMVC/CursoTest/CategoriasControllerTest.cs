using cursoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoTest
{
    class CategoriasControllerTest
    {
        private readonly Mock<DbSet<Categoria>> mockSet;
        private readonly Mock<ConText> mockContext;
        private readonly CategoriasControllerTest _categoria;
        
        public CategoriasControllerTest()
        {
            
        }

    }
}
