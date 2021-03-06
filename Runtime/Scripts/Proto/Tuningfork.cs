//-----------------------------------------------------------------------
// <copyright file="Tuningfork.cs" company="Google">
//
// Copyright 2020 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tuningfork.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Android.PerformanceTuner {

  /// <summary>Holder for reflection information generated from tuningfork.proto</summary>
  public static partial class TuningforkReflection {

    #region Descriptor
    /// <summary>File descriptor for tuningfork.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TuningforkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVQcml2YXRlL0VkaXRvci9Qcm90by90dW5pbmdmb3JrLnByb3RvEhxnb29n",
            "bGUucGVyZm9ybWFuY2VwYXJhbWV0ZXJzIu8FCghTZXR0aW5ncxJYChRhZ2dy",
            "ZWdhdGlvbl9zdHJhdGVneRgBIAEoCzI6Lmdvb2dsZS5wZXJmb3JtYW5jZXBh",
            "cmFtZXRlcnMuU2V0dGluZ3MuQWdncmVnYXRpb25TdHJhdGVneRJECgpoaXN0",
            "b2dyYW1zGAIgAygLMjAuZ29vZ2xlLnBlcmZvcm1hbmNlcGFyYW1ldGVycy5T",
            "ZXR0aW5ncy5IaXN0b2dyYW0SEAoIYmFzZV91cmkYAyABKAkSDwoHYXBpX2tl",
            "eRgEIAEoCRIsCiRkZWZhdWx0X2ZpZGVsaXR5X3BhcmFtZXRlcnNfZmlsZW5h",
            "bWUYBSABKAkSIgoaaW5pdGlhbF9yZXF1ZXN0X3RpbWVvdXRfbXMYBiABKAUS",
            "IwobdWx0aW1hdGVfcmVxdWVzdF90aW1lb3V0X21zGAcgASgFEiAKGGxvYWRp",
            "bmdfYW5ub3RhdGlvbl9pbmRleBhkIAEoBRIeChZsZXZlbF9hbm5vdGF0aW9u",
            "X2luZGV4GGUgASgFGl4KCUhpc3RvZ3JhbRIWCg5pbnN0cnVtZW50X2tleRgB",
            "IAEoBRISCgpidWNrZXRfbWluGAIgASgCEhIKCmJ1Y2tldF9tYXgYAyABKAIS",
            "EQoJbl9idWNrZXRzGAQgASgFGoYCChNBZ2dyZWdhdGlvblN0cmF0ZWd5ElUK",
            "Bm1ldGhvZBgBIAEoDjJFLmdvb2dsZS5wZXJmb3JtYW5jZXBhcmFtZXRlcnMu",
            "U2V0dGluZ3MuQWdncmVnYXRpb25TdHJhdGVneS5TdWJtaXNzaW9uEhsKE2lu",
            "dGVydmFsbXNfb3JfY291bnQYAiABKAUSIAoYbWF4X2luc3RydW1lbnRhdGlv",
            "bl9rZXlzGAMgASgFEhwKFGFubm90YXRpb25fZW51bV9zaXplGAQgAygFIjsK",
            "ClN1Ym1pc3Npb24SDQoJVU5ERUZJTkVEEAASDgoKVElNRV9CQVNFRBABEg4K",
            "ClRJQ0tfQkFTRUQQAkIiqgIfR29vZ2xlLkFuZHJvaWQuUGVyZm9ybWFuY2VU",
            "dW5lcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Android.PerformanceTuner.Settings), global::Google.Android.PerformanceTuner.Settings.Parser, new[]{ "AggregationStrategy", "Histograms", "BaseUri", "ApiKey", "DefaultFidelityParametersFilename", "InitialRequestTimeoutMs", "UltimateRequestTimeoutMs", "LoadingAnnotationIndex", "LevelAnnotationIndex" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Android.PerformanceTuner.Settings.Types.Histogram), global::Google.Android.PerformanceTuner.Settings.Types.Histogram.Parser, new[]{ "InstrumentKey", "BucketMin", "BucketMax", "NBuckets" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Android.PerformanceTuner.Settings.Types.AggregationStrategy), global::Google.Android.PerformanceTuner.Settings.Types.AggregationStrategy.Parser, new[]{ "Method", "IntervalmsOrCount", "MaxInstrumentationKeys", "AnnotationEnumSize" }, null, new[]{ typeof(global::Google.Android.PerformanceTuner.Settings.Types.AggregationStrategy.Types.Submission) }, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Passed by the user to tuning fork at initialization.
  /// </summary>
  public sealed partial class Settings : pb::IMessage<Settings> {
    private static readonly pb::MessageParser<Settings> _parser = new pb::MessageParser<Settings>(() => new Settings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Settings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Android.PerformanceTuner.TuningforkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Settings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Settings(Settings other) : this() {
      AggregationStrategy = other.aggregationStrategy_ != null ? other.AggregationStrategy.Clone() : null;
      histograms_ = other.histograms_.Clone();
      baseUri_ = other.baseUri_;
      apiKey_ = other.apiKey_;
      defaultFidelityParametersFilename_ = other.defaultFidelityParametersFilename_;
      initialRequestTimeoutMs_ = other.initialRequestTimeoutMs_;
      ultimateRequestTimeoutMs_ = other.ultimateRequestTimeoutMs_;
      loadingAnnotationIndex_ = other.loadingAnnotationIndex_;
      levelAnnotationIndex_ = other.levelAnnotationIndex_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Settings Clone() {
      return new Settings(this);
    }

    /// <summary>Field number for the "aggregation_strategy" field.</summary>
    public const int AggregationStrategyFieldNumber = 1;
    private global::Google.Android.PerformanceTuner.Settings.Types.AggregationStrategy aggregationStrategy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Android.PerformanceTuner.Settings.Types.AggregationStrategy AggregationStrategy {
      get { return aggregationStrategy_; }
      set {
        aggregationStrategy_ = value;
      }
    }

    /// <summary>Field number for the "histograms" field.</summary>
    public const int HistogramsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Android.PerformanceTuner.Settings.Types.Histogram> _repeated_histograms_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Android.PerformanceTuner.Settings.Types.Histogram.Parser);
    private readonly pbc::RepeatedField<global::Google.Android.PerformanceTuner.Settings.Types.Histogram> histograms_ = new pbc::RepeatedField<global::Google.Android.PerformanceTuner.Settings.Types.Histogram>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Android.PerformanceTuner.Settings.Types.Histogram> Histograms {
      get { return histograms_; }
    }

    /// <summary>Field number for the "base_uri" field.</summary>
    public const int BaseUriFieldNumber = 3;
    private string baseUri_ = "";
    /// <summary>
    ///  Base request URI.
    ///  If missing, https://performanceparameters.googleapis.com/v1/ is used.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BaseUri {
      get { return baseUri_; }
      set {
        baseUri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "api_key" field.</summary>
    public const int ApiKeyFieldNumber = 4;
    private string apiKey_ = "";
    /// <summary>
    ///  Google Play API key.
    ///  Requests may receive an error response if this is missing or wrong.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ApiKey {
      get { return apiKey_; }
      set {
        apiKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "default_fidelity_parameters_filename" field.</summary>
    public const int DefaultFidelityParametersFilenameFieldNumber = 5;
    private string defaultFidelityParametersFilename_ = "";
    /// <summary>
    ///  Name of the fidelitiy_parameters.bin file in assets/tuningfork
    ///   used if no download was ever successful.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DefaultFidelityParametersFilename {
      get { return defaultFidelityParametersFilename_; }
      set {
        defaultFidelityParametersFilename_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "initial_request_timeout_ms" field.</summary>
    public const int InitialRequestTimeoutMsFieldNumber = 6;
    private int initialRequestTimeoutMs_;
    /// <summary>
    ///  Timeout before first timeout of fidelity parameters request.
    ///  The request will then be repeated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int InitialRequestTimeoutMs {
      get { return initialRequestTimeoutMs_; }
      set {
        initialRequestTimeoutMs_ = value;
      }
    }

    /// <summary>Field number for the "ultimate_request_timeout_ms" field.</summary>
    public const int UltimateRequestTimeoutMsFieldNumber = 7;
    private int ultimateRequestTimeoutMs_;
    /// <summary>
    ///  The time after which repeat requests are ceased.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UltimateRequestTimeoutMs {
      get { return ultimateRequestTimeoutMs_; }
      set {
        ultimateRequestTimeoutMs_ = value;
      }
    }

    /// <summary>Field number for the "loading_annotation_index" field.</summary>
    public const int LoadingAnnotationIndexFieldNumber = 100;
    private int loadingAnnotationIndex_;
    /// <summary>
    ///  Reserve 100-120 for indexes into the annotation array.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LoadingAnnotationIndex {
      get { return loadingAnnotationIndex_; }
      set {
        loadingAnnotationIndex_ = value;
      }
    }

    /// <summary>Field number for the "level_annotation_index" field.</summary>
    public const int LevelAnnotationIndexFieldNumber = 101;
    private int levelAnnotationIndex_;
    /// <summary>
    ///  1-based index
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LevelAnnotationIndex {
      get { return levelAnnotationIndex_; }
      set {
        levelAnnotationIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Settings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Settings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AggregationStrategy, other.AggregationStrategy)) return false;
      if(!histograms_.Equals(other.histograms_)) return false;
      if (BaseUri != other.BaseUri) return false;
      if (ApiKey != other.ApiKey) return false;
      if (DefaultFidelityParametersFilename != other.DefaultFidelityParametersFilename) return false;
      if (InitialRequestTimeoutMs != other.InitialRequestTimeoutMs) return false;
      if (UltimateRequestTimeoutMs != other.UltimateRequestTimeoutMs) return false;
      if (LoadingAnnotationIndex != other.LoadingAnnotationIndex) return false;
      if (LevelAnnotationIndex != other.LevelAnnotationIndex) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (aggregationStrategy_ != null) hash ^= AggregationStrategy.GetHashCode();
      hash ^= histograms_.GetHashCode();
      if (BaseUri.Length != 0) hash ^= BaseUri.GetHashCode();
      if (ApiKey.Length != 0) hash ^= ApiKey.GetHashCode();
      if (DefaultFidelityParametersFilename.Length != 0) hash ^= DefaultFidelityParametersFilename.GetHashCode();
      if (InitialRequestTimeoutMs != 0) hash ^= InitialRequestTimeoutMs.GetHashCode();
      if (UltimateRequestTimeoutMs != 0) hash ^= UltimateRequestTimeoutMs.GetHashCode();
      if (LoadingAnnotationIndex != 0) hash ^= LoadingAnnotationIndex.GetHashCode();
      if (LevelAnnotationIndex != 0) hash ^= LevelAnnotationIndex.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (aggregationStrategy_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AggregationStrategy);
      }
      histograms_.WriteTo(output, _repeated_histograms_codec);
      if (BaseUri.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(BaseUri);
      }
      if (ApiKey.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ApiKey);
      }
      if (DefaultFidelityParametersFilename.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(DefaultFidelityParametersFilename);
      }
      if (InitialRequestTimeoutMs != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(InitialRequestTimeoutMs);
      }
      if (UltimateRequestTimeoutMs != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(UltimateRequestTimeoutMs);
      }
      if (LoadingAnnotationIndex != 0) {
        output.WriteRawTag(160, 6);
        output.WriteInt32(LoadingAnnotationIndex);
      }
      if (LevelAnnotationIndex != 0) {
        output.WriteRawTag(168, 6);
        output.WriteInt32(LevelAnnotationIndex);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (aggregationStrategy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AggregationStrategy);
      }
      size += histograms_.CalculateSize(_repeated_histograms_codec);
      if (BaseUri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BaseUri);
      }
      if (ApiKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApiKey);
      }
      if (DefaultFidelityParametersFilename.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DefaultFidelityParametersFilename);
      }
      if (InitialRequestTimeoutMs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(InitialRequestTimeoutMs);
      }
      if (UltimateRequestTimeoutMs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UltimateRequestTimeoutMs);
      }
      if (LoadingAnnotationIndex != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(LoadingAnnotationIndex);
      }
      if (LevelAnnotationIndex != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(LevelAnnotationIndex);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Settings other) {
      if (other == null) {
        return;
      }
      if (other.aggregationStrategy_ != null) {
        if (aggregationStrategy_ == null) {
          aggregationStrategy_ = new global::Google.Android.PerformanceTuner.Settings.Types.AggregationStrategy();
        }
        AggregationStrategy.MergeFrom(other.AggregationStrategy);
      }
      histograms_.Add(other.histograms_);
      if (other.BaseUri.Length != 0) {
        BaseUri = other.BaseUri;
      }
      if (other.ApiKey.Length != 0) {
        ApiKey = other.ApiKey;
      }
      if (other.DefaultFidelityParametersFilename.Length != 0) {
        DefaultFidelityParametersFilename = other.DefaultFidelityParametersFilename;
      }
      if (other.InitialRequestTimeoutMs != 0) {
        InitialRequestTimeoutMs = other.InitialRequestTimeoutMs;
      }
      if (other.UltimateRequestTimeoutMs != 0) {
        UltimateRequestTimeoutMs = other.UltimateRequestTimeoutMs;
      }
      if (other.LoadingAnnotationIndex != 0) {
        LoadingAnnotationIndex = other.LoadingAnnotationIndex;
      }
      if (other.LevelAnnotationIndex != 0) {
        LevelAnnotationIndex = other.LevelAnnotationIndex;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (aggregationStrategy_ == null) {
              aggregationStrategy_ = new global::Google.Android.PerformanceTuner.Settings.Types.AggregationStrategy();
            }
            input.ReadMessage(aggregationStrategy_);
            break;
          }
          case 18: {
            histograms_.AddEntriesFrom(input, _repeated_histograms_codec);
            break;
          }
          case 26: {
            BaseUri = input.ReadString();
            break;
          }
          case 34: {
            ApiKey = input.ReadString();
            break;
          }
          case 42: {
            DefaultFidelityParametersFilename = input.ReadString();
            break;
          }
          case 48: {
            InitialRequestTimeoutMs = input.ReadInt32();
            break;
          }
          case 56: {
            UltimateRequestTimeoutMs = input.ReadInt32();
            break;
          }
          case 800: {
            LoadingAnnotationIndex = input.ReadInt32();
            break;
          }
          case 808: {
            LevelAnnotationIndex = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Settings message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class Histogram : pb::IMessage<Histogram> {
        private static readonly pb::MessageParser<Histogram> _parser = new pb::MessageParser<Histogram>(() => new Histogram());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Histogram> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Android.PerformanceTuner.Settings.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Histogram() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Histogram(Histogram other) : this() {
          instrumentKey_ = other.instrumentKey_;
          bucketMin_ = other.bucketMin_;
          bucketMax_ = other.bucketMax_;
          nBuckets_ = other.nBuckets_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Histogram Clone() {
          return new Histogram(this);
        }

        /// <summary>Field number for the "instrument_key" field.</summary>
        public const int InstrumentKeyFieldNumber = 1;
        private int instrumentKey_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int InstrumentKey {
          get { return instrumentKey_; }
          set {
            instrumentKey_ = value;
          }
        }

        /// <summary>Field number for the "bucket_min" field.</summary>
        public const int BucketMinFieldNumber = 2;
        private float bucketMin_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float BucketMin {
          get { return bucketMin_; }
          set {
            bucketMin_ = value;
          }
        }

        /// <summary>Field number for the "bucket_max" field.</summary>
        public const int BucketMaxFieldNumber = 3;
        private float bucketMax_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float BucketMax {
          get { return bucketMax_; }
          set {
            bucketMax_ = value;
          }
        }

        /// <summary>Field number for the "n_buckets" field.</summary>
        public const int NBucketsFieldNumber = 4;
        private int nBuckets_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int NBuckets {
          get { return nBuckets_; }
          set {
            nBuckets_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Histogram);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Histogram other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (InstrumentKey != other.InstrumentKey) return false;
          if (BucketMin != other.BucketMin) return false;
          if (BucketMax != other.BucketMax) return false;
          if (NBuckets != other.NBuckets) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (InstrumentKey != 0) hash ^= InstrumentKey.GetHashCode();
          if (BucketMin != 0F) hash ^= BucketMin.GetHashCode();
          if (BucketMax != 0F) hash ^= BucketMax.GetHashCode();
          if (NBuckets != 0) hash ^= NBuckets.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (InstrumentKey != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(InstrumentKey);
          }
          if (BucketMin != 0F) {
            output.WriteRawTag(21);
            output.WriteFloat(BucketMin);
          }
          if (BucketMax != 0F) {
            output.WriteRawTag(29);
            output.WriteFloat(BucketMax);
          }
          if (NBuckets != 0) {
            output.WriteRawTag(32);
            output.WriteInt32(NBuckets);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (InstrumentKey != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(InstrumentKey);
          }
          if (BucketMin != 0F) {
            size += 1 + 4;
          }
          if (BucketMax != 0F) {
            size += 1 + 4;
          }
          if (NBuckets != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(NBuckets);
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Histogram other) {
          if (other == null) {
            return;
          }
          if (other.InstrumentKey != 0) {
            InstrumentKey = other.InstrumentKey;
          }
          if (other.BucketMin != 0F) {
            BucketMin = other.BucketMin;
          }
          if (other.BucketMax != 0F) {
            BucketMax = other.BucketMax;
          }
          if (other.NBuckets != 0) {
            NBuckets = other.NBuckets;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 8: {
                InstrumentKey = input.ReadInt32();
                break;
              }
              case 21: {
                BucketMin = input.ReadFloat();
                break;
              }
              case 29: {
                BucketMax = input.ReadFloat();
                break;
              }
              case 32: {
                NBuckets = input.ReadInt32();
                break;
              }
            }
          }
        }

      }

      public sealed partial class AggregationStrategy : pb::IMessage<AggregationStrategy> {
        private static readonly pb::MessageParser<AggregationStrategy> _parser = new pb::MessageParser<AggregationStrategy>(() => new AggregationStrategy());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<AggregationStrategy> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Android.PerformanceTuner.Settings.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public AggregationStrategy() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public AggregationStrategy(AggregationStrategy other) : this() {
          method_ = other.method_;
          intervalmsOrCount_ = other.intervalmsOrCount_;
          maxInstrumentationKeys_ = other.maxInstrumentationKeys_;
          annotationEnumSize_ = other.annotationEnumSize_.Clone();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public AggregationStrategy Clone() {
          return new AggregationStrategy(this);
        }

        /// <summary>Field number for the "method" field.</summary>
        public const int MethodFieldNumber = 1;
        private global::Google.Android.PerformanceTuner.Settings.Types.AggregationStrategy.Types.Submission method_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Android.PerformanceTuner.Settings.Types.AggregationStrategy.Types.Submission Method {
          get { return method_; }
          set {
            method_ = value;
          }
        }

        /// <summary>Field number for the "intervalms_or_count" field.</summary>
        public const int IntervalmsOrCountFieldNumber = 2;
        private int intervalmsOrCount_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int IntervalmsOrCount {
          get { return intervalmsOrCount_; }
          set {
            intervalmsOrCount_ = value;
          }
        }

        /// <summary>Field number for the "max_instrumentation_keys" field.</summary>
        public const int MaxInstrumentationKeysFieldNumber = 3;
        private int maxInstrumentationKeys_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int MaxInstrumentationKeys {
          get { return maxInstrumentationKeys_; }
          set {
            maxInstrumentationKeys_ = value;
          }
        }

        /// <summary>Field number for the "annotation_enum_size" field.</summary>
        public const int AnnotationEnumSizeFieldNumber = 4;
        private static readonly pb::FieldCodec<int> _repeated_annotationEnumSize_codec
            = pb::FieldCodec.ForInt32(34);
        private readonly pbc::RepeatedField<int> annotationEnumSize_ = new pbc::RepeatedField<int>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<int> AnnotationEnumSize {
          get { return annotationEnumSize_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as AggregationStrategy);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(AggregationStrategy other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Method != other.Method) return false;
          if (IntervalmsOrCount != other.IntervalmsOrCount) return false;
          if (MaxInstrumentationKeys != other.MaxInstrumentationKeys) return false;
          if(!annotationEnumSize_.Equals(other.annotationEnumSize_)) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Method != 0) hash ^= Method.GetHashCode();
          if (IntervalmsOrCount != 0) hash ^= IntervalmsOrCount.GetHashCode();
          if (MaxInstrumentationKeys != 0) hash ^= MaxInstrumentationKeys.GetHashCode();
          hash ^= annotationEnumSize_.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Method != 0) {
            output.WriteRawTag(8);
            output.WriteEnum((int) Method);
          }
          if (IntervalmsOrCount != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(IntervalmsOrCount);
          }
          if (MaxInstrumentationKeys != 0) {
            output.WriteRawTag(24);
            output.WriteInt32(MaxInstrumentationKeys);
          }
          annotationEnumSize_.WriteTo(output, _repeated_annotationEnumSize_codec);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Method != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Method);
          }
          if (IntervalmsOrCount != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(IntervalmsOrCount);
          }
          if (MaxInstrumentationKeys != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxInstrumentationKeys);
          }
          size += annotationEnumSize_.CalculateSize(_repeated_annotationEnumSize_codec);
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(AggregationStrategy other) {
          if (other == null) {
            return;
          }
          if (other.Method != 0) {
            Method = other.Method;
          }
          if (other.IntervalmsOrCount != 0) {
            IntervalmsOrCount = other.IntervalmsOrCount;
          }
          if (other.MaxInstrumentationKeys != 0) {
            MaxInstrumentationKeys = other.MaxInstrumentationKeys;
          }
          annotationEnumSize_.Add(other.annotationEnumSize_);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 8: {
                method_ = (global::Google.Android.PerformanceTuner.Settings.Types.AggregationStrategy.Types.Submission) input.ReadEnum();
                break;
              }
              case 16: {
                IntervalmsOrCount = input.ReadInt32();
                break;
              }
              case 24: {
                MaxInstrumentationKeys = input.ReadInt32();
                break;
              }
              case 34:
              case 32: {
                annotationEnumSize_.AddEntriesFrom(input, _repeated_annotationEnumSize_codec);
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the AggregationStrategy message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types {
          public enum Submission {
            [pbr::OriginalName("UNDEFINED")] Undefined = 0,
            [pbr::OriginalName("TIME_BASED")] TimeBased = 1,
            [pbr::OriginalName("TICK_BASED")] TickBased = 2,
          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
