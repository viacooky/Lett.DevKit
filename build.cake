#tool nuget:?package=Cake.CoreCLR&version=0.37.0
// ------------------------------------------------------------------
// 参数定义
var target = Argument ("target", "Default");
// ------------------------------------------------------------------
// 路径定义
var rootPath = "./src";
var slnPath = rootPath + "/Lett.DevKit.sln";
var projsFiles  = GetFiles(rootPath + "**/*.csproj");

// ------------------------------------------------------------------

Task ("Clean")
  .Description("清理项目")
  .Does (() => {
    DotNetCoreClean (slnPath);
  });

Task("PackNuGet")
    .Does(() => {
        // Information($"打包NuGet:{buildProj}");
        // DotNetCorePack(buildProj, new DotNetCorePackSettings {
        // Configuration = configuration,
        //     OutputDirectory = nugetPackBuilPath,
        //     IncludeSymbols = false,
        //     ArgumentCustomization = args => args
        //     .Append($"/p:Version={nugetVersion}")
        //     .Append($"/p:AssemblyVersion={assemblyVerion}")
        // });
    });

Task ("Default")
  .Does (() => {
    Information("默认构建完成");
  });

RunTarget (target);
