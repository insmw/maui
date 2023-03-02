﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mauitemplate
{
    [Instrumentation(Name = "com.microsoft.mauitemplate.Launch")]
    public class TemplateLaunchInstrumentation : Instrumentation
    {
        protected TemplateLaunchInstrumentation ()
        {}

        protected TemplateLaunchInstrumentation (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
        {}

        public override void OnCreate(Bundle arguments)
        {
            base.OnCreate(arguments);
            Start();
        }

        public override void OnStart()
        {
            base.OnStart();

            Bundle results = new Bundle ();
            var activityName = "com.microsoft.mauitemplate.MainActivity";
            ActivityMonitor monitor = AddMonitor(activityName, null, false);
            Intent intent = new Intent(Intent.ActionMain);
            intent.SetFlags(ActivityFlags.NewTask);
            intent.SetClassName(TargetContext, activityName);
            StartActivitySync(intent);
            Activity currentActivity = WaitForMonitor(monitor);
            var resultCode = currentActivity != null ? Result.Ok : Result.Canceled;
            results.PutString("return-code", resultCode.ToString("D"));
            Finish(resultCode, results);
        }
    }
}
