using Lab14C.Model;
using Lab14C.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab14C.ViewModel
{
    public class ViewModelCurso : BaseViewModel
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }


        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Curso> cursos;
        public List<Curso> Cursos
        {
            get { return this.cursos; }
            set { SetValue(ref this.cursos, value); }
        }


        public ICommand SearchCommand { get; set; }

        public ViewModelCurso()
        {
            SearchCommand = new Command(() =>
            {
                CursoService service = new CursoService();
                Cursos = service.GetByText(Filter);
                if (Cursos.Count > 3)
                    Color = "Red";
                else
                    Color = "Blue";

            });

        }
    }
}