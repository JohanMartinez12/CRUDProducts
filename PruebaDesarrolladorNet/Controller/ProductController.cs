using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaDesarrolladorNet.Data;
using PruebaDesarrolladorNet.Model;

namespace PruebaDesarrolladorNet.Controller
{
    internal class ProductController 
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public void Agregar(Product producto)
        {
            _context.Products.Add(producto);
            _context.SaveChanges();

        }
        public List<Product> GetAll()
            => _context.Products.ToList();

        public void Update(int id, Action<Product> ProductModif)
        {
            var producto = _context.Products.Find(id);
            if (producto != null)
            {
                ProductModif(producto);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("El Id Mencionado no Existe.");
            }
        }

        public void Delete(int id)
        {
            var producto = _context.Products.Find(id);
            if (producto != null)
            {
                _context.Products.Remove(producto);
                _context.SaveChanges();
            }
        }
    }
}
