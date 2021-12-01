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
using Windows.Media.SpeechRecognition;
using Windows.Media.SpeechSynthesis;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPApp2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Rules MyRules;
        Random number;          // Set up the random number generator

        int wheel1;			       // Variable to store the dice roll
        int wheel2;			       // Variable to store the dice roll
        int wheel3;                // Variable to store the dice roll
        Boolean wheelClicked = false;          // Variable to store if the wheel was clicked 
        Boolean wheel2Clicked = false;          // Variable to store if the wheel was clicked        
        Boolean wheel3Clicked = false;          // Variable to store if the wheel was clicked        
        int dollars;       // Variable to store the dollars
                           // Sets the startup of the game 
        Boolean loadUp = true;
        SpeechSynthesizer reader;

        public MainPage()
        
        {
            this.InitializeComponent();
            number = new Random(DateTime.Now.Millisecond); // Switch on random number generator
            buttonPlay.Visibility = Visibility.Collapsed;
            MyRules = new Rules();
            reader = new SpeechSynthesizer();

        }

        private void buttonAddCash_Click(object sender, RoutedEventArgs e)
        { 

            try
            {
                {
                    Talk(Message.Text);
                }
                dollars = dollars + int.Parse(Cash.Text);  // Enter cash
                TextBlock.Text = "You Have $" + dollars;  // Display the dollars
                Talk(TextBlock.Text);


            }
            catch (FormatException exc)
            {
                // Output the division  to the screen
                Message.Text = exc.Message + " : Please enter a number";
            }

            catch (Exception exc)
            {
                Message.Text = "The following exception was generated : " + exc.Message;
            }
            {
                if (dollars > 0) buttonPlay.Visibility = Visibility.Visible;
                
            }

        }

        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
            

            if (loadUp == true)
            {
                wheelClicked = false;
                wheel2Clicked = false;
                wheel3Clicked = false;
                loadUp = false;
            }


            if (wheelClicked == false) wheel1 = number.Next(1, 7);              // Generate a random number between 1 and 6 
            if (wheel2Clicked == false) wheel2 = number.Next(1, 7);              // Generate a random number between 1 and 6 
            if (wheel3Clicked == false) wheel3 = number.Next(1, 7);              // Generate a random number between 1 and 6 


            dollars = dollars - 1;                                  // It costs $1 dollar to play

            if (wheelClicked == true) dollars = dollars - 20;      // Charge $20 to hold
            if (wheel2Clicked == true) dollars = dollars - 20;      // Charge $20 to hold
            if (wheel3Clicked == true) dollars = dollars - 20;      // Charge $20 to hold


           TextBlock.Text = "You have $" + dollars;         // Display the dollars



            if (wheelClicked == false)
            {
                //if (wheel1 == 1) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/lose.png",
                //                                                    UriKind.RelativeOrAbsolute));
                //else if (wheel1 == 2) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/spade.png",
                //                                                           UriKind.RelativeOrAbsolute));
                //else if (wheel1 == 3) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/club.png",
                //                                                           UriKind.RelativeOrAbsolute));
                //else if (wheel1 == 4) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/heart.png",
                //                                                           UriKind.RelativeOrAbsolute));
                //else if (wheel1 == 5) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/diamond.png",
                //                                                           UriKind.RelativeOrAbsolute));
                //else imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/win.png",
                //                                                  UriKind.RelativeOrAbsolute));
                //Utils.load(wheel1, imageWheel);
                MyRules.load(wheel1, imageWheel);

            }
            if (wheel2Clicked == false)

            {
                ////if (wheel2 == 1) imageWheel2.Source = new BitmapImage(new Uri("ms-appx:///Assets/lose.png",
                ////                                                 UriKind.RelativeOrAbsolute));
                ////else if (wheel2 == 2) imageWheel2.Source = new BitmapImage(new Uri("ms-appx:///Assets/spade.png",
                ////                                                           UriKind.RelativeOrAbsolute));
                ////else if (wheel2 == 3) imageWheel2.Source = new BitmapImage(new Uri("ms-appx:///Assets/club.png",
                ////                                                           UriKind.RelativeOrAbsolute));
                ////else if (wheel2 == 4) imageWheel2.Source = new BitmapImage(new Uri("ms-appx:///Assets/heart.png",
                ////                                                           UriKind.RelativeOrAbsolute));
                ////else if (wheel2 == 5) imageWheel2.Source = new BitmapImage(new Uri("ms-appx:///Assets/diamond.png",
                ////                                                           UriKind.RelativeOrAbsolute));
                ////else imageWheel2.Source = new BitmapImage(new Uri("ms-appx:///Assets/win.png",
                ////                                                  UriKind.RelativeOrAbsolute));
                //Utils.load(wheel2, imageWheel2);
                MyRules.load(wheel2, imageWheel2);
            }

            if (wheel3Clicked == false)
            {
                //if (wheel3 == 1) imageWheel3.Source = new BitmapImage(new Uri("ms-appx:///Assets/lose.png",
                //                                                  UriKind.RelativeOrAbsolute));
                //else if (wheel3 == 2) imageWheel3.Source = new BitmapImage(new Uri("ms-appx:///Assets/spade.png",
                //                                                           UriKind.RelativeOrAbsolute));
                //else if (wheel3 == 3) imageWheel3.Source = new BitmapImage(new Uri("ms-appx:///Assets/club.png",
                //                                                           UriKind.RelativeOrAbsolute));
                //else if (wheel3 == 4) imageWheel3.Source = new BitmapImage(new Uri("ms-appx:///Assets/heart.png",
                //                                                           UriKind.RelativeOrAbsolute));
                //else if (wheel3 == 5) imageWheel3.Source = new BitmapImage(new Uri("ms-appx:///Assets/diamond.png",
                //                                                           UriKind.RelativeOrAbsolute));
                //else imageWheel3.Source = new BitmapImage(new Uri("ms-appx:///Assets/win.png",
                //                                                  UriKind.RelativeOrAbsolute));
                //Utils.load(wheel3, imageWheel3);
                MyRules.load(wheel3, imageWheel3);

            }
            // Set up the following game rules for the pay-outs
            imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/gamebackground.png",
                                                  UriKind.RelativeOrAbsolute));

            // Six – six – six: Win $60 display win image.
            if ((wheel1 == 6) && (wheel2 == 6) && (wheel3 == 6))
            {
                dollars = dollars + 60;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Five – five – five: Win $50 display win image.
            if ((wheel1 == 5) && (wheel2 == 5) && (wheel3 == 5))
            {
                dollars = dollars + 50;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Four – four – four: Win $40 display win image.
            if ((wheel1 == 4) && (wheel2 == 4) && (wheel3 == 4))
            {
                dollars = dollars + 40;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Three – three – three: Win $30 display win image.
            if ((wheel1 == 3) && (wheel2 == 3) && (wheel3 == 3))
            {
                dollars = dollars + 30;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Two – two – two: Win $20 display win image.
            if ((wheel1 == 2) && (wheel2 == 2) && (wheel3 == 2))
            {
                dollars = dollars + 20;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }


            // Five – five – six: Win $10 display win image.
            if ((wheel1 == 5) && (wheel2 == 5) && (wheel3 == 6))
            {
                dollars = dollars + 10;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Four – four – six: Win $8 display win image.
            if ((wheel1 == 4) && (wheel2 == 4) && (wheel3 == 6))
            {
                dollars = dollars + 8;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Three – three – six: Win $6 display win image.
            if ((wheel1 == 3) && (wheel2 == 3) && (wheel3 == 6))
            {
                dollars = dollars + 6;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Two – two – six: Win $4 display win image.
            if ((wheel1 == 2) && (wheel2 == 2) && (wheel3 == 6))
            {
                dollars = dollars + 4;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Lose $2 for every one rolled on a wheel and display lose image.
            if (wheel1 == 1)
            {
                dollars = dollars - 2;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/LoseGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Lose $2 for every one rolled on a wheel and display lose image.
            if (wheel2 == 1)
            {
                dollars = dollars - 2;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/LoseGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }
            // Lose $2 for every one rolled on a wheel and display lose image.
            if (wheel3 == 1)
            {
                dollars = dollars - 2;
                imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/LoseGame.jpg",
                                                      UriKind.RelativeOrAbsolute));
            }


            wheelClicked = false;                 // Reset the hold after play
            imageWheel.Opacity = 1f;              // Reset the hold brightness after play            

            wheel2Clicked = false;                 // Reset the hold after play
            imageWheel2.Opacity = 1f;              // Reset the hold brightness after play

            wheel3Clicked = false;                 // Reset the hold after play
            imageWheel3.Opacity = 1f;              // Reset the hold brightness after play


            if (dollars <= 0)
            {
                buttonPlay.Visibility = Visibility.Collapsed;
                dollars = 0;
            }
            TextBlock.Text = "You have $" + dollars;         // Display the dollars



        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            imageWheel3.Source = new BitmapImage(new Uri("ms-appx:///Assets/heart.png",
                                                              UriKind.RelativeOrAbsolute));
            imageWheel2.Source = new BitmapImage(new Uri("ms-appx:///Assets/heart.png",
                                                              UriKind.RelativeOrAbsolute));
            imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/heart.png",
                                                              UriKind.RelativeOrAbsolute));

        }






        //public void tag(int wheel, Image imageWheel)
        //{
        //    if (wheelClicked == false)
        //    {
        //        wheelClicked = true;
        //        imageWheel.Opacity = 0.5f;
        //    }
        //    else
        //    {
        //        wheelClicked = false;
        //        imageWheel.Opacity = 1f;
        //    }

        private void imageWheel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //if (wheelClicked == false)
            //{
            //    wheelClicked = true;
            //    imageWheel.Opacity = 0.5f;
            //}
            //else
            //{
            //    wheelClicked = false;
            //    imageWheel.Opacity = 1f;
            //}
            //Utils.tag(wheelClicked, imageWheel);
            MyRules.tag(wheelClicked, imageWheel);


            //if(wheel2Clicked == false)
            //{
            //    wheel2Clicked = true;
            //    imageWheel2.Opacity = 0.5f;
            //}
            //else
            //{
            //    wheel2Clicked = false;
            //    imageWheel2.Opacity = 1f;
            //}
            //Utils.tag(wheel2Clicked, imageWheel2);
            MyRules.tag(wheel2Clicked, imageWheel2);

            //if (wheel3Clicked == false)
            //{
            //    wheel3Clicked = true;
            //    imageWheel3.Opacity = 0.5f;
            //}
            //else
            //{
            //    wheel3Clicked = false;
            //    imageWheel3.Opacity = 1f;
            //}
            //Utils.tag(wheel3Clicked, imageWheel3);
            MyRules.tag(wheel3Clicked, imageWheel3);

        }
        private async void Talk(String message)
        {
            var stream = await reader.SynthesizeTextToStreamAsync(message);
            media.SetSource(stream, stream.ContentType);
            media.Play();
        }

        //public void load(int Wheel, Image imagewheel )
        //{
            
        //        if (Wheel == 1) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/lose.png",
        //                                                            UriKind.RelativeOrAbsolute));
        //        else if (Wheel == 2) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/spade.png",
        //                                                                   UriKind.RelativeOrAbsolute));
        //        else if (Wheel == 3) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/club.png",
        //                                                                   UriKind.RelativeOrAbsolute));
        //        else if (Wheel == 4) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/heart.png",
        //                                                                   UriKind.RelativeOrAbsolute));
        //        else if (Wheel == 5) imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/diamond.png",
        //                                                                   UriKind.RelativeOrAbsolute));
        //        else imageWheel.Source = new BitmapImage(new Uri("ms-appx:///Assets/win.png",
        //                                                          UriKind.RelativeOrAbsolute));
            
        //}
        
    }
}
