using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using WorkerFragment4MonoDroid;

namespace FragmentTest
{
	[Activity (Label = "FragmentTest", MainLauncher = true)]
	public class MainActivity : WorkerActivity<TestDownloader>
	{
		//int count = 1;

		protected static string MY_FRAGMENT_TAG = "myfragment";
		protected MyFragment _myFragment;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);         

	

			_myFragment  = (MyFragment) FragmentManager.FindFragmentByTag(MY_FRAGMENT_TAG);
			if (_myFragment == null) {
				_myFragment = new MyFragment ();
				var ft = FragmentManager.BeginTransaction ();
				ft.Add (Resource.Id.fragment_container, _myFragment, MY_FRAGMENT_TAG);
				ft.Commit ();
			}
		}

		protected override void OnResume ()
		{
			base.OnStart ();

			Worker.ProgressChanged += _myFragment.HandleProgressChanged;
			Worker.RunDemo ();
		}

		protected override void OnPause ()
		{
			base.OnPause ();

			Worker.ProgressChanged -= _myFragment.HandleProgressChanged;
		}


	}
}


