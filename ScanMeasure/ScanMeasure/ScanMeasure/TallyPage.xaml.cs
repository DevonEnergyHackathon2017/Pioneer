using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScanMeasure
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TallyPage : ContentPage
	{
		public TallyPage ()
		{
			InitializeComponent ();
            PhasePicker.SelectedIndex = 0;

        }
	}
}