using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FL_Sample_Library_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<AudioMetadata> MetadataCollection { get; set; }
        public Binding binding { get; set; }
        public String filename22;
        public MainWindow()
        {
            MetadataCollection = new ObservableCollection<AudioMetadata>();
            InitializeComponent();
            binding = new Binding();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            this.Width += 33;
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            AudioMetadata metadata = new AudioMetadata();
            metadata = AudioMetadata.Load(openFileDialog.FileName);
            this.Title = metadata.FilePath;
            audioname.Text = metadata.FilePath;
            audiolength.Text = metadata.Length.ToString();
            //binding.Source = metadata.FilePath;
            //audioname.SetBinding(TextBlock.TextProperty, binding);
            this.MetadataCollection.Add(metadata);
            //how the hell do we get this into data binding the textbox XAML?
        }
    }
}