using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using static System.Net.Mime.MediaTypeNames;

namespace MAUIAppEB
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int row = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            
                if (count == 1)
                    CounterBtn.Text = $"Clicked {count} time";
                else
                    CounterBtn.Text = $"Clicked {count} times";
           

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnMainClicked(object sender, EventArgs e)

        {

            for (int i = 0; i < 10; i++)
            {
                Table.AddRowDefinition(new RowDefinition { Height = GridLength.Star } );
                Table.Add(new Label
                {
                    Text = row.ToString(),

                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                    FontSize = 22
                }, 0, row);
                Table.Add(new Label
                {
                    Text = "Мастер и Маргарита",

                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                    FontSize = 22
                }, 1, row);
                Table.Add(new Label
                {
                    Text = "Булгаков Михаил Афанасьевич",
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                    FontSize = 22,
                    MaxLines = 1
                }, 2, row);
                Table.Add(new Label
                {
                    Text = "1.74 Мб",
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                    FontSize = 22
                }, 3, row);
                Table.Add(new Label
                {
                    Text = "EPUB",
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                    FontSize = 22
                }, 4, row);
                Table.Add(new Label
                {
                    Text = "* * * * *",
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                    FontSize = 22
                }, 5, row);
                Table.Add(new Button
                {
                    Text = "Скачать",
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                    HeightRequest = 50,
                    FontSize = 22
                }, 6, row);

                row++;
            }

        }
    }

}
