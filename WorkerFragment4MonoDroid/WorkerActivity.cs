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

namespace WorkerFragment4MonoDroid
{
	public class WorkerActivity<TWorker> : Activity where TWorker : IWorker, new()
	{
		private const string WORKER_FRAGMENT_TAG = "worker";
		private WorkerFragment<TWorker> _workerFragment;

		protected TWorker Worker 
		{ 
			get { 
				// todo: ensure that OnCreate i WorkerFragmant is called before this get-property is called.
				return _workerFragment.Worker; 
			} 
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			WorkerFragment<TWorker> f  = (WorkerFragment<TWorker>) FragmentManager.FindFragmentByTag(WORKER_FRAGMENT_TAG);

			// If the Fragment is non-null, then it is currently being
			// retained across a configuration change.
			if (f == null) {
				f = new WorkerFragment<TWorker>();
				FragmentManager.BeginTransaction().Add(f, WORKER_FRAGMENT_TAG).Commit();
			}

			_workerFragment = f;
		}
	}
}

