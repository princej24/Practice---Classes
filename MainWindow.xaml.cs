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

namespace Practice___Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Car Car;

        public MainWindow()
        {
            InitializeComponent();
        }
        Car car = new Car();
        Shows Shows = new Shows();
        Bike Bike = new Bike();

        private void BtnDisplay_Click(object sender, RoutedEventArgs e)
        {
            Bike Bike = new Bike();
            Car Car = new Car();
            Car.Make = txtMake.Text;
            Car.Model = txtModel.Text;
            Car.Year = int.Parse(txtYear.Text);
            Car.Color = txtColor.Text;
            Car.Mileage = int.Parse(txtmileage.Text);

            MessageBox.Show($"Make: {Car.Make}\nModel: {Car.Model}\nYear: {Car.Year}\nColor: {Car.Color}\nMileage: {Car.Mileage}", "Car Information");


            txtModel.Clear();
            txtColor.Clear();
            txtMake.Clear();
            txtColor.Clear();
            txtYear.Clear();
            txtmileage.Clear();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            Bike.Brand = txtMake.Text;

            Bike.Color = txtColor.Text;

            Bike.NumOfWheeles = int.Parse(txtmileage.Text);



            MessageBox.Show($"Brand:  {Bike.Brand} \ncolor: {Bike.Color}\nNumber of wheels: {Bike.NumOfWheeles}");

            txtModel.Clear();
            txtColor.Clear();
            txtMake.Clear();
            txtColor.Clear();
            txtYear.Clear();
            txtmileage.Clear();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Shows Shows = new Shows();
            Shows.Name = txtModel.Text;
            Shows.Year = int.Parse(txtYear.Text);
            Shows.Seasons = int.Parse(txtmileage.Text);


            MessageBox.Show($"Name: {Shows.Name}\nyear: {Shows.Year}\n seasons: {Shows.Seasons}", " show's to see");


           

            txtModel.Clear();
            txtColor.Clear();
            txtMake.Clear();
            txtColor.Clear();
            txtYear.Clear();
            txtmileage.Clear();
        }
    }
}

