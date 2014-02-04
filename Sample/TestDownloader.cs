using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;
using WorkerFragment4MonoDroid;

namespace FragmentTest
{
	public class TestDownloader : IWorker
	{
		private volatile bool _isRunning = false;

		public event EventHandler<ProgressChangedEventArgs> ProgressChanged;

		#region IWorker implementation
		public void OnInitialized ()
		{
			//throw new NotImplementedException ();
		}
		public void OnConnectedToActivity (Activity activity)
		{
			//throw new NotImplementedException ();
		}
		public void OnDisconnected ()
		{
			//throw new NotImplementedException ();
		}
		#endregion

		public void RunDemo ()
		{
			if(!_isRunning)
			{
				// simulate a download of a big file
				_isRunning = true;
				Task t = Task.Factory.StartNew (() => {
					for (int i = 0; i < 100; i++) {
						Thread.Sleep(300);
						OnProgressChanged (i);
					}
				}).ContinueWith (c => _isRunning = false);
			}
		}

		protected void OnProgressChanged (int procent)
		{
			if (ProgressChanged != null)
				ProgressChanged (this, new ProgressChangedEventArgs (procent,null));
		}
	}
}


