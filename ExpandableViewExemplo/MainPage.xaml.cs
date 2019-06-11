using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Expandable;

namespace ExpandableViewExemplo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
            lblStatus.Text = "Fechado";
        }

        public void Handle_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            switch (e.Status)
            {
                case ExpandStatus.Collapsing:
                    lblStatus.Text = "Fechado";
                    break;
                case ExpandStatus.Expanding:
                    lblStatus.Text = "Aberto";
                    break;
                default:
                    return;
            }
        }
    }
}
