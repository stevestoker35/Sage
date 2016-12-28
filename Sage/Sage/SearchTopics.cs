using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sage
{
    public class SearchTopics : ContentPage
    {
        SearchBar searchTopicBar = new SearchBar
        {
            Placeholder = "Search Topics",
            
        };

        Grid resultsGrid = new Grid
        {
            IsVisible = true,
            BackgroundColor = Color.White, 
            Padding = 3,
            RowSpacing = 20,
            
        };
        
        Stepper rowStepper = new Stepper
        {
            Value = 5,
            Minimum = 0,
            Maximum = 10,
            Increment = 1,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };
       
        Stepper columnStepper = new Stepper
        {
            Value = 5,
            Minimum = 0,
            Maximum = 10,
            Increment = 1,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };

        Label heightLabel = new Label();
        Label widthLabel = new Label();

        public SearchTopics()
        {
            Title = "Topics";
            rowStepper.ValueChanged += OnRowStepperValueChanged;
            columnStepper.ValueChanged += OnColumnStepperValueChanged;
            LayoutResultsGrid((int)rowStepper.Value, (int)columnStepper.Value);

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = { rowStepper, heightLabel, columnStepper, widthLabel, searchTopicBar, resultsGrid }
            };
        }

        void OnRowStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            heightLabel.Text = String.Format("Stepper value is {0:F1}", e.NewValue);
            LayoutResultsGrid((int) rowStepper.Value, (int) columnStepper.Value);
        }

        void OnColumnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            widthLabel.Text = String.Format("Stepper value is {0:F1}", e.NewValue);
            LayoutResultsGrid((int)rowStepper.Value, (int)columnStepper.Value);
        }

        void LayoutResultsGrid (int numRows, int numColumns)
        {
            resultsGrid.Children.Clear();

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    resultsGrid.Children.Add(new Label { Text = i + ", " + j, TextColor = Color.Black }, j, i);
                }
            }
        }
    }
}
