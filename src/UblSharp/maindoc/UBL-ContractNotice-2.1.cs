// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblSharp
{
    using UnqualifiedDataTypes;
    using CommonAggregateComponents;
    using CommonExtensionComponents;
    
    
    /// <summary>
    /// A document used by a Contracting party to announce a project to buy goods, services, or works.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Contract Notice. Details
    /// <para />ObjectClass: Contract Notice
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ContractNotice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ContractNotice-2")]
    [System.Xml.Serialization.XmlRootAttribute("ContractNotice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ContractNotice-2", IsNullable=false)]
    public partial class ContractNoticeType : BaseDocument, IBaseDocument
    {
        
        [System.Xml.Serialization.XmlArrayAttribute("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable=false)]
        public UBLExtensionType[] @__UBLExtensions
        {
            get
            {
                return UBLExtensions?.ToArray();
            }
            set
            {
                UBLExtensions = value == null ? null : new System.Collections.Generic.List<UBLExtensionType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UBLVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public IdentifierType @__UBLVersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CustomizationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public IdentifierType @__CustomizationID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public IdentifierType @__ProfileID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileExecutionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public IdentifierType @__ProfileExecutionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public IdentifierType @__ID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public IndicatorType @__CopyIndicator;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public IdentifierType @__UUID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ContractFolderID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public IdentifierType @__ContractFolderID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
        public TimeType @__IssueTime;
        
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public TextType[] @__Note
        {
            get
            {
                return Note?.ToArray();
            }
            set
            {
                Note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RequestedPublicationDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
        public DateType @__RequestedPublicationDate;
        
        [System.Xml.Serialization.XmlElementAttribute("RegulatoryDomain", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
        public TextType[] @__RegulatoryDomain
        {
            get
            {
                return RegulatoryDomain?.ToArray();
            }
            set
            {
                RegulatoryDomain = value == null ? null : new System.Collections.Generic.List<TextType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("FrequencyPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=14)]
        public PeriodType @__FrequencyPeriod;
        
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=15)]
        public SignatureType[] @__Signature
        {
            get
            {
                return Signature?.ToArray();
            }
            set
            {
                Signature = value == null ? null : new System.Collections.Generic.List<SignatureType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ContractingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=16)]
        public ContractingPartyType @__ContractingParty;
        
        [System.Xml.Serialization.XmlElementAttribute("OriginatorCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=17)]
        public CustomerPartyType[] @__OriginatorCustomerParty
        {
            get
            {
                return OriginatorCustomerParty?.ToArray();
            }
            set
            {
                OriginatorCustomerParty = value == null ? null : new System.Collections.Generic.List<CustomerPartyType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=18)]
        public PartyType @__ReceiverParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TenderingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=19)]
        public TenderingTermsType @__TenderingTerms;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TenderingProcess", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=20)]
        public TenderingProcessType @__TenderingProcess;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProcurementProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=21)]
        public ProcurementProjectType @__ProcurementProject;
        
        [System.Xml.Serialization.XmlElementAttribute("ProcurementProjectLot", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=22)]
        public ProcurementProjectLotType[] @__ProcurementProjectLot
        {
            get
            {
                return ProcurementProjectLot?.ToArray();
            }
            set
            {
                ProcurementProjectLot = value == null ? null : new System.Collections.Generic.List<ProcurementProjectLotType>(value);
            }
        }
        
        /// <summary>
        /// A container for all extensions present in the document.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<UBLExtensionType> IBaseDocument.UBLExtensions { get; set; }

        
        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Contract Notice. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Note
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Note { get; set; }

        
        /// <summary>
        /// Information about the law that defines the regulatory domain.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Contract Notice. Regulatory Domain. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Regulatory Domain
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> RegulatoryDomain { get; set; }

        
        /// <summary>
        /// A signature applied to this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Contract Notice. Signature
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Signature
        /// <para />AssociatedObjectClass: Signature
        /// <para />RepresentationTerm: Signature
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<SignatureType> IBaseDocument.Signature { get; set; }

        
        /// <summary>
        /// A party who originally requested the tender.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Contract Notice. Originator_ Customer Party. Customer Party
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTermQualifier: Originator
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<CustomerPartyType> OriginatorCustomerParty { get; set; }

        
        /// <summary>
        /// One of the procurement project lots into which this contract can be split.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Contract Notice. Procurement Project Lot
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Procurement Project Lot
        /// <para />AssociatedObjectClass: Procurement Project Lot
        /// <para />RepresentationTerm: Procurement Project Lot
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<ProcurementProjectLotType> ProcurementProjectLot { get; set; }

        
        /// <summary>
        /// Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Contract Notice. UBL Version Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: UBL Version Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UBLVersionID
        {
            get
            {
                if (__UBLVersionID == null) { __UBLVersionID = new IdentifierType(); }
                return __UBLVersionID;
            }
            set
            {
                __UBLVersionID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined customization of UBL for a specific use.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Contract Notice. Customization Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Customization Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.CustomizationID
        {
            get
            {
                if (__CustomizationID == null) { __CustomizationID = new IdentifierType(); }
                return __CustomizationID;
            }
            set
            {
                __CustomizationID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined profile of the customization of UBL being used.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Contract Notice. Profile Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Profile Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileID
        {
            get
            {
                if (__ProfileID == null) { __ProfileID = new IdentifierType(); }
                return __ProfileID;
            }
            set
            {
                __ProfileID = value;
            }
        }

        
        /// <summary>
        /// Identifies an instance of executing a profile, to associate all transactions in a collaboration.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Contract Notice. Profile Execution Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Profile Execution Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileExecutionID
        {
            get
            {
                if (__ProfileExecutionID == null) { __ProfileExecutionID = new IdentifierType(); }
                return __ProfileExecutionID;
            }
            set
            {
                __ProfileExecutionID = value;
            }
        }

        
        /// <summary>
        /// An identifier for this document, assigned by the sender.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Contract Notice. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ID
        {
            get
            {
                if (__ID == null) { __ID = new IdentifierType(); }
                return __ID;
            }
            set
            {
                __ID = value;
            }
        }

        
        /// <summary>
        /// Indicates whether this document is a copy (true) or not (false).
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Contract Notice. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTermQualifier: Copy
        /// <para />PropertyTerm: Indicator
        /// <para />RepresentationTerm: Indicator
        /// <para />DataType: Indicator. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IndicatorType CopyIndicator
        {
            get
            {
                if (__CopyIndicator == null) { __CopyIndicator = new IndicatorType(); }
                return __CopyIndicator;
            }
            set
            {
                __CopyIndicator = value;
            }
        }

        
        /// <summary>
        /// A universally unique identifier for an instance of this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Contract Notice. UUID. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: UUID
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UUID
        {
            get
            {
                if (__UUID == null) { __UUID = new IdentifierType(); }
                return __UUID;
            }
            set
            {
                __UUID = value;
            }
        }

        
        /// <summary>
        /// An identifier, assigned by the sender, for the process file (i.e., record) to which this document belongs.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Contract Notice. Contract Folder Identifier. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Contract Folder Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType ContractFolderID
        {
            get
            {
                if (__ContractFolderID == null) { __ContractFolderID = new IdentifierType(); }
                return __ContractFolderID;
            }
            set
            {
                __ContractFolderID = value;
            }
        }

        
        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Contract Notice. Issue Date. Date
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Issue Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType IssueDate
        {
            get
            {
                if (__IssueDate == null) { __IssueDate = new DateType(); }
                return __IssueDate;
            }
            set
            {
                __IssueDate = value;
            }
        }

        
        /// <summary>
        /// The time, assigned by the sender, at which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Contract Notice. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Issue Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TimeType IssueTime
        {
            get
            {
                if (__IssueTime == null) { __IssueTime = new TimeType(); }
                return __IssueTime;
            }
            set
            {
                __IssueTime = value;
            }
        }

        
        /// <summary>
        /// The requested publication date for this Contract Notice.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Contract Notice. Requested_ Publication Date. Date
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTermQualifier: Requested
        /// <para />PropertyTerm: Publication Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType RequestedPublicationDate
        {
            get
            {
                if (__RequestedPublicationDate == null) { __RequestedPublicationDate = new DateType(); }
                return __RequestedPublicationDate;
            }
            set
            {
                __RequestedPublicationDate = value;
            }
        }

        
        /// <summary>
        /// The estimated frequency of future notices.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Contract Notice. Frequency_ Period. Period
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTermQualifier: Frequency
        /// <para />PropertyTerm: Period
        /// <para />AssociatedObjectClass: Period
        /// <para />RepresentationTerm: Period
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PeriodType FrequencyPeriod
        {
            get
            {
                if (__FrequencyPeriod == null) { __FrequencyPeriod = new PeriodType(); }
                return __FrequencyPeriod;
            }
            set
            {
                __FrequencyPeriod = value;
            }
        }

        
        /// <summary>
        /// The contracting party.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Contract Notice. Contracting Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Contracting Party
        /// <para />AssociatedObjectClass: Contracting Party
        /// <para />RepresentationTerm: Contracting Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ContractingPartyType ContractingParty
        {
            get
            {
                if (__ContractingParty == null) { __ContractingParty = new ContractingPartyType(); }
                return __ContractingParty;
            }
            set
            {
                __ContractingParty = value;
            }
        }

        
        /// <summary>
        /// The party receiving this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Contract Notice. Receiver_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTermQualifier: Receiver
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ReceiverParty
        {
            get
            {
                if (__ReceiverParty == null) { __ReceiverParty = new PartyType(); }
                return __ReceiverParty;
            }
            set
            {
                __ReceiverParty = value;
            }
        }

        
        /// <summary>
        /// The tendering terms associated with this tendering process.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Contract Notice. Tendering Terms
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Tendering Terms
        /// <para />AssociatedObjectClass: Tendering Terms
        /// <para />RepresentationTerm: Tendering Terms
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TenderingTermsType TenderingTerms
        {
            get
            {
                if (__TenderingTerms == null) { __TenderingTerms = new TenderingTermsType(); }
                return __TenderingTerms;
            }
            set
            {
                __TenderingTerms = value;
            }
        }

        
        /// <summary>
        /// A description of the tendering process itself.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Contract Notice. Tendering Process
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Tendering Process
        /// <para />AssociatedObjectClass: Tendering Process
        /// <para />RepresentationTerm: Tendering Process
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TenderingProcessType TenderingProcess
        {
            get
            {
                if (__TenderingProcess == null) { __TenderingProcess = new TenderingProcessType(); }
                return __TenderingProcess;
            }
            set
            {
                __TenderingProcess = value;
            }
        }

        
        /// <summary>
        /// An overall definition of this procurement project.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Contract Notice. Procurement Project
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Contract Notice
        /// <para />PropertyTerm: Procurement Project
        /// <para />AssociatedObjectClass: Procurement Project
        /// <para />RepresentationTerm: Procurement Project
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public ProcurementProjectType ProcurementProject
        {
            get
            {
                if (__ProcurementProject == null) { __ProcurementProject = new ProcurementProjectType(); }
                return __ProcurementProject;
            }
            set
            {
                __ProcurementProject = value;
            }
        }

    }
}
