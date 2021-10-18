using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WFP.Model;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WFP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icons> Icons;

        private ObservableCollection<Contacts> contacts;

        public MainPage()
        {
            this.InitializeComponent();
            Icons = new List<Icons>();

            Icons.Add(new Icons { IconPath = "Assets/image1.jpg" });
            Icons.Add(new Icons { IconPath = "Assets/image2.jpg" });
            Icons.Add(new Icons { IconPath = "Assets/image3.jpg" });

            contacts = new ObservableCollection<Contacts>();
           
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string image = ((Icons)ImageComboBox.SelectedValue).IconPath;
            Contacts.Add(new Contacts { Product = ProductTextBox.Text, Description = DescriptionTextBox.Text, Image = image });
            ProductTextBox.Text = "";
            DescriptionTextBox.Text = "";
            ImageComboBox.SelectedIndex = -1;


            ProductTextBox.Focus(FocusState.Programmatic);
        }
    }
}
