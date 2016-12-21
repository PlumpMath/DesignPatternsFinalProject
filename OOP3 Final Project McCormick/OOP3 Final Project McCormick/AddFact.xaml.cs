using BadYear;
using BadYearIterators;
using System;
using System.Windows;
using System.Windows.Controls;

namespace OOP3_Final_Project_McCormick
{
    /// <summary>
    /// Interaction logic for AddFact.xaml
    /// </summary>
    public partial class AddFact : Window
    {
        private IHorribleYear selectYear;

        private Year1942 year42;

        private Year1968 year68;

        private Year2016 year2016;

        public AddFact(IHorribleYear year)
        {
            this.selectYear = year;

            if (year is Year1942)
            {
                this.year42 = this.selectYear as Year1942;
            }
            else if (year is Year1968)
            {
                this.year68 = this.selectYear as Year1968;
            }
            else if (year is Year2016)
            {
                this.year2016 = this.selectYear as Year2016;
            }


            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            string fact = this.addFactTextBox.Text;

            if (this.selectYear is Year1942)
            {
                this.year42.Add(fact);
            }
            else if (this.selectYear is Year1968)
            {
                this.year68.Add(fact);
            }
            else if (this.selectYear is Year2016)
            {
                this.year2016.Add(fact);
            }
            else
            {
                MessageBox.Show("Not valid");
            }

            this.DialogResult = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.yearLabel.Content = this.selectYear.ToString();
        }
    }
}
