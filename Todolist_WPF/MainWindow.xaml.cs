using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;



namespace Todolist_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //new

        public static DB_Operation DB_Operation = new DB_Operation();
        public static List<Todo> lists = new List<Todo>();

        public MainWindow()
        {
            InitializeComponent();
            loadGrid();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximized = false;
                }

                else
                {
                    this.WindowState = WindowState.Maximized;
                    IsManipulationEnabled = true;
                }
            }

        }

        public void loadGrid()
        {
            UpdateGrid();

        }

        private void UpdateGrid()
        {
            var list = DB_Operation.GetList();
            grid_txt.ItemsSource = list;
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {

            DB_Operation.InsertList(new Todo() { TodoText = txtText.Text, Dato = DateTime.Now, isCheck  = false });
            UpdateGrid();
        }
        private void TextBox_Add(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {


        }

       

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            var deleteItem = grid_txt.SelectedItem as Todo;
            DB_Operation.DeleteItem(deleteItem);
            UpdateGrid();
        }

        private void Button_Edit(object sender, RoutedEventArgs e)
        {
            var editItem = grid_txt.SelectedItem as Todo;
            DB_Operation.EditItem(editItem);
            UpdateGrid();
        }

        private void DataGrid(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
