using Lab14C.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab14C.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CursoView : ContentView
    {
        public CursoView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelCurso();
        }
    }
}