// include Fake lib
#r @"tools\FAKE\tools\FakeLib.dll"
open Fake
 
RestorePackages()

// Properties
let buildDir = @".\build\"
let testDir  = @".\test\"
let packagesDir = @".\packages"
let packagingRoot = "./packaging/"
let packagesVersion = "1.0.18"

// Targets
Target "Clean" (fun _ ->
    CleanDirs [buildDir; testDir; packagingRoot]
)

Target "Build" (fun _ ->
    !! @"Kulman.WPA81\Kulman.WPA81.csproj"
      |> MSBuildRelease buildDir "Build"
      |> Log "AppBuild-Output: "
)

Target "CreateNugetPackage" (fun _ ->    
    NuGet (fun p -> 
        {p with                  
            Project = "Kulman.WPA81"          
            OutputPath = packagingRoot
            WorkingDir = buildDir
            Version = packagesVersion           
            Publish = false
            }) "Kulman.WPA81.nuspec"
)

Target "Default" (fun _ ->
    trace "Build completed"
)

// Dependencies
"Clean"  
  ==> "Build"
  ==> "CreateNugetPackage"
  ==> "Default"
 
// start build
Run "Default"