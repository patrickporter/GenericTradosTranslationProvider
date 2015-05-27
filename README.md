# GenericTradosTranslationProvider
A template to create a 'translation provider' plugin for SDL Trados Studio 2014, containing basic code and some comments/instructions.

Add a .snk file in the project properties under 'Signing', as Trados Studio requires the plugin to be strongly named.

To create a plugin for earlier versions of Trados Studio, point the SDL SDK references to the folder Studio2 instead of Studio3 and change the build target to .NET 3.5

See the SDL SDK documentation for more information on how to work with Trados Studio.

A translation provider plugin can be debugged in Visual Studio by loading a version of the plugin with debug symbols in Trados and then attaching to the Trados Studio process from Visual Studio.
