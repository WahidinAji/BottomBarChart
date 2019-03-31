using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestChart.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestChart
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PieChart : ContentPage
	{
        PieChartViewModel vm;
		public PieChart ()
		{
            vm = new PieChartViewModel();
			InitializeComponent ();
            this.BindingContext = vm;
		}
	}
}