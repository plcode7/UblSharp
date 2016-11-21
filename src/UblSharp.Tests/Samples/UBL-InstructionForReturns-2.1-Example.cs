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
    internal class UBLInstructionForReturns21Example
    {
        public static InstructionForReturnsType Create()
        {
            var doc = new InstructionForReturnsType
            {
                UBLVersionID = "2.1",
                ID = "AB011",
                CopyIndicator = false,
                IssueDate = "2010-04-10",
                Note = new List<TextType>()
                {
                    new TextType
                    {
                        Value = "Instruction to return goods that are badly sent to you."
                    }
                },
                SellerSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new List<PartyNameType>()
                        {
                            new PartyNameType
                            {
                                Name = "Arancio Forniture spa"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Via Dell'Arcoveggio",
                            BuildingNumber = "403",
                            CityName = "Bologna",
                            PostalZone = "40129",
                            Country = new CountryType
                            {
                                IdentificationCode = "IT",
                                Name = "Italy"
                            }
                        },
                        Contact = new ContactType
                        {
                            Name = "Mr Rossi",
                            Telephone = "0039 051 23000000",
                            Telefax = "0039 051 23000023",
                            ElectronicMail = "rossi@arancioforniture.it"
                        }
                    }
                },
                RetailerCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new List<PartyNameType>()
                        {
                            new PartyNameType
                            {
                                Name = "Beta Shop"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Via Emilia",
                            BuildingNumber = "1",
                            CityName = "Modena",
                            PostalZone = "41121",
                            Country = new CountryType
                            {
                                IdentificationCode = "IT",
                                Name = "Italy"
                            }
                        },
                        Contact = new ContactType
                        {
                            Name = "Mr Delta",
                            Telephone = "0039 059 33000000",
                            Telefax = "0039 059 33000055",
                            ElectronicMail = "delta@betashop.it"
                        }
                    }
                },
                ManufacturerParty = new PartyType
                {
                    PartyName = new List<PartyNameType>()
                    {
                        new PartyNameType
                        {
                            Name = "AZ Outsourcing srl"
                        }
                    },
                    PostalAddress = new AddressType
                    {
                        StreetName = "Via Bolognese",
                        BuildingNumber = "199",
                        CityName = "Bologna",
                        PostalZone = "40129",
                        Country = new CountryType
                        {
                            IdentificationCode = "IT",
                            Name = "Italy"
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "Mr Verdi",
                        Telephone = "0039 051 25400000",
                        Telefax = "0039 051 25400023",
                        ElectronicMail = "verdi@azoutsourcing.it"
                    }
                },
                Shipment = new ShipmentType
                {
                    ID = "51022",
                    Consignment = new List<ConsignmentType>()
                    {
                        new ConsignmentType
                        {
                            ID = "510"
                        }
                    },
                    Delivery = new DeliveryType
                    {
                        DeliveryAddress = new AddressType
                        {
                            StreetName = "Via Dell'Arcoveggio",
                            BuildingNumber = "403",
                            CityName = "Bologna",
                            PostalZone = "40129",
                            Country = new CountryType
                            {
                                IdentificationCode = "IT",
                                Name = "Italy"
                            }
                        },
                        Despatch = new DespatchType
                        {
                            DespatchAddress = new AddressType
                            {
                                StreetName = "Via Emilia",
                                BuildingNumber = "1",
                                CityName = "Modena",
                                PostalZone = "41121",
                                Country = new CountryType
                                {
                                    IdentificationCode = "IT",
                                    Name = "Italy"
                                }
                            }
                        }
                    }
                },
                InstructionForReturnsLine = new List<InstructionForReturnsLineType>()
                {
                    new InstructionForReturnsLineType
                    {
                        ID = "1",
                        Quantity = new QuantityType
                        {
                            unitCode = "NAR",
                            Value = 20M
                        },
                        Item = new ItemType
                        {
                            Description = new List<TextType>()
                            {
                                new TextType
                                {
                                    Value = "Denim Jeans Jacket"
                                }
                            },
                            Name = "Jeans Jacket man",
                            BuyersItemIdentification = new ItemIdentificationType
                            {
                                ID = "AA109"
                            },
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "YX401"
                            }
                        }
                    },
                    new InstructionForReturnsLineType
                    {
                        ID = "2",
                        Quantity = new QuantityType
                        {
                            unitCode = "NAR",
                            Value = 5M
                        },
                        Item = new ItemType
                        {
                            Description = new List<TextType>()
                            {
                                new TextType
                                {
                                    Value = "Leather Jacket"
                                }
                            },
                            Name = "Leather Jacket man",
                            BuyersItemIdentification = new ItemIdentificationType
                            {
                                ID = "AA128"
                            },
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "YX233"
                            }
                        }
                    }
                },
            };
            doc.Xmlns = new System.Xml.Serialization.XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("cbc","urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
                new XmlQualifiedName("cac","urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"),
            });
            return doc;
        }
    }
}
