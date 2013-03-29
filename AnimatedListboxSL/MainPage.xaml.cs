using System.Linq;

namespace AnimatedListboxSL
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            listbox1.ItemsSource = Enumerable.Range(1, 100);
        }
    }
}
