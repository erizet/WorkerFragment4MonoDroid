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
	public interface IWorker
	{
		void OnInitialized ();
		void OnConnectedToActivity (Activity activity);
		void OnDisconnected ();	
	}
}

