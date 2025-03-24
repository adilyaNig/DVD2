using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using DVD.Connection;
using DVD.functions;

namespace DVD.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static ObservableCollection<Film> filmList {  get; set; }
        public MainPage()
        {
            InitializeComponent();
            filmList = FilmFunction.GetFilms();
            this.DataContext = this;
        }

        private void LvMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void cbFiltr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tbSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            filmList = FilmFunction.GetFilms();
            if (tbSearch.Text != "")
            {
                filmList = FilmFunction.SearchFilm(tbSearch.Text.Trim());
            }
            if (filmList.Count == 0)
            {
                MessageBox.Show("Ничего не найдено");
            }
            else
            {

            }
            LvMain.ItemsSource = filmList;

        }
    }
}
