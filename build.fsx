#r @"packages\FAKE\tools\FakeLib.dll"

open Fake

RestorePackages()

let outputDir = "./output"
let buildDir = outputDir + "/build"
let version = "0.3"

Target "Clean" (fun _ -> 
    CleanDirs [buildDir]
)

Target "BuildApp" (fun _ ->
    !! "./src/**/*.csproj"
    |> MSBuildRelease buildDir "Build"
    |> Log "Building app: "
)

"Clean"
    ==> "BuildApp"

RunTargetOrDefault "BuildApp"