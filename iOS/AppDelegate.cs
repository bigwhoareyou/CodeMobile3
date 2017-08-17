using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace CodeMobile3.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

			var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            path = System.IO.Path.Combine(path, "..", "Library", "databases");
            if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);
            path = System.IO.Path.Combine(path, "mydb.db3");

			LoadApplication(new App(path));

            return base.FinishedLaunching(app, options);
        }
    }
}
