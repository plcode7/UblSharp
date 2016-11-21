// Generated by UblSharp.Tests.Generator
using System;
using System.Collections.Generic;
using System.Xml;
using UblSharp;
using UblSharp.CommonAggregateComponents;
using UblSharp.CommonExtensionComponents;
using UblSharp.UnqualifiedDataTypes;
using UblSharp.XmlDigitalSignature;
using UblSharp.Tests.Util;

namespace UblSharp.Tests.Samples
{
    internal class UBLOrderCancellation21Example
    {
        public static OrderCancellationType Create()
        {
            var doc = new OrderCancellationType
            {
                UBLVersionID = "2.1",
                CustomizationID = "urn:www.cenbii.eu:transaction:biicoretrdmXYZ:ver1.0",
                ProfileID = new IdentifierType
                {
                    schemeAgencyID = "BII",
                    schemeID = "Profile",
                    Value = "urn:www.cenbii.eu:profile:BIIXYZ:ver1.0"
                },
                ID = "7",
                IssueDate = "2010-01-21",
                IssueTime = "12:30:00",
                CancellationNote = new List<TextType>()
                {
                    new TextType
                    {
                        Value = "With reference to phone call"
                    }
                },
                OrderReference = new List<OrderReferenceType>()
                {
                    new OrderReferenceType
                    {
                        ID = "34"
                    }
                },
                BuyerCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeAgencyID = "9",
                            schemeID = "GLN",
                            Value = "7300072311115"
                        },
                        PartyIdentification = new List<PartyIdentificationType>()
                        {
                            new PartyIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeAgencyID = "9",
                                    schemeID = "GLN",
                                    Value = "7300070011115"
                                }
                            },
                            new PartyIdentificationType
                            {
                                ID = "PartyID123"
                            }
                        },
                        PartyName = new List<PartyNameType>()
                        {
                            new PartyNameType
                            {
                                Name = "Johnssons byggvaror"
                            }
                        },
                    }
                },
                SellerSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeAgencyID = "9",
                            schemeID = "GLN",
                            Value = "7302347231111"
                        },
                        PartyIdentification = new List<PartyIdentificationType>()
                        {
                            new PartyIdentificationType
                            {
                                ID = "SellerPartyID123"
                            }
                        },
                        PartyName = new List<PartyNameType>()
                        {
                            new PartyNameType
                            {
                                Name = "Moderna Produkter AB"
                            }
                        },
                    }
                }
            };
            doc.Xmlns = new System.Xml.Serialization.XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("cac","urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"),
                new XmlQualifiedName("cbc","urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
            });
            return doc;
        }
    }
}
