#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2015 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

[assembly: AssemblyTitle( "MessagePack for CLI(.NET/Mono)" )]
[assembly: AssemblyDescription( "MessagePack for CLI(.NET/Mono) packing/unpacking library for Unity3D with Full .NET 2.0 mode." )]
[assembly: AssemblyCopyright( "Copyright © FUJIWARA, Yusuke 2010-2015" )]


[assembly: AssemblyFileVersion( "0.6.2182.420" )]

[assembly: AllowPartiallyTrustedCallers]

#if DEBUG || PERFORMANCE_TEST
[assembly: InternalsVisibleTo( "MsgPack.UnitTest.Unity3D" )]
[assembly: InternalsVisibleTo( "MsgPack.UnitTest.Unity3D.Desktop" )]

#endif
