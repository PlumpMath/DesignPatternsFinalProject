using BadYear;
using BadYearIterators;
using System;
using System.Windows;
using System.Windows.Controls;

namespace OOP3_Final_Project_McCormick
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IHorribleYear year2016;

        private IHorribleYear selectedYear;

        private IIterator yi;

        private IIterator selectedIterator;

        public MainWindow()
        {
            InitializeComponent();
            this.year2016 = new Year2016();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.yi = this.year2016.CreateIterator();
            this.badFact2016.Text = "2016 is arguably one of the worst years in American history. See how it stacks up against other years that are considered equally as bad.";
            this.badFactYear.Text = "Select a year. Then click 'Compare Facts' to see if 2016 was really such a bad year.";

            this.yearComboBox.ItemsSource = Enum.GetValues(typeof(YearEnum));
            this.yearComboBox.SelectedItem = YearEnum.Year1968;
        }

        private void getFactsButton_Click(object sender, RoutedEventArgs e)
        {  
            try
            {
                this.badFactYear.Text = this.selectedIterator.Next();
                this.badFact2016.Text = this.yi.Next();
            }
            catch (ArgumentOutOfRangeException)
            {
                if (this.yi.IsDone())
                {
                    this.badFact2016.Text = "Out of facts to display.";
                    this.next2016button.IsEnabled = false;
                }
                if (this.selectedIterator.IsDone())
                {
                    this.badFactYear.Text = "Out of facts to display.";
                    this.nextFactButton.IsEnabled = false;
                }
            }
        }

        private void yearComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try {
                // Get the selected year.
                YearEnum yearEnum = (YearEnum)this.yearComboBox.SelectedItem;
                this.selectedYear = BadYearType.ChooseBadYear(yearEnum);
                this.selectedIterator = this.selectedYear.CreateIterator();
                this.labelYear.Content = this.selectedYear.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void remove2016fact_Click(object sender, RoutedEventArgs e)
        {
            var instance = RemoveMessage.Instance;

            MessageBox.Show(instance.DisplayInstance());
        }

        private void reset2016button_Click(object sender, RoutedEventArgs e)
        {
            this.yi.First();
            this.badFact2016.Text = this.yi.CurrentItem();

            if (!this.next2016button.IsEnabled)
            {
                this.next2016button.IsEnabled = true;
            }
        }

        private void resetFactButton_Click(object sender, RoutedEventArgs e)
        {
            this.selectedIterator.First();
            this.badFactYear.Text = this.selectedIterator.CurrentItem();

            if (!this.nextFactButton.IsEnabled)
            {
                this.nextFactButton.IsEnabled = true;
            }
        }

        private void nextFactButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.badFactYear.Text = this.selectedIterator.Next();            
            }
            catch (ArgumentOutOfRangeException)
            {
                if (this.selectedIterator.IsDone())
                {
                    this.badFactYear.Text = "Out of facts to display.";
                    this.nextFactButton.IsEnabled = false;
                }
                else
                {
                    this.badFactYear.Text = "Uh oh. Unexpected error.";
                }
            }
        }

        private void next2016button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.badFact2016.Text = this.yi.Next();
            }
            catch (ArgumentOutOfRangeException)
            {
                if (this.yi.IsDone())
                {
                    this.badFact2016.Text = "Out of facts to display.";
                    this.next2016button.IsEnabled = false;
                }
            }
        }

        private void add2016fact_Click(object sender, RoutedEventArgs e)
        {
            AddFact window = new AddFact(this.selectedYear);

            window.ShowDialog();
        }
    }
}
