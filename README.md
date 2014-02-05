#WorkerFragment4MonoDroid#

##Description##

WorkerFragment4MonoDroid is a Monodroid library to handle state saving between orientation changes. The library aims to simplify the use of the worker fragment pattern.

##How to use##

Let your Activity inherit from WorkerActivity, and specify the WorkerType you like to use, like this:

    public class MainActivity : WorkerActivity<TestDownloader>
    
Then you can access the worker from the Worker property. 

		protected override void OnResume ()
		{
			base.OnStart ();

			Worker.ProgressChanged += _myFragment.HandleProgressChanged;
			Worker.RunDemo ();
		}


The worker instance is saved between orientation changes. See the sample project.


##License##

    Copyright 2013 Erik Zetterqvist
    
    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at
    
    http://www.apache.org/licenses/LICENSE-2.0
    
    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
