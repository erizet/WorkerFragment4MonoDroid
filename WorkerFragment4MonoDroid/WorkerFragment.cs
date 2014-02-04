using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace WorkerFragment4MonoDroid
{
	public class WorkerFragment<TWorker> : Fragment where TWorker : IWorker, new()
	{
		private TWorker _worker;

		public TWorker Worker { get { return _worker; } }

		public WorkerFragment ()
		{
		}

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			RetainInstance = true;

			_worker = new TWorker ();
			_worker.OnInitialized ();
		}

		public override void OnActivityCreated(Bundle savedStateInstance)
		{
			base.OnActivityCreated (savedStateInstance);

			_worker.OnConnectedToActivity (Activity);
		}

		public override void OnDetach ()
		{
			base.OnDetach ();

			_worker.OnDisconnected ();
		}
	}
}

