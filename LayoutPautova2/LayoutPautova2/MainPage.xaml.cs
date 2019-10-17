using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutPautova2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Grid grid;
        private Button btn1;
        //private Button btn2;
        //private Button btn3;
        public MainPage()
        {
            grid = new Grid
            {
                RowDefinitions =
                {
                new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }
            };
            Button btn1 = new Button();
            //Button btn2 = new Button();
            //Button btn3 = new Button();
            btn1.BackgroundColor = Color.Yellow;
            //btn2.BackgroundColor = Color.Yellow;
            //btn3.BackgroundColor = Color.Yellow;
            grid.Children.Add(btn1, 0, 0);
           //grid.Children.Add(btn2, 0, 1);
            //grid.Children.Add(btn3, 0, 2);

            btn1.Clicked += Btn1_Clicked;
            //btn2.Clicked += Btn2_Clicked;
            //btn3.Clicked += Btn3_Clicked;

            Content = grid;
        }

        //private async void Btn3_Clicked(object sender, EventArgs e)
        //{
           //await Navigation.PushAsync(new Kolmapäev());
        //}

        //private async void Btn2_Clicked(object sender, EventArgs e)
        //{
           //await Navigation.PushAsync(new Teisipäev());
        //}

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new iseseivtoo());
        }
    }
}
