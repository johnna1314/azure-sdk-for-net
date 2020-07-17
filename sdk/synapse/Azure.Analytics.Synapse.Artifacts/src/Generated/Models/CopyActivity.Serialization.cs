// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class CopyActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Inputs))
            {
                writer.WritePropertyName("inputs");
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Outputs))
            {
                writer.WritePropertyName("outputs");
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LinkedServiceName))
            {
                writer.WritePropertyName("linkedServiceName");
                writer.WriteObjectValue(LinkedServiceName);
            }
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy");
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn");
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties");
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("source");
            writer.WriteObjectValue(Source);
            writer.WritePropertyName("sink");
            writer.WriteObjectValue(Sink);
            if (Optional.IsDefined(Translator))
            {
                writer.WritePropertyName("translator");
                writer.WriteObjectValue(Translator);
            }
            if (Optional.IsDefined(EnableStaging))
            {
                writer.WritePropertyName("enableStaging");
                writer.WriteObjectValue(EnableStaging);
            }
            if (Optional.IsDefined(StagingSettings))
            {
                writer.WritePropertyName("stagingSettings");
                writer.WriteObjectValue(StagingSettings);
            }
            if (Optional.IsDefined(ParallelCopies))
            {
                writer.WritePropertyName("parallelCopies");
                writer.WriteObjectValue(ParallelCopies);
            }
            if (Optional.IsDefined(DataIntegrationUnits))
            {
                writer.WritePropertyName("dataIntegrationUnits");
                writer.WriteObjectValue(DataIntegrationUnits);
            }
            if (Optional.IsDefined(EnableSkipIncompatibleRow))
            {
                writer.WritePropertyName("enableSkipIncompatibleRow");
                writer.WriteObjectValue(EnableSkipIncompatibleRow);
            }
            if (Optional.IsDefined(RedirectIncompatibleRowSettings))
            {
                writer.WritePropertyName("redirectIncompatibleRowSettings");
                writer.WriteObjectValue(RedirectIncompatibleRowSettings);
            }
            if (Optional.IsCollectionDefined(PreserveRules))
            {
                writer.WritePropertyName("preserveRules");
                writer.WriteStartArray();
                foreach (var item in PreserveRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Preserve))
            {
                writer.WritePropertyName("preserve");
                writer.WriteStartArray();
                foreach (var item in Preserve)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static CopyActivity DeserializeCopyActivity(JsonElement element)
        {
            Optional<IList<DatasetReference>> inputs = default;
            Optional<IList<DatasetReference>> outputs = default;
            Optional<LinkedServiceReference> linkedServiceName = default;
            Optional<ActivityPolicy> policy = default;
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<IList<ActivityDependency>> dependsOn = default;
            Optional<IList<UserProperty>> userProperties = default;
            CopySource source = default;
            CopySink sink = default;
            Optional<object> translator = default;
            Optional<object> enableStaging = default;
            Optional<StagingSettings> stagingSettings = default;
            Optional<object> parallelCopies = default;
            Optional<object> dataIntegrationUnits = default;
            Optional<object> enableSkipIncompatibleRow = default;
            Optional<RedirectIncompatibleRowSettings> redirectIncompatibleRowSettings = default;
            Optional<IList<object>> preserveRules = default;
            Optional<IList<object>> preserve = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inputs"))
                {
                    List<DatasetReference> array = new List<DatasetReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetReference.DeserializeDatasetReference(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"))
                {
                    List<DatasetReference> array = new List<DatasetReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetReference.DeserializeDatasetReference(item));
                    }
                    outputs = array;
                    continue;
                }
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("policy"))
                {
                    policy = ActivityPolicy.DeserializeActivityPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"))
                {
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityDependency.DeserializeActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"))
                {
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserProperty.DeserializeUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("source"))
                        {
                            source = CopySource.DeserializeCopySource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sink"))
                        {
                            sink = CopySink.DeserializeCopySink(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("translator"))
                        {
                            translator = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("enableStaging"))
                        {
                            enableStaging = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("stagingSettings"))
                        {
                            stagingSettings = StagingSettings.DeserializeStagingSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("parallelCopies"))
                        {
                            parallelCopies = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("dataIntegrationUnits"))
                        {
                            dataIntegrationUnits = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("enableSkipIncompatibleRow"))
                        {
                            enableSkipIncompatibleRow = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("redirectIncompatibleRowSettings"))
                        {
                            redirectIncompatibleRowSettings = RedirectIncompatibleRowSettings.DeserializeRedirectIncompatibleRowSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("preserveRules"))
                        {
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetObject());
                            }
                            preserveRules = array;
                            continue;
                        }
                        if (property0.NameEquals("preserve"))
                        {
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetObject());
                            }
                            preserve = array;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CopyActivity(name, type, description.Value, Optional.ToList(dependsOn), Optional.ToList(userProperties), additionalProperties, linkedServiceName.Value, policy.Value, Optional.ToList(inputs), Optional.ToList(outputs), source, sink, translator.Value, enableStaging.Value, stagingSettings.Value, parallelCopies.Value, dataIntegrationUnits.Value, enableSkipIncompatibleRow.Value, redirectIncompatibleRowSettings.Value, Optional.ToList(preserveRules), Optional.ToList(preserve));
        }
    }
}
