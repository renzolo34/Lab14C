using Lab14C.Model;
using Lab14C.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace Lab14C
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CursoService service = new CursoService();
            List<Curso> curso = new List<Curso>();

            for (int i = 0; i < 3; i++)
                curso.Add(new Curso { Name = txtName.Text, Description = txtDescription.Text, Credito = txtCredito.Text, FechaInicio = txtFechaInicio.Text });

            //service.Create(new Person { LastName = txtLastName.Text, FirstName = txtName.Text });

            service.CreateRange(curso);


        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            CursoService service = new CursoService();
            lvPeople.ItemsSource = service.Get();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            CursoService service = new CursoService();
            lvPeople.ItemsSource = service.GetByText(txtFilter.Text.Trim());
        }
    }
}
