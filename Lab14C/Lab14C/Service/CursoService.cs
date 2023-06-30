using Lab14C.DataContext;
using Lab14C.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lab14C.Service
{
    public class CursoService
    {
        private readonly AppDbContext _context;

        public CursoService() => _context = App.GetContext();

        public bool Create(Curso item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Curso.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateRange(List<Curso> items)
        {
            try
            {
                _context.Curso.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            { 
                return false; 
            }
        }

        public List<Curso> Get() 
        {
            return _context.Curso.ToList();
        }
        public List<Curso> GetByText(string text)
        {
            return _context.Curso.Where(x => x.Name.Contains(text)).ToList();
        }
    }
}