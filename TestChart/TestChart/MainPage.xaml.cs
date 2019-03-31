using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestChart.ViewModels;
using Xamarin.Forms;

namespace TestChart {
    public partial class MainPage : ContentPage {

        MainPageViewModel vm;
        public MainPage() {
            vm = new MainPageViewModel();
            InitializeComponent();
            this.BindingContext = vm;
        }

        #region
        private async void btnPieCharts_Clicked(object sender, EventArgs e) {
            await Navigation.PushModalAsync(new PieChart());
        }
        #endregion
    }
}
