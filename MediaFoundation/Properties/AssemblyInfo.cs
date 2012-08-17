#region license

/*
MediaFoundationLib - Provide access to MediaFoundation interfaces via .NET
Copyright (C) 2007
http://mfnet.sourceforge.net

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

#endregion

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;


[assembly: AssemblyTitle("MediaFoundation .Net Library")]
[assembly: AssemblyDescription(".NET Interfaces for calling MediaFoundation.  See http://mfnet.sourceforge.net/")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: Guid("106ce403-2382-4c3d-ab55-fcb43e09f245")]
[assembly: AssemblyVersion("2.0.0.*")]
[assembly: AssemblyFileVersion("2.0.0.0")]
#if DEBUG
[assembly: AssemblyProduct("Debug Version")]
#else
[assembly : AssemblyProduct("Release Version")]
#endif
[assembly: AssemblyCopyright("GNU Lesser General Public License v2.1")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, UnmanagedCode = true)]

