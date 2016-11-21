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
    internal class UBLTransportExecutionPlanRequest21Example
    {
        public static TransportExecutionPlanRequestType Create()
        {
            var doc = new TransportExecutionPlanRequestType
            {
                UBLVersionID = "2.1",
                ID = "TEPR_1",
                VersionID = "1",
                IssueDate = "2011-09-13",
                IssueTime = "10:00:10+01:00",
                DocumentStatusCode = "NotConfirmed",
                SenderParty = new PartyType
                {
                    PartyIdentification = new List<PartyIdentificationType>()
                    {
                        new PartyIdentificationType
                        {
                            ID = new IdentifierType
                            {
                                schemeAgencyName = "GS1",
                                schemeName = "GLN",
                                Value = "4058673827000"
                            }
                        }
                    },
                    PartyName = new List<PartyNameType>()
                    {
                        new PartyNameType
                        {
                            Name = "Consignor"
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "SomeName",
                        Telephone = "+8687878763",
                        ElectronicMail = "SomeName@consignor.cn"
                    }
                },
                ReceiverParty = new PartyType
                {
                    PartyIdentification = new List<PartyIdentificationType>()
                    {
                        new PartyIdentificationType
                        {
                            ID = new IdentifierType
                            {
                                schemeAgencyName = "GS1",
                                schemeName = "GLN",
                                Value = "4058673827641"
                            }
                        }
                    },
                    PartyName = new List<PartyNameType>()
                    {
                        new PartyNameType
                        {
                            Name = "NECOSS"
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "SomeName",
                        Telephone = "+49450557000",
                        ElectronicMail = "SomeName@necoss.de"
                    }
                },
                TransportUserParty = new PartyType
                {
                    PartyIdentification = new List<PartyIdentificationType>()
                    {
                        new PartyIdentificationType
                        {
                            ID = new IdentifierType
                            {
                                schemeAgencyName = "GS1",
                                schemeName = "GLN",
                                Value = "4058673827000"
                            }
                        }
                    },
                    PartyName = new List<PartyNameType>()
                    {
                        new PartyNameType
                        {
                            Name = "Consignor"
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "SomeName",
                        Telephone = "+8687878763",
                        ElectronicMail = "SomeName@consignor.cn"
                    }
                },
                TransportServiceProviderParty = new PartyType
                {
                    PartyIdentification = new List<PartyIdentificationType>()
                    {
                        new PartyIdentificationType
                        {
                            ID = new IdentifierType
                            {
                                schemeAgencyName = "GS1",
                                schemeName = "GLN",
                                Value = "4058673827641"
                            }
                        }
                    },
                    PartyName = new List<PartyNameType>()
                    {
                        new PartyNameType
                        {
                            Name = "NECOSS"
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "SomeName",
                        Telephone = "+49450557000",
                        ElectronicMail = "SomeName@necoss.de"
                    }
                },
                TransportServiceDescriptionDocumentReference = new DocumentReferenceType
                {
                    ID = "2"
                },
                TransportContract = new ContractType
                {
                    Note = new List<TextType>()
                    {
                        new TextType
                        {
                            Value = "Framework Agreement"
                        }
                    },
                    ContractDocumentReference = new List<DocumentReferenceType>()
                    {
                        new DocumentReferenceType
                        {
                            ID = "TC101",
                            IssueDate = "2010-01-01",
                            DocumentTypeCode = "315",
                            DocumentType = "Contract",
                            DocumentDescription = new List<TextType>()
                            {
                                new TextType
                                {
                                    Value = "Framework Agreement between Consignor and NECOSS"
                                }
                            },
                        }
                    },
                },
                TransportServiceProviderResponseDeadlinePeriod = new List<PeriodType>()
                {
                    new PeriodType
                    {
                        EndDate = "2011-09-13",
                        EndTime = "11:00:10+01:00"
                    }
                },
                MainTransportationService = new TransportationServiceType
                {
                    TransportServiceCode = "3",
                    TransportationServiceDescription = new List<TextType>()
                    {
                        new TextType
                        {
                            Value = "Transport from Hamburg to Nurnberg"
                        }
                    },
                },
                ServiceEndTimePeriod = new PeriodType
                {
                    EndDate = "2011-10-06",
                    EndTime = "16:00:10+01:00"
                },
                FromLocation = new LocationType
                {
                    LocationTypeCode = "13",
                    Address = new AddressType
                    {
                        ID = new IdentifierType
                        {
                            schemeAgencyName = "UN",
                            schemeName = "UN/LOCODE",
                            Value = "DEHAM"
                        },
                        StreetName = "Neuer Wandrahm 4",
                        CityName = "Hamburg",
                        PostalZone = "29400",
                        Country = new CountryType
                        {
                            IdentificationCode = "DE"
                        }
                    }
                },
                ToLocation = new LocationType
                {
                    LocationTypeCode = "7",
                    Address = new AddressType
                    {
                        StreetName = "Grosse strasse 34",
                        CityName = "Nurnberg",
                        PostalZone = "28400",
                        Country = new CountryType
                        {
                            IdentificationCode = "DE"
                        }
                    }
                },
                TransportExecutionTerms = new TransportExecutionTermsType
                {
                    DeliveryTerms = new List<DeliveryTermsType>()
                    {
                        new DeliveryTermsType
                        {
                            ID = new IdentifierType
                            {
                                schemeAgencyName = "INCOTERMS",
                                Value = "EXW"
                            },
                            DeliveryLocation = new LocationType
                            {
                                Address = new AddressType
                                {
                                    CityName = "Hamburg"
                                }
                            }
                        }
                    },
                    NotificationRequirement = new List<NotificationRequirementType>()
                    {
                        new NotificationRequirementType
                        {
                            NotificationTypeCode = "TIME_SCHEDULE_DEVIATIONS",
                            NotifyParty = new List<PartyType>()
                            {
                                new PartyType
                                {
                                    EndpointID = "www.consignee.de/statusnotifications/",
                                    PartyName = new List<PartyNameType>()
                                    {
                                        new PartyNameType
                                        {
                                            Name = "Consignee"
                                        }
                                    },
                                    Contact = new ContactType
                                    {
                                        ElectronicMail = "someName@consignee.de"
                                    }
                                },
                                new PartyType
                                {
                                    EndpointID = "www.consignor.cn/statusnotifications/",
                                    PartyName = new List<PartyNameType>()
                                    {
                                        new PartyNameType
                                        {
                                            Name = "Consignor"
                                        }
                                    },
                                    Contact = new ContactType
                                    {
                                        ElectronicMail = "someName@consignor.cn"
                                    }
                                }
                            },
                        },
                        new NotificationRequirementType
                        {
                            NotificationTypeCode = "ITEM_CONDITION_DEVIATIONS",
                            PostEventNotificationDurationMeasure = new MeasureType
                            {
                                unitCode = "MIN",
                                Value = 10M
                            },
                            NotifyParty = new List<PartyType>()
                            {
                                new PartyType
                                {
                                    EndpointID = "www.consignee.com/statusnotifications/",
                                    PartyName = new List<PartyNameType>()
                                    {
                                        new PartyNameType
                                        {
                                            Name = "Consignee"
                                        }
                                    },
                                    Contact = new ContactType
                                    {
                                        ElectronicMail = "someName@consignee.de"
                                    }
                                },
                                new PartyType
                                {
                                    EndpointID = "www.consignor.cn/statusnotifications/",
                                    PartyName = new List<PartyNameType>()
                                    {
                                        new PartyNameType
                                        {
                                            Name = "Consignor"
                                        }
                                    },
                                    Contact = new ContactType
                                    {
                                        ElectronicMail = "someName@consignor.cn"
                                    }
                                }
                            },
                        }
                    },
                },
                Consignment = new List<ConsignmentType>()
                {
                    new ConsignmentType
                    {
                        ID = "CON_1",
                        GrossWeightMeasure = new MeasureType
                        {
                            unitCode = "KGM",
                            Value = 50000M
                        },
                        NetWeightMeasure = new MeasureType
                        {
                            unitCode = "KGM",
                            Value = 3000M
                        },
                        GrossVolumeMeasure = new MeasureType
                        {
                            unitCode = "MTQ",
                            Value = 78M
                        },
                        LoadingLengthMeasure = new MeasureType
                        {
                            unitCode = "MTR",
                            Value = 12M
                        },
                        HazardousRiskIndicator = false,
                        TotalTransportHandlingUnitQuantity = 2M,
                        ConsolidatedShipment = new List<ShipmentType>()
                        {
                            new ShipmentType
                            {
                                ID = "GSIN_1"
                            },
                            new ShipmentType
                            {
                                ID = "GSIN_2"
                            }
                        },
                        RequestedPickupTransportEvent = new TransportEventType
                        {
                            Location = new LocationType
                            {
                                Address = new AddressType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyName = "UN",
                                        schemeName = "UN/LOCODE",
                                        Value = "DEHAM"
                                    },
                                    StreetName = "Neuer Wandrahm 4",
                                    CityName = "Hamburg",
                                    PostalZone = "29400",
                                    Country = new CountryType
                                    {
                                        IdentificationCode = "DE"
                                    }
                                }
                            },
                            Period = new List<PeriodType>()
                            {
                                new PeriodType
                                {
                                    StartDate = "2011-10-03",
                                    StartTime = "09:30:10+01:00",
                                    EndDate = "2011-10-03",
                                    EndTime = "12:30:10+01:00"
                                }
                            },
                        },
                        RequestedDeliveryTransportEvent = new TransportEventType
                        {
                            Location = new LocationType
                            {
                                Address = new AddressType
                                {
                                    StreetName = "Grosse strasse 34",
                                    CityName = "Nurnberg",
                                    PostalZone = "28400",
                                    Country = new CountryType
                                    {
                                        IdentificationCode = "DE"
                                    }
                                }
                            },
                            Period = new List<PeriodType>()
                            {
                                new PeriodType
                                {
                                    StartDate = "2011-10-06",
                                    StartTime = "12:30:10+01:00",
                                    EndDate = "2011-10-06",
                                    EndTime = "15:30:10+01:00"
                                }
                            },
                        },
                        ConsigneeParty = new PartyType
                        {
                            PartyIdentification = new List<PartyIdentificationType>()
                            {
                                new PartyIdentificationType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyName = "GS1",
                                        schemeName = "GLN",
                                        Value = "4058673827123"
                                    }
                                }
                            },
                            PartyName = new List<PartyNameType>()
                            {
                                new PartyNameType
                                {
                                    Name = "Consignee"
                                }
                            },
                            Contact = new ContactType
                            {
                                Name = "SomeName",
                                Telephone = "+4987878763",
                                ElectronicMail = "SomeName@consignee.de"
                            }
                        },
                        ConsignorParty = new PartyType
                        {
                            PartyIdentification = new List<PartyIdentificationType>()
                            {
                                new PartyIdentificationType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyName = "GS1",
                                        schemeName = "GLN",
                                        Value = "4058673827000"
                                    }
                                }
                            },
                            PartyName = new List<PartyNameType>()
                            {
                                new PartyNameType
                                {
                                    Name = "Consignor"
                                }
                            },
                            PostalAddress = new AddressType
                            {
                                ID = new IdentifierType
                                {
                                    schemeAgencyName = "GS1",
                                    schemeName = "GLN",
                                    Value = "4058673827000"
                                }
                            },
                            Contact = new ContactType
                            {
                                Name = "SomeName",
                                Telephone = "+8676576456",
                                ElectronicMail = "SomeName@consignor.cn"
                            }
                        },
                        OriginalDepartureCountry = new CountryType
                        {
                            IdentificationCode = "CN"
                        },
                        FinalDestinationCountry = new CountryType
                        {
                            IdentificationCode = "DE"
                        },
                        TransportHandlingUnit = new List<TransportHandlingUnitType>()
                        {
                            new TransportHandlingUnitType
                            {
                                ID = "CON_THU_1",
                                TransportHandlingUnitTypeCode = "4",
                                HazardousRiskIndicator = false,
                                TotalGoodsItemQuantity = 500M,
                                TotalPackageQuantity = 10M,
                                ShippingMarks = new List<TextType>()
                                {
                                    new TextType
                                    {
                                        Value = "General Cargo"
                                    }
                                },
                                TransportEquipment = new List<TransportEquipmentType>()
                                {
                                    new TransportEquipmentType
                                    {
                                        ID = "CON_TE_1",
                                        TransportEquipmentTypeCode = "CN",
                                        FullnessIndicationCode = "1",
                                        ReturnabilityIndicator = true,
                                        RefrigeratedIndicator = false,
                                        Description = new List<TextType>()
                                        {
                                            new TextType
                                            {
                                                Value = "SomeDescription"
                                            }
                                        },
                                        GrossWeightMeasure = new MeasureType
                                        {
                                            unitCode = "KGM",
                                            Value = 25000M
                                        },
                                        GrossVolumeMeasure = new MeasureType
                                        {
                                            unitCode = "MTQ",
                                            Value = 39M
                                        },
                                        PowerIndicator = false,
                                        MeasurementDimension = new List<DimensionType>()
                                        {
                                            new DimensionType
                                            {
                                                AttributeID = "Length",
                                                Measure = new MeasureType
                                                {
                                                    unitCode = "MTR",
                                                    Value = 6.1M
                                                }
                                            },
                                            new DimensionType
                                            {
                                                AttributeID = "Height",
                                                Measure = new MeasureType
                                                {
                                                    unitCode = "MTR",
                                                    Value = 2.6M
                                                }
                                            },
                                            new DimensionType
                                            {
                                                AttributeID = "Width",
                                                Measure = new MeasureType
                                                {
                                                    unitCode = "MTR",
                                                    Value = 2.44M
                                                }
                                            }
                                        },
                                        Package = new List<PackageType>()
                                        {
                                            new PackageType
                                            {
                                                ID = "CON_P_1",
                                                Quantity = 10M,
                                                PackagingTypeCode = "PL",
                                                GoodsItem = new List<GoodsItemType>()
                                                {
                                                    new GoodsItemType
                                                    {
                                                        Item = new List<ItemType>()
                                                        {
                                                            new ItemType
                                                            {
                                                                CommodityClassification = new List<CommodityClassificationType>()
                                                                {
                                                                    new CommodityClassificationType
                                                                    {
                                                                        CargoTypeCode = "12"
                                                                    }
                                                                },
                                                            }
                                                        },
                                                    }
                                                },
                                            }
                                        },
                                    }
                                },
                            },
                            new TransportHandlingUnitType
                            {
                                ID = "CON_THU_2",
                                TransportHandlingUnitTypeCode = "4",
                                HazardousRiskIndicator = false,
                                TotalGoodsItemQuantity = 500M,
                                TotalPackageQuantity = 10M,
                                ShippingMarks = new List<TextType>()
                                {
                                    new TextType
                                    {
                                        Value = "General Cargo"
                                    }
                                },
                                TransportEquipment = new List<TransportEquipmentType>()
                                {
                                    new TransportEquipmentType
                                    {
                                        ID = "CON_TE_2",
                                        TransportEquipmentTypeCode = "CN",
                                        FullnessIndicationCode = "1",
                                        ReturnabilityIndicator = true,
                                        RefrigeratedIndicator = false,
                                        Description = new List<TextType>()
                                        {
                                            new TextType
                                            {
                                                Value = "SomeDescription"
                                            }
                                        },
                                        GrossWeightMeasure = new MeasureType
                                        {
                                            unitCode = "KGM",
                                            Value = 25000M
                                        },
                                        GrossVolumeMeasure = new MeasureType
                                        {
                                            unitCode = "MTQ",
                                            Value = 39M
                                        },
                                        PowerIndicator = false,
                                        MeasurementDimension = new List<DimensionType>()
                                        {
                                            new DimensionType
                                            {
                                                AttributeID = "Length",
                                                Measure = new MeasureType
                                                {
                                                    unitCode = "MTR",
                                                    Value = 6.1M
                                                }
                                            },
                                            new DimensionType
                                            {
                                                AttributeID = "Height",
                                                Measure = new MeasureType
                                                {
                                                    unitCode = "MTR",
                                                    Value = 2.6M
                                                }
                                            },
                                            new DimensionType
                                            {
                                                AttributeID = "Width",
                                                Measure = new MeasureType
                                                {
                                                    unitCode = "MTR",
                                                    Value = 2.44M
                                                }
                                            }
                                        },
                                        Package = new List<PackageType>()
                                        {
                                            new PackageType
                                            {
                                                ID = "CON_P_2",
                                                Quantity = 10M,
                                                PackagingTypeCode = "PL",
                                                GoodsItem = new List<GoodsItemType>()
                                                {
                                                    new GoodsItemType
                                                    {
                                                        Item = new List<ItemType>()
                                                        {
                                                            new ItemType
                                                            {
                                                                CommodityClassification = new List<CommodityClassificationType>()
                                                                {
                                                                    new CommodityClassificationType
                                                                    {
                                                                        CargoTypeCode = "12"
                                                                    }
                                                                },
                                                            }
                                                        },
                                                    }
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        },
                    }
                },
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
