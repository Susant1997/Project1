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
using Windows.UI.Xaml.Media.Imaging;

namespace UWPApp2
{
    public partial class Rules : Page
    {
        public void load(int Wheel, Image imageWheel)
        {
            if (Wheel == 1) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/lose.png",
                                                                    UriKind.RelativeOrAbsolute));
            else if (Wheel == 2) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/spade.png",
                                                                       UriKind.RelativeOrAbsolute));
            else if (Wheel == 3) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/club.png",
                                                                       UriKind.RelativeOrAbsolute));
            else if (Wheel == 4) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/heart.png",
                                                                       UriKind.RelativeOrAbsolute));
            else if (Wheel == 5) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/diamond.png",
                                                                       UriKind.RelativeOrAbsolute));
            else imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/win.png",
                                                              UriKind.RelativeOrAbsolute));

        }
        public void tag(Boolean wheelClicked, Image imageWheel)
        {
            if (wheelClicked == false)
            {
                wheelClicked = true;
                imageWheel.Opacity = 1f;
            }
            else
            {
                wheelClicked = false;
                imageWheel.Opacity = 2f;
            }
        }
    }


}

