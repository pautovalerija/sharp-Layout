using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace LayoutPautova2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class iseseivtoo : ContentPage
    {
    
        Label lbl, lbl2;
        Grid grid;
        public iseseivtoo()
        {
            grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },                   
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(165) },
                    new ColumnDefinition { Width = new GridLength(185) }
                    
                }

            };
            //----------------------------------------label 1-----------------------------------------------------
            lbl = new Label

            {
                Text = "Количество значений",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.StartAndExpand

            };
            //-----------------------------------------stepper----------------------------------------------------
            Stepper stepper = new Stepper
            {
                Minimum = 0,
                Maximum = 50,
                Increment = 0.5,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.StartAndExpand,
            };
            stepper.ValueChanged += Stepper_ValueChanged; ;
            this.Content = new StackLayout { Children = { lbl, stepper } };
            grid.Children.Add(lbl, 0, 0);
            grid.Children.Add(stepper, 0, 1);



            //-----------------------------------------label 2---------------------------------------------------
            lbl2 = new Label
            {
                Text = "Слайдер",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.EndAndExpand
            };
            
            //----------------------------------------slider-----------------------------------------------------
      
            Slider slider = new Slider
            {
                Minimum = 0,
                Maximum = 50,
                Value = 30
            };

            slider.ValueChanged += Slider_ValueChanged;
                 
            this.Content = new StackLayout { Children = { lbl2, slider } };
            grid.Children.Add(lbl2, 1, 0);
            grid.Children.Add(slider, 1, 0);

            Content = grid;
            grid.BackgroundColor = Color.BurlyWood;

        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbl2.Text = String.Format("Выбрано: {0:F1}", e.NewValue);
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lbl.Text = String.Format("Выбрано: {0:F1}", e.NewValue);
        }

        

                
    }
           
};        