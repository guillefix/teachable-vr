// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: basic_comm.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from basic_comm.proto</summary>
public static partial class BasicCommReflection {

  #region Descriptor
  /// <summary>File descriptor for basic_comm.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BasicCommReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChBiYXNpY19jb21tLnByb3RvIgcKBUVtcHR5IigKB0ZlYXR1cmUSDQoFdGhp",
          "bmcYASABKAISDgoGdGhpbmcyGAIgASgCMi0KCERhdGFDb21tEiEKC0dldEZl",
          "YXR1cmVzEgYuRW1wdHkaCC5GZWF0dXJlIgBiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Empty), global::Empty.Parser, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Feature), global::Feature.Parser, new[]{ "Thing", "Thing2" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Empty : pb::IMessage<Empty> {
  private static readonly pb::MessageParser<Empty> _parser = new pb::MessageParser<Empty>(() => new Empty());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Empty> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BasicCommReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Empty() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Empty(Empty other) : this() {
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Empty Clone() {
    return new Empty(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Empty);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Empty other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Empty other) {
    if (other == null) {
      return;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
      }
    }
  }

}

public sealed partial class Feature : pb::IMessage<Feature> {
  private static readonly pb::MessageParser<Feature> _parser = new pb::MessageParser<Feature>(() => new Feature());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Feature> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BasicCommReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Feature() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Feature(Feature other) : this() {
    thing_ = other.thing_;
    thing2_ = other.thing2_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Feature Clone() {
    return new Feature(this);
  }

  /// <summary>Field number for the "thing" field.</summary>
  public const int ThingFieldNumber = 1;
  private float thing_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Thing {
    get { return thing_; }
    set {
      thing_ = value;
    }
  }

  /// <summary>Field number for the "thing2" field.</summary>
  public const int Thing2FieldNumber = 2;
  private float thing2_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Thing2 {
    get { return thing2_; }
    set {
      thing2_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Feature);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Feature other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Thing, other.Thing)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Thing2, other.Thing2)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Thing != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Thing);
    if (Thing2 != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Thing2);
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Thing != 0F) {
      output.WriteRawTag(13);
      output.WriteFloat(Thing);
    }
    if (Thing2 != 0F) {
      output.WriteRawTag(21);
      output.WriteFloat(Thing2);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Thing != 0F) {
      size += 1 + 4;
    }
    if (Thing2 != 0F) {
      size += 1 + 4;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Feature other) {
    if (other == null) {
      return;
    }
    if (other.Thing != 0F) {
      Thing = other.Thing;
    }
    if (other.Thing2 != 0F) {
      Thing2 = other.Thing2;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 13: {
          Thing = input.ReadFloat();
          break;
        }
        case 21: {
          Thing2 = input.ReadFloat();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code