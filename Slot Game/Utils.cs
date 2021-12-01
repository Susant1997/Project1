using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace UWPApp2
{
    class Utils
    {

        public static void load(int Wheel, Image imageWheel)
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
        public static void tag(Boolean wheelClicked, Image imageWheel)
        {
            if (wheelClicked == false)
            {
                wheelClicked = true;
                imageWheel.Opacity = 0.5f;
            }
            else
            {
                wheelClicked = false;
                imageWheel.Opacity = 1f;
            }
        }
    }
}
