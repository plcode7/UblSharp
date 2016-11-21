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
    internal class UBLRequestForQuotation21Example
    {
        public static RequestForQuotationType Create()
        {
            var doc = new RequestForQuotationType
            {
                UBLVersionID = "2.1",
                CustomizationID = "OIOUBL-2.1",
                ProfileID = new IdentifierType
                {
                    schemeAgencyID = "320",
                    schemeID = "urn:oioubl:id:profileid-1.2",
                    Value = "Procurement-QuoSim-1.0"
                },
                ID = "G867B",
                CopyIndicator = false,
                UUID = "93T5G3G5-HYA3-7267-BVG3-GS46SW44WG53",
                IssueDate = "2008-04-19",
                IssueTime = "11:32:26.0Z",
                SubmissionDueDate = "2008-04-24",
                Note = new List<TextType>()
                {
                    new TextType
                    {
                        Value = "Bestilling af computere"
                    }
                },
                PricingCurrencyCode = "DKK",
                OriginatorCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeAgencyID = "9",
                            schemeID = "GLN",
                            Value = "5798000416604"
                        },
                        PartyIdentification = new List<PartyIdentificationType>()
                        {
                            new PartyIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeAgencyID = "9",
                                    schemeID = "GLN",
                                    Value = "5798000416604"
                                }
                            }
                        },
                        PartyName = new List<PartyNameType>()
                        {
                            new PartyNameType
                            {
                                Name = "Gentofte Kommune"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            AddressFormatCode = new CodeType
                            {
                                listAgencyID = "320",
                                listID = "urn:oioubl:codelist:addressformatcode-1.1",
                                Value = "StructuredDK"
                            },
                            StreetName = "Bernstorffsvej",
                            BuildingNumber = "161",
                            CityName = "Charlottenlund",
                            PostalZone = "2920",
                            Country = new CountryType
                            {
                                IdentificationCode = "DK"
                            }
                        },
                        PartyTaxScheme = new List<PartyTaxSchemeType>()
                        {
                            new PartyTaxSchemeType
                            {
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "DK:SE",
                                    Value = "DK12345678"
                                },
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyID = "320",
                                        schemeID = "urn:oioubl:id:taxschemeid-1.1",
                                        Value = "63"
                                    },
                                    Name = "Moms"
                                }
                            }
                        },
                        PartyLegalEntity = new List<PartyLegalEntityType>()
                        {
                            new PartyLegalEntityType
                            {
                                RegistrationName = "Gentofte Kommune",
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "DK:CVR",
                                    Value = "DK12345678"
                                }
                            }
                        },
                        Contact = new ContactType
                        {
                            ID = "12345678",
                            Name = "Sille Schyberg"
                        }
                    }
                },
                SellerSupplierParty = new SupplierPartyType
                {
                    CustomerAssignedAccountID = "LEV00123",
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeID = "DK:CVR",
                            Value = "DK18296799"
                        },
                        PartyIdentification = new List<PartyIdentificationType>()
                        {
                            new PartyIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeID = "DK:CVR",
                                    Value = "DK18296799"
                                }
                            }
                        },
                        PartyName = new List<PartyNameType>()
                        {
                            new PartyNameType
                            {
                                Name = "Delcomputer A/S"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            AddressFormatCode = new CodeType
                            {
                                listAgencyID = "320",
                                listID = "urn:oioubl:codelist:addressformatcode-1.1",
                                Value = "StructuredDK"
                            },
                            StreetName = "Arne Jacobsens Allé",
                            BuildingNumber = "15",
                            CityName = "København S",
                            PostalZone = "2300",
                            Country = new CountryType
                            {
                                IdentificationCode = "DK"
                            }
                        },
                        PartyTaxScheme = new List<PartyTaxSchemeType>()
                        {
                            new PartyTaxSchemeType
                            {
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "DK:SE",
                                    Value = "DK18296799"
                                },
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyID = "320",
                                        schemeID = "urn:oioubl:id:taxschemeid-1.1",
                                        Value = "63"
                                    },
                                    Name = "Moms"
                                }
                            }
                        },
                        PartyLegalEntity = new List<PartyLegalEntityType>()
                        {
                            new PartyLegalEntityType
                            {
                                RegistrationName = "Delcomputer A/S",
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "DK:CVR",
                                    Value = "DK18296799"
                                }
                            }
                        },
                    }
                },
                Delivery = new List<DeliveryType>()
                {
                    new DeliveryType
                    {
                        DeliveryAddress = new AddressType
                        {
                            AddressFormatCode = new CodeType
                            {
                                listAgencyID = "320",
                                listID = "urn:oioubl:codelist:addressformatcode-1.1",
                                Value = "StructuredDK"
                            },
                            StreetName = "Bernstorffsvej",
                            BuildingNumber = "161",
                            CityName = "Charlottenlund",
                            PostalZone = "2920",
                            AddressLine = new List<AddressLineType>()
                            {
                                new AddressLineType
                                {
                                    Line = "1. sal"
                                },
                                new AddressLineType
                                {
                                    Line = "IT-afdelingen"
                                }
                            },
                            Country = new CountryType
                            {
                                IdentificationCode = "DK"
                            }
                        },
                        RequestedDeliveryPeriod = new PeriodType
                        {
                            StartDate = "2008-05-06",
                            StartTime = "09:30:47.0Z",
                            EndDate = "2008-05-10",
                            EndTime = "09:30:47.0Z"
                        }
                    }
                },
                DeliveryTerms = new List<DeliveryTermsType>()
                {
                    new DeliveryTermsType
                    {
                        SpecialTerms = new List<TextType>()
                        {
                            new TextType
                            {
                                Value = "1% reduktion i kontraktsummen pr. dags forsinkelse jf. SKI kontrakt"
                            }
                        },
                    }
                },
                Contract = new List<ContractType>()
                {
                    new ContractType
                    {
                        ContractDocumentReference = new List<DocumentReferenceType>()
                        {
                            new DocumentReferenceType
                            {
                                ID = "SKI123456",
                                IssueDate = "2006-01-01"
                            }
                        },
                    }
                },
                RequestForQuotationLine = new List<RequestForQuotationLineType>()
                {
                    new RequestForQuotationLineType
                    {
                        ID = "1",
                        Note = new List<TextType>()
                        {
                            new TextType
                            {
                                Value = "Computer"
                            }
                        },
                        LineItem = new LineItemType
                        {
                            ID = "DELL1052665",
                            Quantity = new QuantityType
                            {
                                unitCode = "NIU",
                                Value = 35M
                            },
                            Item = new ItemType
                            {
                                Description = new List<TextType>()
                                {
                                    new TextType
                                    {
                                        Value = "Stationær computer"
                                    }
                                },
                                Name = "Dell PrecisionTM  T3400"
                            }
                        }
                    },
                    new RequestForQuotationLineType
                    {
                        ID = "2",
                        Note = new List<TextType>()
                        {
                            new TextType
                            {
                                Value = "Skærm"
                            }
                        },
                        LineItem = new LineItemType
                        {
                            ID = "DELL2363463",
                            Quantity = new QuantityType
                            {
                                unitCode = "NIU",
                                Value = 35M
                            },
                            Item = new ItemType
                            {
                                Description = new List<TextType>()
                                {
                                    new TextType
                                    {
                                        Value = "Fladskærm"
                                    }
                                },
                                Name = "FP/BL 1908WFP"
                            }
                        }
                    },
                    new RequestForQuotationLineType
                    {
                        ID = "3",
                        Note = new List<TextType>()
                        {
                            new TextType
                            {
                                Value = "Mus"
                            }
                        },
                        LineItem = new LineItemType
                        {
                            ID = "DELL2367452",
                            Quantity = new QuantityType
                            {
                                unitCode = "NIU",
                                Value = 35M
                            },
                            Item = new ItemType
                            {
                                Description = new List<TextType>()
                                {
                                    new TextType
                                    {
                                        Value = "Mus"
                                    }
                                },
                                Name = "Dell Quietkey USB-tastatur, sort - Dansk (QWERTY)"
                            }
                        }
                    },
                    new RequestForQuotationLineType
                    {
                        ID = "4",
                        Note = new List<TextType>()
                        {
                            new TextType
                            {
                                Value = "Tastatur"
                            }
                        },
                        LineItem = new LineItemType
                        {
                            ID = "DELL8436783",
                            Quantity = new QuantityType
                            {
                                unitCode = "NIU",
                                Value = 35M
                            },
                            Item = new ItemType
                            {
                                Description = new List<TextType>()
                                {
                                    new TextType
                                    {
                                        Value = "Tastatur"
                                    }
                                },
                                Name = "Dell Quietkey USB-tastatur, sort - Dansk (QWERTY)"
                            }
                        }
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
