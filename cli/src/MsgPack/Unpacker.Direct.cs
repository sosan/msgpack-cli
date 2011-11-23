﻿#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2010 FUJIWARA, Yusuke
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

using System;
using System.Diagnostics.Contracts;

namespace MsgPack
{
	// This file generated from Unpacker.Direct.tt T4Template.
	// Do not modify this file. Edit Unpacker.Direct.tt instead.

	partial class Unpacker
	{

		/// <summary>
		///		Unpack <see cref="Byte"/> from current buffer.
		/// </summary>
		/// <returns><see cref="Byte"/> value.</returns>
		/// <exception cref="ObjectDisposedException">This instance has been disposed.</exception>
		/// <exception cref="UnpackException">Failed to unpack due to malformed or collapsed source.</exception>
		/// <exception cref="MessageTypeException">Current value is not <see cref="Byte"/>.</exception>
		/// <exception cref="InvalidOperationException">
		///		There is no data on the current stream.
		/// </exception>
		/// <exception cref="NotSupportedException">
		///		This instance does not supoort direct API.
		/// </exception>
		public Byte UnpackByte()
		{
			this.VerifyMode( UnpackerMode.Direct );

			return Unpacking.UnpackByte( this.UnderlyingStream );
		}

		/// <summary>
		///		Unpack <see cref="SByte"/> from current buffer.
		/// </summary>
		/// <returns><see cref="SByte"/> value.</returns>
		/// <exception cref="ObjectDisposedException">This instance has been disposed.</exception>
		/// <exception cref="UnpackException">Failed to unpack due to malformed or collapsed source.</exception>
		/// <exception cref="MessageTypeException">Current value is not <see cref="SByte"/>.</exception>
		/// <exception cref="InvalidOperationException">
		///		There is no data on the current stream.
		/// </exception>
		/// <exception cref="NotSupportedException">
		///		This instance does not supoort direct API.
		/// </exception>
		[CLSCompliant( false )]
		public SByte UnpackSByte()
		{
			this.VerifyMode( UnpackerMode.Direct );

			return Unpacking.UnpackSByte( this.UnderlyingStream );
		}

		/// <summary>
		///		Unpack <see cref="Int16"/> from current buffer.
		/// </summary>
		/// <returns><see cref="Int16"/> value.</returns>
		/// <exception cref="ObjectDisposedException">This instance has been disposed.</exception>
		/// <exception cref="UnpackException">Failed to unpack due to malformed or collapsed source.</exception>
		/// <exception cref="MessageTypeException">Current value is not <see cref="Int16"/>.</exception>
		/// <exception cref="InvalidOperationException">
		///		There is no data on the current stream.
		/// </exception>
		/// <exception cref="NotSupportedException">
		///		This instance does not supoort direct API.
		/// </exception>
		public Int16 UnpackInt16()
		{
			this.VerifyMode( UnpackerMode.Direct );

			return Unpacking.UnpackInt16( this.UnderlyingStream );
		}

		/// <summary>
		///		Unpack <see cref="UInt16"/> from current buffer.
		/// </summary>
		/// <returns><see cref="UInt16"/> value.</returns>
		/// <exception cref="ObjectDisposedException">This instance has been disposed.</exception>
		/// <exception cref="UnpackException">Failed to unpack due to malformed or collapsed source.</exception>
		/// <exception cref="MessageTypeException">Current value is not <see cref="UInt16"/>.</exception>
		/// <exception cref="InvalidOperationException">
		///		There is no data on the current stream.
		/// </exception>
		/// <exception cref="NotSupportedException">
		///		This instance does not supoort direct API.
		/// </exception>
		[CLSCompliant( false )]
		public UInt16 UnpackUInt16()
		{
			this.VerifyMode( UnpackerMode.Direct );

			return Unpacking.UnpackUInt16( this.UnderlyingStream );
		}

		/// <summary>
		///		Unpack <see cref="Int32"/> from current buffer.
		/// </summary>
		/// <returns><see cref="Int32"/> value.</returns>
		/// <exception cref="ObjectDisposedException">This instance has been disposed.</exception>
		/// <exception cref="UnpackException">Failed to unpack due to malformed or collapsed source.</exception>
		/// <exception cref="MessageTypeException">Current value is not <see cref="Int32"/>.</exception>
		/// <exception cref="InvalidOperationException">
		///		There is no data on the current stream.
		/// </exception>
		/// <exception cref="NotSupportedException">
		///		This instance does not supoort direct API.
		/// </exception>
		public Int32 UnpackInt32()
		{
			this.VerifyMode( UnpackerMode.Direct );

			return Unpacking.UnpackInt32( this.UnderlyingStream );
		}

		/// <summary>
		///		Unpack <see cref="UInt32"/> from current buffer.
		/// </summary>
		/// <returns><see cref="UInt32"/> value.</returns>
		/// <exception cref="ObjectDisposedException">This instance has been disposed.</exception>
		/// <exception cref="UnpackException">Failed to unpack due to malformed or collapsed source.</exception>
		/// <exception cref="MessageTypeException">Current value is not <see cref="UInt32"/>.</exception>
		/// <exception cref="InvalidOperationException">
		///		There is no data on the current stream.
		/// </exception>
		/// <exception cref="NotSupportedException">
		///		This instance does not supoort direct API.
		/// </exception>
		[CLSCompliant( false )]
		public UInt32 UnpackUInt32()
		{
			this.VerifyMode( UnpackerMode.Direct );

			return Unpacking.UnpackUInt32( this.UnderlyingStream );
		}

		/// <summary>
		///		Unpack <see cref="Int64"/> from current buffer.
		/// </summary>
		/// <returns><see cref="Int64"/> value.</returns>
		/// <exception cref="ObjectDisposedException">This instance has been disposed.</exception>
		/// <exception cref="UnpackException">Failed to unpack due to malformed or collapsed source.</exception>
		/// <exception cref="MessageTypeException">Current value is not <see cref="Int64"/>.</exception>
		/// <exception cref="InvalidOperationException">
		///		There is no data on the current stream.
		/// </exception>
		/// <exception cref="NotSupportedException">
		///		This instance does not supoort direct API.
		/// </exception>
		public Int64 UnpackInt64()
		{
			this.VerifyMode( UnpackerMode.Direct );

			return Unpacking.UnpackInt64( this.UnderlyingStream );
		}

		/// <summary>
		///		Unpack <see cref="UInt64"/> from current buffer.
		/// </summary>
		/// <returns><see cref="UInt64"/> value.</returns>
		/// <exception cref="ObjectDisposedException">This instance has been disposed.</exception>
		/// <exception cref="UnpackException">Failed to unpack due to malformed or collapsed source.</exception>
		/// <exception cref="MessageTypeException">Current value is not <see cref="UInt64"/>.</exception>
		/// <exception cref="InvalidOperationException">
		///		There is no data on the current stream.
		/// </exception>
		/// <exception cref="NotSupportedException">
		///		This instance does not supoort direct API.
		/// </exception>
		[CLSCompliant( false )]
		public UInt64 UnpackUInt64()
		{
			this.VerifyMode( UnpackerMode.Direct );

			return Unpacking.UnpackUInt64( this.UnderlyingStream );
		}

		/// <summary>
		///		Unpack <see cref="Single"/> from current buffer.
		/// </summary>
		/// <returns><see cref="Single"/> value.</returns>
		/// <exception cref="ObjectDisposedException">This instance has been disposed.</exception>
		/// <exception cref="UnpackException">Failed to unpack due to malformed or collapsed source.</exception>
		/// <exception cref="MessageTypeException">Current value is not <see cref="Single"/>.</exception>
		/// <exception cref="InvalidOperationException">
		///		There is no data on the current stream.
		/// </exception>
		/// <exception cref="NotSupportedException">
		///		This instance does not supoort direct API.
		/// </exception>
		public Single UnpackSingle()
		{
			this.VerifyMode( UnpackerMode.Direct );

			return Unpacking.UnpackSingle( this.UnderlyingStream );
		}

		/// <summary>
		///		Unpack <see cref="Double"/> from current buffer.
		/// </summary>
		/// <returns><see cref="Double"/> value.</returns>
		/// <exception cref="ObjectDisposedException">This instance has been disposed.</exception>
		/// <exception cref="UnpackException">Failed to unpack due to malformed or collapsed source.</exception>
		/// <exception cref="MessageTypeException">Current value is not <see cref="Double"/>.</exception>
		/// <exception cref="InvalidOperationException">
		///		There is no data on the current stream.
		/// </exception>
		/// <exception cref="NotSupportedException">
		///		This instance does not supoort direct API.
		/// </exception>
		public Double UnpackDouble()
		{
			this.VerifyMode( UnpackerMode.Direct );

			return Unpacking.UnpackDouble( this.UnderlyingStream );
		}
	}
}