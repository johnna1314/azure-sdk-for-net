// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sphere.Models
{
    public partial class ProofOfPossessionNonceResponse
    {
        internal static ProofOfPossessionNonceResponse DeserializeProofOfPossessionNonceResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> certificate = default;
            Optional<SphereCertificateStatus> status = default;
            Optional<string> subject = default;
            Optional<string> thumbprint = default;
            Optional<DateTimeOffset> expiryUtc = default;
            Optional<DateTimeOffset> notBeforeUtc = default;
            Optional<SphereProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificate"u8))
                {
                    certificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SphereCertificateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subject"u8))
                {
                    subject = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("notBeforeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notBeforeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new SphereProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new ProofOfPossessionNonceResponse(certificate.Value, Optional.ToNullable(status), subject.Value, thumbprint.Value, Optional.ToNullable(expiryUtc), Optional.ToNullable(notBeforeUtc), Optional.ToNullable(provisioningState));
        }
    }
}
