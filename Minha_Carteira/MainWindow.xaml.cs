using System;
using System.Collections.Generic;
using System.Globalization;
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
using Minha_Carteira.Data;

namespace Minha_Carteira
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Context context;
        Entry newEntry = new();


        public MainWindow(Context context)
        {
            this.context = context;
            InitializeComponent();
            GetEntries();
            NewEntryGrid.DataContext = newEntry;
        }

        private void GetEntries()
        {
            EntryDataGrid.ItemsSource = context.Entries.ToList();
            var a = context.Entries.Sum(Entry => Entry.Value);
            Balance.Text = "Saldo Atual: R$" + a;
        }
        private void AddItem(object sender, RoutedEventArgs e)
        {
            if (Names.Text != "" && Date.SelectedDate != null && Value.Text != "0" && Value.Text != "" && Type.Text != "" && (Expsense.IsChecked == true || Gain.IsChecked == true))
            {
                if (Expsense.IsChecked == true)
                {
                    newEntry.Value = newEntry.Value * (-1);
                }
               
                context.Entries.Add(newEntry);
                context.SaveChanges();

                GetEntries();

                Expsense.IsChecked = false;
                Gain.IsChecked = false;


                newEntry = new Entry();
                NewEntryGrid.DataContext = newEntry;

                
            }
            else MessageBox.Show("Preencha todos os campos obrigatórios");
            
        }

        public static bool IsValid(string str)
        {
            int i;
            return int.TryParse(str, out i);
        }

        private void Value_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsValid(((TextBox)sender).Text + e.Text);
        }

        
    }
}
