# A `Blazor` and `Redux` playground project

This is a sample project to demonstrate the features of [Blazor](www.blazor.net) (build full-stack web apps with only C# available due to the open web standard **WebAssembly**) and Redux with Redux.NET by using only C# and .NET Core.

The project includes a `CounterRedux.cshtml` component which uses a Redux store (defined in `CounterStore`) which allows dispatching actions (defined in `CounterActions`) to mutate the core store state. The store dispatcher forwards the actions (and their optional payload) into a core `CounterReducer`.

### Start the application
To run the project / app just type in `dotnet run` in the project root directory. Use the latest Chrome browser for best experience.

**No licence, feel free to fork and explore.**
Author: Vedran Mandić