using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace THKTLT_Lab6
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = new UserInformationViewModel();
        }
        public UserInformationViewModel ViewModel { get; set; } //Tạo property

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = userNameTextBox.Text;
                uint age = (ushort)userAgeSlider.Value;
                uint id = ushort.Parse(userIDTextBox.Text);
                UserInformation userInfo = new UserInformation(name, age, id);
                inforTextBlock.Text = userInfo.OneLineInformation;
            }
            catch (Exception error)
            {
                inforTextBlock.Text = error.Message;
            }
            
        }
    }
}
