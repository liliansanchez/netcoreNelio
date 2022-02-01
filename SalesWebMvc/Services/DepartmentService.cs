using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context) 
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            //aviso ao compilador que estou fazendo uma chamada assincrona e nao bloqueio a aplicacao
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

        public void Insert(Department obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        internal Task FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
