using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notigraghy.View.CreateNote
{
	public partial class CreateNoteView : ContentView
	{
		public CreateNoteView ()
		{
			InitializeComponent ();
            this.BindingContext = new CreateNoteViewModel();
        }
	}
}