using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libKiip.a",  LinkTarget.ArmV6 | LinkTarget.ArmV7 | LinkTarget.Simulator,Frameworks = "MobileCoreServices CoreGraphics CFNetwork SystemConfiguration", LinkerFlags="-lxml2", ForceLoad = true)]
