using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ServiceStack.ServiceInterface")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("ServiceStack")]
[assembly: AssemblyCopyright("Copyright © ServiceStack 2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b1eeca45-c9f8-457d-a6ee-98ac3b071639")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
//[assembly: AssemblyFileVersion("1.0.0.0")]

//Default DataContract namespace instead of tempuri.org
[assembly: ContractNamespace("http://schemas.servicestack.net/types",
    ClrNamespace = "ServiceStack.ServiceInterface")]
[assembly: ContractNamespace("http://schemas.servicestack.net/types",
    ClrNamespace = "ServiceStack.ServiceInterface.Auth")]
[assembly: InternalsVisibleTo("ServiceStack.WebHost.Endpoints.Tests, PublicKey=002400000480000094000000060200000024000052534131000400000100010023edbffb4a133967d5d93f441ab3d81802a119504378d68545aa872a4ec160420f0653db0135843cc102d41dc654903e9f3da52b5ced8cf38bbdd217339fc3f0ff481bbeb55e4334d93651339f73ee61bd75b16ba86965c4053d000e0093ea84c82924642d9e84cd52d65028fe0614117b1c9b3f31ea2b327e78e820193f8ea5")]

[assembly: CLSCompliant(true)]
