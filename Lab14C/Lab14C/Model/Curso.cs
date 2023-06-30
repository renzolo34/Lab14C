using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lab14C.Model
{
    public class Curso 
    {
        public int CursoId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Credito { get; set; }
        public string FechaInicio { get; set; }
    }
}