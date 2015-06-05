# orion
Managed game manipulation framework for Counter Strike: Global Offensive in C#

Project goals:
* Provide a basic, yet extensible framework for CS:GO modifications targeted at either new developers, or developers making the transition from C++ or another language
* Support both internal and external game manipulation
* Stay true to the C# spirit, through idiomatic language usage
* Updateability - offsets are maintained centrally

# requirements

* Visual Studio 2013 or later
* .NET 4.5.1
* [System.Numerics.Vectors](https://msdn.microsoft.com/en-us/library/dn858218%28v=vs.111%29.aspx) is required for Vectors and Matrices. A copy of the library can be obtained via NuGet and is included in Orion when built.
* [BlueRain](https://github.com/aevitas/bluerain) is required for the memory manipulation that makes the entire project possible in the first place. A binary is included in the `libs` directory, compilation from source is optional.

License
=====

Orion is licensed under the very permissive Apache 2.0 license. Any submodules or dependencies may be under different licenses.

# API

Orion's API is meant to be intuitive and easy to use. Most of the framework components can be accessed through the `Orion` class, after `Attach` has been called to initialize the framework for a given process.

For example:

	var proc = Process.GetProcessesByName("csgo")[0];

	Orion.Attach(proc);

	Orion.Objects.Update();
	Console.Clear();

	Console.WriteLine("State: {0}\n\n", Orion.Client.State);

	if (Orion.Client.InGame)
	{
		var me = Orion.Me;
		Console.WriteLine("ID:\t\t{0}", me.Id);
		Console.WriteLine("Health:\t\t{0}", me.Health);
		Console.WriteLine("Position:\t{0}", me.Position);
		Console.WriteLine("Team:\t\t{0}", me.Team);
		Console.WriteLine("ObjectCount:\t{0}", Orion.Objects.Players.Count);
	}

API examples and sample projects will be included later down the line.

# contribute

While we welcome all contributions and/or pull requests to the code base, please take the following in regard:
* We like to think we maintain a particularly high standard when it comes to code quality. When submitting a PR, please respect this. Requests of insufficient quality code may be rejected at the author's discretion.
* If your pull requests addresses an issue in the code, please make sure to provide a link to an issue [in the project's issue tracker](https://github.com/aevitas/orion/issues) of what issue your PR addresses specifically, and how we can verify your PR actually fixes it.

# future development

Given sufficient demand, this code base will be extended into a fully featured modification for CS:GO in due time. This does assume there are more people interested in it than just the original author of the code.
