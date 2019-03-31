using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChartBarBot.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarPage : TabbedPage
    {
        public BarPage ()
        {
            InitializeComponent();
        }
    }
}