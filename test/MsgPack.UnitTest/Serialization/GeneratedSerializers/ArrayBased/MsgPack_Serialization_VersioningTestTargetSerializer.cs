﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34011
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.ArrayBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.5.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_VersioningTestTargetSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.VersioningTestTarget> {
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer1;
        
        public MsgPack_Serialization_VersioningTestTargetSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            this._serializer0 = context.GetSerializer<int>();
            this._serializer1 = context.GetSerializer<string>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.VersioningTestTarget objectTree) {
            packer.PackArrayHeader(3);
            this._serializer0.PackTo(packer, objectTree.Field1);
            this._serializer0.PackTo(packer, objectTree.Field2);
            this._serializer1.PackTo(packer, objectTree.Field3);
        }
        
        protected internal override MsgPack.Serialization.VersioningTestTarget UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.VersioningTestTarget result = default(MsgPack.Serialization.VersioningTestTarget);
            result = new MsgPack.Serialization.VersioningTestTarget();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                System.Nullable<int> nullable = default(System.Nullable<int>);
                if ((unpacked < itemsCount)) {
                    nullable = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.VersioningTestTarget), "Int32 Field1");
                }
                if (nullable.HasValue) {
                    result.Field1 = nullable.Value;
                }
                unpacked = (unpacked + 1);
                System.Nullable<int> nullable0 = default(System.Nullable<int>);
                if ((unpacked < itemsCount)) {
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.VersioningTestTarget), "Int32 Field2");
                }
                if (nullable0.HasValue) {
                    result.Field2 = nullable0.Value;
                }
                unpacked = (unpacked + 1);
                string nullable1 = default(string);
                if ((unpacked < itemsCount)) {
                    nullable1 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.VersioningTestTarget), "System.String Field3");
                }
                if (((nullable1 == null) 
                            == false)) {
                    result.Field3 = nullable1;
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable2 = default(string);
                    nullable2 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.VersioningTestTarget), "MemberName");
                    if (((nullable2 == null) 
                                == false)) {
                        key = nullable2;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "Field3")) {
                        string nullable5 = default(string);
                        nullable5 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.VersioningTestTarget), "System.String Field3");
                        if (((nullable5 == null) 
                                    == false)) {
                            result.Field3 = nullable5;
                        }
                    }
                    else {
                        if ((key == "Field2")) {
                            System.Nullable<int> nullable4 = default(System.Nullable<int>);
                            nullable4 = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.VersioningTestTarget), "Int32 Field2");
                            if (nullable4.HasValue) {
                                result.Field2 = nullable4.Value;
                            }
                        }
                        else {
                            if ((key == "Field1")) {
                                System.Nullable<int> nullable3 = default(System.Nullable<int>);
                                nullable3 = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(MsgPack.Serialization.VersioningTestTarget), "Int32 Field1");
                                if (nullable3.HasValue) {
                                    result.Field1 = nullable3.Value;
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
