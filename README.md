# NReact
Please check official React/Flux resources to undestand underlying concepts.

React/Flux principles in C#/Xaml application. Experimental playground. 
See various demos.

Implemented:
* CSX - C# syntax extension (aka React JSX). CSX -> C# transform MSBuild task and standalone executable (NReact.Csx)
* Async Virtual Xaml (aka VirtualDOM) including simple patching mechanism (no diff based on Key yet) (NElement)
* Dynamic typing for Component's Props and State (NDynamic)
* Several Type Converters including enums, colors, brushes and resources (NConverters)
* Simple Flux Dispatcher (NDispatcher)

To to:
* Xaml-like Visual Studio CSX syntax transform including syntax highlighting and debugging.
* Optimise Diff-algorythm for Virtual Xaml
* Experiment with statically typed Component's Props and State 
* More type converters

Existence questions:
* Why do one need NReact?
