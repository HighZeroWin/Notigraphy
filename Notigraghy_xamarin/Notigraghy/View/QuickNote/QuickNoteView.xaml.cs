using Xamarin.Forms;

namespace Notigraghy.View.QuickNote
{
    public partial class QuickNoteView : ContentView
	{
        public QuickNoteView()
        {
            InitializeComponent();
            this.BindingContext = new QuickNoteViewModel();
        }
    }
}