// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=8fd7408b07f8d2cd.  DO NOT EDIT!

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace bnet.protocol.search {
  
  public static partial class SearchTypes {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_bnet_protocol_search_Statistic__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.search.Statistic, global::bnet.protocol.search.Statistic.Builder> internal__static_bnet_protocol_search_Statistic__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_bnet_protocol_search_Filter__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.search.Filter, global::bnet.protocol.search.Filter.Builder> internal__static_bnet_protocol_search_Filter__FieldAccessorTable;
    internal static pbd::MessageDescriptor internal__static_bnet_protocol_search_Object__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.search.Object, global::bnet.protocol.search.Object.Builder> internal__static_bnet_protocol_search_Object__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static SearchTypes() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "CiFzZXJ2aWNlL3NlYXJjaC9zZWFyY2hfdHlwZXMucHJvdG8SFGJuZXQucHJv" + 
          "dG9jb2wuc2VhcmNoIikKCVN0YXRpc3RpYxINCgJpZBgBIAEoDToBMBINCgV2" + 
          "YWx1ZRgCIAIoBSLTAgoGRmlsdGVyEjIKCXN0YXRpc3RpYxgBIAIoCzIfLmJu" + 
          "ZXQucHJvdG9jb2wuc2VhcmNoLlN0YXRpc3RpYxI5Cgljb21wYXJhbmQYAiAC" + 
          "KA4yJi5ibmV0LnByb3RvY29sLnNlYXJjaC5GaWx0ZXIuQ29tcGFyYW5kEkcK" + 
          "DnNvcnRfZGlyZWN0aW9uGAMgASgOMiouYm5ldC5wcm90b2NvbC5zZWFyY2gu" + 
          "RmlsdGVyLlNvcnREaXJlY3Rpb246A0FTQyJtCglDb21wYXJhbmQSCgoGRVFV" + 
          "QUxTEAASDQoJTEVTU19USEFOEAESFwoTTEVTU19USEFOX09SX0VRVUFMUxAC" + 
          "EhAKDEdSRUFURVJfVEhBThADEhoKFkdSRUFURVJfVEhBTl9PUl9FUVVBTFMQ" + 
          "BCIiCg1Tb3J0RGlyZWN0aW9uEgcKA0FTQxAAEggKBERFU0MQASJXCgZPYmpl" + 
          "Y3QSCgoCaWQYASACKAwSDAoEZGF0YRgCIAEoDBIzCgpzdGF0aXN0aWNzGAMg" + 
          "AygLMh8uYm5ldC5wcm90b2NvbC5zZWFyY2guU3RhdGlzdGlj");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_bnet_protocol_search_Statistic__Descriptor = Descriptor.MessageTypes[0];
        internal__static_bnet_protocol_search_Statistic__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.search.Statistic, global::bnet.protocol.search.Statistic.Builder>(internal__static_bnet_protocol_search_Statistic__Descriptor,
                new string[] { "Id", "Value", });
        internal__static_bnet_protocol_search_Filter__Descriptor = Descriptor.MessageTypes[1];
        internal__static_bnet_protocol_search_Filter__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.search.Filter, global::bnet.protocol.search.Filter.Builder>(internal__static_bnet_protocol_search_Filter__Descriptor,
                new string[] { "Statistic", "Comparand", "SortDirection", });
        internal__static_bnet_protocol_search_Object__Descriptor = Descriptor.MessageTypes[2];
        internal__static_bnet_protocol_search_Object__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::bnet.protocol.search.Object, global::bnet.protocol.search.Object.Builder>(internal__static_bnet_protocol_search_Object__Descriptor,
                new string[] { "Id", "Data", "Statistics", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
  }
  #region Messages
  public sealed partial class Statistic : pb::GeneratedMessage<Statistic, Statistic.Builder> {
    private static readonly Statistic defaultInstance = new Builder().BuildPartial();
    public static Statistic DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Statistic DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override Statistic ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bnet.protocol.search.SearchTypes.internal__static_bnet_protocol_search_Statistic__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Statistic, Statistic.Builder> InternalFieldAccessors {
      get { return global::bnet.protocol.search.SearchTypes.internal__static_bnet_protocol_search_Statistic__FieldAccessorTable; }
    }
    
    public const int IdFieldNumber = 1;
    private bool hasId;
    private uint id_ = 0;
    public bool HasId {
      get { return hasId; }
    }
    public uint Id {
      get { return id_; }
    }
    
    public const int ValueFieldNumber = 2;
    private bool hasValue;
    private int value_ = 0;
    public bool HasValue {
      get { return hasValue; }
    }
    public int Value {
      get { return value_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasValue) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      int size = SerializedSize;
      if (HasId) {
        output.WriteUInt32(1, Id);
      }
      if (HasValue) {
        output.WriteInt32(2, Value);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasId) {
          size += pb::CodedOutputStream.ComputeUInt32Size(1, Id);
        }
        if (HasValue) {
          size += pb::CodedOutputStream.ComputeInt32Size(2, Value);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static Statistic ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Statistic ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Statistic ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Statistic ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Statistic ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Statistic ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Statistic ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static Statistic ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static Statistic ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Statistic ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(Statistic prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<Statistic, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      Statistic result = new Statistic();
      
      protected override Statistic MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new Statistic();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::bnet.protocol.search.Statistic.Descriptor; }
      }
      
      public override Statistic DefaultInstanceForType {
        get { return global::bnet.protocol.search.Statistic.DefaultInstance; }
      }
      
      public override Statistic BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        Statistic returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is Statistic) {
          return MergeFrom((Statistic) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(Statistic other) {
        if (other == global::bnet.protocol.search.Statistic.DefaultInstance) return this;
        if (other.HasId) {
          Id = other.Id;
        }
        if (other.HasValue) {
          Value = other.Value;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        while (true) {
          uint tag = input.ReadTag();
          switch (tag) {
            case 0: {
              if (unknownFields != null) {
                this.UnknownFields = unknownFields.Build();
              }
              return this;
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag);
              break;
            }
            case 8: {
              Id = input.ReadUInt32();
              break;
            }
            case 16: {
              Value = input.ReadInt32();
              break;
            }
          }
        }
      }
      
      
      public bool HasId {
        get { return result.HasId; }
      }
      public uint Id {
        get { return result.Id; }
        set { SetId(value); }
      }
      public Builder SetId(uint value) {
        result.hasId = true;
        result.id_ = value;
        return this;
      }
      public Builder ClearId() {
        result.hasId = false;
        result.id_ = 0;
        return this;
      }
      
      public bool HasValue {
        get { return result.HasValue; }
      }
      public int Value {
        get { return result.Value; }
        set { SetValue(value); }
      }
      public Builder SetValue(int value) {
        result.hasValue = true;
        result.value_ = value;
        return this;
      }
      public Builder ClearValue() {
        result.hasValue = false;
        result.value_ = 0;
        return this;
      }
    }
    static Statistic() {
      object.ReferenceEquals(global::bnet.protocol.search.SearchTypes.Descriptor, null);
    }
  }
  
  public sealed partial class Filter : pb::GeneratedMessage<Filter, Filter.Builder> {
    private static readonly Filter defaultInstance = new Builder().BuildPartial();
    public static Filter DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Filter DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override Filter ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bnet.protocol.search.SearchTypes.internal__static_bnet_protocol_search_Filter__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Filter, Filter.Builder> InternalFieldAccessors {
      get { return global::bnet.protocol.search.SearchTypes.internal__static_bnet_protocol_search_Filter__FieldAccessorTable; }
    }
    
    #region Nested types
    public static class Types {
      public enum Comparand {
        EQUALS = 0,
        LESS_THAN = 1,
        LESS_THAN_OR_EQUALS = 2,
        GREATER_THAN = 3,
        GREATER_THAN_OR_EQUALS = 4,
      }
      
      public enum SortDirection {
        ASC = 0,
        DESC = 1,
      }
      
    }
    #endregion
    
    public const int StatisticFieldNumber = 1;
    private bool hasStatistic;
    private global::bnet.protocol.search.Statistic statistic_ = global::bnet.protocol.search.Statistic.DefaultInstance;
    public bool HasStatistic {
      get { return hasStatistic; }
    }
    public global::bnet.protocol.search.Statistic Statistic {
      get { return statistic_; }
    }
    
    public const int ComparandFieldNumber = 2;
    private bool hasComparand;
    private global::bnet.protocol.search.Filter.Types.Comparand comparand_ = global::bnet.protocol.search.Filter.Types.Comparand.EQUALS;
    public bool HasComparand {
      get { return hasComparand; }
    }
    public global::bnet.protocol.search.Filter.Types.Comparand Comparand {
      get { return comparand_; }
    }
    
    public const int SortDirectionFieldNumber = 3;
    private bool hasSortDirection;
    private global::bnet.protocol.search.Filter.Types.SortDirection sortDirection_ = global::bnet.protocol.search.Filter.Types.SortDirection.ASC;
    public bool HasSortDirection {
      get { return hasSortDirection; }
    }
    public global::bnet.protocol.search.Filter.Types.SortDirection SortDirection {
      get { return sortDirection_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasStatistic) return false;
        if (!hasComparand) return false;
        if (!Statistic.IsInitialized) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      int size = SerializedSize;
      if (HasStatistic) {
        output.WriteMessage(1, Statistic);
      }
      if (HasComparand) {
        output.WriteEnum(2, (int) Comparand);
      }
      if (HasSortDirection) {
        output.WriteEnum(3, (int) SortDirection);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasStatistic) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, Statistic);
        }
        if (HasComparand) {
          size += pb::CodedOutputStream.ComputeEnumSize(2, (int) Comparand);
        }
        if (HasSortDirection) {
          size += pb::CodedOutputStream.ComputeEnumSize(3, (int) SortDirection);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static Filter ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Filter ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Filter ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Filter ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Filter ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Filter ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Filter ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static Filter ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static Filter ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Filter ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(Filter prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<Filter, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      Filter result = new Filter();
      
      protected override Filter MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new Filter();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::bnet.protocol.search.Filter.Descriptor; }
      }
      
      public override Filter DefaultInstanceForType {
        get { return global::bnet.protocol.search.Filter.DefaultInstance; }
      }
      
      public override Filter BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        Filter returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is Filter) {
          return MergeFrom((Filter) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(Filter other) {
        if (other == global::bnet.protocol.search.Filter.DefaultInstance) return this;
        if (other.HasStatistic) {
          MergeStatistic(other.Statistic);
        }
        if (other.HasComparand) {
          Comparand = other.Comparand;
        }
        if (other.HasSortDirection) {
          SortDirection = other.SortDirection;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        while (true) {
          uint tag = input.ReadTag();
          switch (tag) {
            case 0: {
              if (unknownFields != null) {
                this.UnknownFields = unknownFields.Build();
              }
              return this;
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag);
              break;
            }
            case 10: {
              global::bnet.protocol.search.Statistic.Builder subBuilder = global::bnet.protocol.search.Statistic.CreateBuilder();
              if (HasStatistic) {
                subBuilder.MergeFrom(Statistic);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              Statistic = subBuilder.BuildPartial();
              break;
            }
            case 16: {
              int rawValue = input.ReadEnum();
              if (!global::System.Enum.IsDefined(typeof(global::bnet.protocol.search.Filter.Types.Comparand), rawValue)) {
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                unknownFields.MergeVarintField(2, (ulong) rawValue);
              } else {
                Comparand = (global::bnet.protocol.search.Filter.Types.Comparand) rawValue;
              }
              break;
            }
            case 24: {
              int rawValue = input.ReadEnum();
              if (!global::System.Enum.IsDefined(typeof(global::bnet.protocol.search.Filter.Types.SortDirection), rawValue)) {
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                unknownFields.MergeVarintField(3, (ulong) rawValue);
              } else {
                SortDirection = (global::bnet.protocol.search.Filter.Types.SortDirection) rawValue;
              }
              break;
            }
          }
        }
      }
      
      
      public bool HasStatistic {
       get { return result.HasStatistic; }
      }
      public global::bnet.protocol.search.Statistic Statistic {
        get { return result.Statistic; }
        set { SetStatistic(value); }
      }
      public Builder SetStatistic(global::bnet.protocol.search.Statistic value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasStatistic = true;
        result.statistic_ = value;
        return this;
      }
      public Builder SetStatistic(global::bnet.protocol.search.Statistic.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.hasStatistic = true;
        result.statistic_ = builderForValue.Build();
        return this;
      }
      public Builder MergeStatistic(global::bnet.protocol.search.Statistic value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        if (result.HasStatistic &&
            result.statistic_ != global::bnet.protocol.search.Statistic.DefaultInstance) {
            result.statistic_ = global::bnet.protocol.search.Statistic.CreateBuilder(result.statistic_).MergeFrom(value).BuildPartial();
        } else {
          result.statistic_ = value;
        }
        result.hasStatistic = true;
        return this;
      }
      public Builder ClearStatistic() {
        result.hasStatistic = false;
        result.statistic_ = global::bnet.protocol.search.Statistic.DefaultInstance;
        return this;
      }
      
      public bool HasComparand {
       get { return result.HasComparand; }
      }
      public global::bnet.protocol.search.Filter.Types.Comparand Comparand {
        get { return result.Comparand; }
        set { SetComparand(value); }
      }
      public Builder SetComparand(global::bnet.protocol.search.Filter.Types.Comparand value) {
        result.hasComparand = true;
        result.comparand_ = value;
        return this;
      }
      public Builder ClearComparand() {
        result.hasComparand = false;
        result.comparand_ = global::bnet.protocol.search.Filter.Types.Comparand.EQUALS;
        return this;
      }
      
      public bool HasSortDirection {
       get { return result.HasSortDirection; }
      }
      public global::bnet.protocol.search.Filter.Types.SortDirection SortDirection {
        get { return result.SortDirection; }
        set { SetSortDirection(value); }
      }
      public Builder SetSortDirection(global::bnet.protocol.search.Filter.Types.SortDirection value) {
        result.hasSortDirection = true;
        result.sortDirection_ = value;
        return this;
      }
      public Builder ClearSortDirection() {
        result.hasSortDirection = false;
        result.sortDirection_ = global::bnet.protocol.search.Filter.Types.SortDirection.ASC;
        return this;
      }
    }
    static Filter() {
      object.ReferenceEquals(global::bnet.protocol.search.SearchTypes.Descriptor, null);
    }
  }
  
  public sealed partial class Object : pb::GeneratedMessage<Object, Object.Builder> {
    private static readonly Object defaultInstance = new Builder().BuildPartial();
    public static Object DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override Object DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override Object ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::bnet.protocol.search.SearchTypes.internal__static_bnet_protocol_search_Object__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<Object, Object.Builder> InternalFieldAccessors {
      get { return global::bnet.protocol.search.SearchTypes.internal__static_bnet_protocol_search_Object__FieldAccessorTable; }
    }
    
    public const int IdFieldNumber = 1;
    private bool hasId;
    private pb::ByteString id_ = pb::ByteString.Empty;
    public bool HasId {
      get { return hasId; }
    }
    public pb::ByteString Id {
      get { return id_; }
    }
    
    public const int DataFieldNumber = 2;
    private bool hasData;
    private pb::ByteString data_ = pb::ByteString.Empty;
    public bool HasData {
      get { return hasData; }
    }
    public pb::ByteString Data {
      get { return data_; }
    }
    
    public const int StatisticsFieldNumber = 3;
    private pbc::PopsicleList<global::bnet.protocol.search.Statistic> statistics_ = new pbc::PopsicleList<global::bnet.protocol.search.Statistic>();
    public scg::IList<global::bnet.protocol.search.Statistic> StatisticsList {
      get { return statistics_; }
    }
    public int StatisticsCount {
      get { return statistics_.Count; }
    }
    public global::bnet.protocol.search.Statistic GetStatistics(int index) {
      return statistics_[index];
    }
    
    public override bool IsInitialized {
      get {
        if (!hasId) return false;
        foreach (global::bnet.protocol.search.Statistic element in StatisticsList) {
          if (!element.IsInitialized) return false;
        }
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      int size = SerializedSize;
      if (HasId) {
        output.WriteBytes(1, Id);
      }
      if (HasData) {
        output.WriteBytes(2, Data);
      }
      foreach (global::bnet.protocol.search.Statistic element in StatisticsList) {
        output.WriteMessage(3, element);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasId) {
          size += pb::CodedOutputStream.ComputeBytesSize(1, Id);
        }
        if (HasData) {
          size += pb::CodedOutputStream.ComputeBytesSize(2, Data);
        }
        foreach (global::bnet.protocol.search.Statistic element in StatisticsList) {
          size += pb::CodedOutputStream.ComputeMessageSize(3, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static Object ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Object ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Object ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static Object ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static Object ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Object ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Object ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static Object ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static Object ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static Object ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(Object prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<Object, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      Object result = new Object();
      
      protected override Object MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new Object();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::bnet.protocol.search.Object.Descriptor; }
      }
      
      public override Object DefaultInstanceForType {
        get { return global::bnet.protocol.search.Object.DefaultInstance; }
      }
      
      public override Object BuildPartial() {
        if (result == null) {
          throw new global::System.InvalidOperationException("build() has already been called on this Builder");
        }
        result.statistics_.MakeReadOnly();
        Object returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is Object) {
          return MergeFrom((Object) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(Object other) {
        if (other == global::bnet.protocol.search.Object.DefaultInstance) return this;
        if (other.HasId) {
          Id = other.Id;
        }
        if (other.HasData) {
          Data = other.Data;
        }
        if (other.statistics_.Count != 0) {
          base.AddRange(other.statistics_, result.statistics_);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = null;
        while (true) {
          uint tag = input.ReadTag();
          switch (tag) {
            case 0: {
              if (unknownFields != null) {
                this.UnknownFields = unknownFields.Build();
              }
              return this;
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag);
              break;
            }
            case 10: {
              Id = input.ReadBytes();
              break;
            }
            case 18: {
              Data = input.ReadBytes();
              break;
            }
            case 26: {
              global::bnet.protocol.search.Statistic.Builder subBuilder = global::bnet.protocol.search.Statistic.CreateBuilder();
              input.ReadMessage(subBuilder, extensionRegistry);
              AddStatistics(subBuilder.BuildPartial());
              break;
            }
          }
        }
      }
      
      
      public bool HasId {
        get { return result.HasId; }
      }
      public pb::ByteString Id {
        get { return result.Id; }
        set { SetId(value); }
      }
      public Builder SetId(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasId = true;
        result.id_ = value;
        return this;
      }
      public Builder ClearId() {
        result.hasId = false;
        result.id_ = pb::ByteString.Empty;
        return this;
      }
      
      public bool HasData {
        get { return result.HasData; }
      }
      public pb::ByteString Data {
        get { return result.Data; }
        set { SetData(value); }
      }
      public Builder SetData(pb::ByteString value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasData = true;
        result.data_ = value;
        return this;
      }
      public Builder ClearData() {
        result.hasData = false;
        result.data_ = pb::ByteString.Empty;
        return this;
      }
      
      public pbc::IPopsicleList<global::bnet.protocol.search.Statistic> StatisticsList {
        get { return result.statistics_; }
      }
      public int StatisticsCount {
        get { return result.StatisticsCount; }
      }
      public global::bnet.protocol.search.Statistic GetStatistics(int index) {
        return result.GetStatistics(index);
      }
      public Builder SetStatistics(int index, global::bnet.protocol.search.Statistic value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.statistics_[index] = value;
        return this;
      }
      public Builder SetStatistics(int index, global::bnet.protocol.search.Statistic.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.statistics_[index] = builderForValue.Build();
        return this;
      }
      public Builder AddStatistics(global::bnet.protocol.search.Statistic value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.statistics_.Add(value);
        return this;
      }
      public Builder AddStatistics(global::bnet.protocol.search.Statistic.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.statistics_.Add(builderForValue.Build());
        return this;
      }
      public Builder AddRangeStatistics(scg::IEnumerable<global::bnet.protocol.search.Statistic> values) {
        base.AddRange(values, result.statistics_);
        return this;
      }
      public Builder ClearStatistics() {
        result.statistics_.Clear();
        return this;
      }
    }
    static Object() {
      object.ReferenceEquals(global::bnet.protocol.search.SearchTypes.Descriptor, null);
    }
  }
  
  #endregion
  
}
