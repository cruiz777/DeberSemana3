using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DeberSemana2
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string user)
        {
            
            InitializeComponent();
            txtnombre.Text = user;
        }

        private void suma_Clicked(object sender, EventArgs e)
        {
            double nt1 =Convert.ToDouble( ns1.Text);
            double ntx1 = Convert.ToDouble(ex1.Text);
            double pp1 = (nt1 * 0.3) + (ntx1 * 0.2);
            double nt2 = Convert.ToDouble(ns2.Text);
            double ntx2 = Convert.ToDouble(ex2.Text);
            double pp2 = (nt2 * 0.3) + (ntx2 * 0.2);
            double suma =pp1 +pp2;
            p1.Text = Convert.ToString(pp1);
            p2.Text = Convert.ToString(pp2);
            nfinal.Text = Convert.ToString(suma);
            if (suma>=7)
            {
                DisplayAlert("Resultado", "Aprobado", "OK");
            }
            if (suma <5)
            {
                DisplayAlert("Resultado", "Reprobado", "OK");
            }
            if (suma >= 5 && suma<=6.9)
            {
                DisplayAlert("Resultado", "Complementario", "OK");
            }


        }
    }
}
