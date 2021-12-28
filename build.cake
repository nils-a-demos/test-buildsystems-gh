// #module nuget:?package=Cake.BuildSystems.Module&version=4.0.0

var target = Argument("target", "Default");

Task("Default")
.Does(() => {
   Information("Some Debug: (might not see it)");
   Debug("Hello, from debug");
   Information("Some Information");
   Information("Hello, from information");
   Information("Some Warning");
   Warning("Hello, from warning");
   Information("Some Error");
   Error("Hello, from error");
});

RunTarget(target);
