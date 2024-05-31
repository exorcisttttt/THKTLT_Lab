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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ContentFrame.Navigate(typeof(HomePage)); //Điều hướng đên Page mặc định của Frame
        }

        private void MyNavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            FrameNavigationOptions navigationOptions = new FrameNavigationOptions(); //Tạo đối tượng Frame để chuyển hướng
            navigationOptions.TransitionInfoOverride = args.RecommendedNavigationTransitionInfo; //Chọn hiệu ứng chuyển trang thích hợp
            var selectedItem = MyNavigationView.SelectedItem; //Kiểm tra Item được chọn
            if (selectedItem == HomeItem)
            {
                ContentFrame.Navigate(typeof(HomePage)); //Chuyển hướng sang HomePage
            }
            else if (selectedItem == AddFriendItem)
            {
                ContentFrame.Navigate(typeof(AddFriendPage));
            }
            else if (selectedItem == ContactInfoItem)
            {
                ContentFrame.Navigate(typeof(ContactInfoPage));
            }
        }

        private void MyNavigationView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (ContentFrame.CanGoBack)
            {
                ContentFrame.GoBack();
            }
        }
    }
}
