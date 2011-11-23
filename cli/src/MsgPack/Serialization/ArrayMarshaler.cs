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
using System.Collections.Generic;

namespace MsgPack.Serialization
{
	// FIXME: MessagePackArraySerializer
	/// <summary>
	///		Define generic factory methods for generic <see cref="ArrayMarshaler{TCollection}"/> classes.
	/// </summary>
	public static class ArrayMarshaler
	{
		/// <summary>
		///		Create appropriate <see cref="ArrayMarshaler{T}"/> instance.
		/// </summary>
		/// <typeparam name="T">Type of the array. This is not have to be <see cref="Array"/>, but must be <see cref="IEnumerable{T}"/> and has <c>Add(T)</c> method.</typeparam>
		/// <param name="marshalerRepository">Referencing <see cref="MarshalerRepository"/>. To use system default repository, specify <c>null</c>.</param>
		/// <param name="serializerRepository">Referencing <see cref="SerializerRepository"/>. To use system default repository, specify <c>null</c>.</param>
		/// <returns>
		///		Appropriate <see cref="ArrayMarshaler{T}"/> instance.
		///		If <typeparamref name="T"/> is not appropriate, then <c>null</c>.
		/// </returns>
		public static ArrayMarshaler<T> Create<T>( MarshalerRepository marshalerRepository, SerializerRepository serializerRepository )
		{
			var traits = typeof( T ).GetCollectionTraits();

			if ( traits.CollectionType == CollectionKind.Array )
			{
				// TODO: Configurable
				return new EmittingArrayMarshaler<T>( traits );
			}
			else
			{
				return null;
			}
		}
	}
}
