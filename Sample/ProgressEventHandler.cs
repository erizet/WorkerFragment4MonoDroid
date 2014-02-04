using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;

namespace FragmentTest
{
	public class ProgressEventHandler : EventArgs
	{
		public ProgressEventHandler (int procent)
		{
			this.Procent = procent;
		}

		public int Procent {
			get;
			private set;
		}
	}
}


