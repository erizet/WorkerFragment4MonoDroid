using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FragmentTest
{
	public class MyFragment : Fragment
	{
		protected ProgressBar _pg;
		protected TextView _textView;

		protected int namn;

		protected static int counter = 0;

		public MyFragment () : base()
		{
			namn = counter++;

		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			RetainInstance = false;
			//var textToDisplay = "The quick brown fox jumps over the lazy dog. ";
			var view = inflater.Inflate(Resource.Layout.MyFragment, container, false);
			_textView = view.FindViewById<TextView>(Resource.Id.text_view);
			_pg = view.FindViewById<ProgressBar> (Resource.Id.progressBar1);
			//_textView.Text = textToDisplay;

			return view;
		}


		public void HandleProgressChanged (object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			//			Activity.RunOnUiThread(() => _pg.Progress = e.ProgressPercentage );
			Activity.RunOnUiThread(() => _textView.Text = e.ProgressPercentage.ToString() );
		}
	}
}

