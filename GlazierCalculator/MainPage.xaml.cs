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

namespace GlazierCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void SliderChange(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider sliderObj = sender as Slider;
            double numChange = sliderObj.Value;
            SliderDisplay.Text = numChange.ToString();
        }

        private void CalcBtn_Click(object sender, RoutedEventArgs e)
        {
            double widthIn = Convert.ToDouble(WidthInput.Text);
            double heightIn = Convert.ToDouble(HeightInput.Text);
            double glass = 2 * (widthIn * heightIn);
            double wood = 2 * (widthIn + heightIn) * 3.25;
           
            WoodOutput.Text = wood.ToString() + " Ft";
            GlassOutput.Text = glass.ToString() + " Sq ft";
            
            
        }

        private void Validate_key(object sender, KeyRoutedEventArgs e)
        {
            TextBox box = sender as TextBox;

            string empty = "";
            char keyUp = Convert.ToChar(e.Key);
            if (!char.IsDigit(keyUp))
            {
                box.Text = empty;
            }
            if (box.Text.Length > 2)
            {
                char[] input = box.Text.ToCharArray();
                box.Text = input[0].ToString() + input[1].ToString();
            }
        }
    }
}
