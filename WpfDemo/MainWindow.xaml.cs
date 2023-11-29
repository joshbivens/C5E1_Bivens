using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Assignment> scores = new List<Assignment>();
        public MainWindow()
        {
            InitializeComponent();
            lbScores.ItemsSource = scores;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Student st = new Student();
            st.FirstName = txbFirst.Text;
            st.LastName = txbLast.Text;
            st.StudentNumber = txbStudentNumber.Text;
            st.Major = txbMajor.Text;
            st.Scores = scores;
            txbResults.Text = st.ToString();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Assignment assignment = new Assignment();
            assignment.Score = int.Parse(txbScore.Text);
            assignment.Title = txbTitle.Text;
            scores.Add(assignment);
            lbScores.Items.Refresh();
        }
    }
}
