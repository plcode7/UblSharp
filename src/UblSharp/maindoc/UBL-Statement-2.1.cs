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
    /// A document used to report the status of orders, billing, and payment. This document is a statement of account, not a summary invoice.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Statement. Details
    /// <para />ObjectClass: Statement
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Statement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Statement-2")]
    [System.Xml.Serialization.XmlRootAttribute("Statement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Statement-2", IsNullable=false)]
    public partial class StatementType : BaseDocument, IBaseDocument
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
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
        public TimeType @__IssueTime;
        
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute("DocumentCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public CodeType @__DocumentCurrencyCode;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TotalDebitAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
        public AmountType @__TotalDebitAmount;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TotalCreditAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
        public AmountType @__TotalCreditAmount;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TotalBalanceAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
        public AmountType @__TotalBalanceAmount;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("LineCountNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=15)]
        public NumericType @__LineCountNumeric;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("StatementTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=16)]
        public CodeType @__StatementTypeCode;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("StatementPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=17)]
        public PeriodType @__StatementPeriod;
        
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=18)]
        public DocumentReferenceType[] @__AdditionalDocumentReference
        {
            get
            {
                return AdditionalDocumentReference?.ToArray();
            }
            set
            {
                AdditionalDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=19)]
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
        [System.Xml.Serialization.XmlElementAttribute("AccountingSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=20)]
        public SupplierPartyType @__AccountingSupplierParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AccountingCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=21)]
        public CustomerPartyType @__AccountingCustomerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("BuyerCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=22)]
        public CustomerPartyType @__BuyerCustomerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SellerSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=23)]
        public SupplierPartyType @__SellerSupplierParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OriginatorCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=24)]
        public CustomerPartyType @__OriginatorCustomerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("PayeeParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=25)]
        public PartyType @__PayeeParty;
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=26)]
        public PaymentMeansType[] @__PaymentMeans
        {
            get
            {
                return PaymentMeans?.ToArray();
            }
            set
            {
                PaymentMeans = value == null ? null : new System.Collections.Generic.List<PaymentMeansType>(value);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=27)]
        public PaymentTermsType[] @__PaymentTerms
        {
            get
            {
                return PaymentTerms?.ToArray();
            }
            set
            {
                PaymentTerms = value == null ? null : new System.Collections.Generic.List<PaymentTermsType>(value);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=28)]
        public AllowanceChargeType[] @__AllowanceCharge
        {
            get
            {
                return AllowanceCharge?.ToArray();
            }
            set
            {
                AllowanceCharge = value == null ? null : new System.Collections.Generic.List<AllowanceChargeType>(value);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=29)]
        public TaxTotalType[] @__TaxTotal
        {
            get
            {
                return TaxTotal?.ToArray();
            }
            set
            {
                TaxTotal = value == null ? null : new System.Collections.Generic.List<TaxTotalType>(value);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("StatementLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=30)]
        public StatementLineType[] @__StatementLine
        {
            get
            {
                return StatementLine?.ToArray();
            }
            set
            {
                StatementLine = value == null ? null : new System.Collections.Generic.List<StatementLineType>(value);
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
        /// <para />DictionaryEntryName: Statement. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Statement
        /// <para />PropertyTerm: Note
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Note { get; set; }

        
        /// <summary>
        /// A reference to an additional document associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Statement. Additional_ Document Reference. Document Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Statement
        /// <para />PropertyTermQualifier: Additional
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<DocumentReferenceType> AdditionalDocumentReference { get; set; }

        
        /// <summary>
        /// A signature applied to this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Statement. Signature
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Statement
        /// <para />PropertyTerm: Signature
        /// <para />AssociatedObjectClass: Signature
        /// <para />RepresentationTerm: Signature
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<SignatureType> IBaseDocument.Signature { get; set; }

        
        /// <summary>
        /// Expected means of payment.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Statement. Payment Means
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Statement
        /// <para />PropertyTerm: Payment Means
        /// <para />AssociatedObjectClass: Payment Means
        /// <para />RepresentationTerm: Payment Means
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<PaymentMeansType> PaymentMeans { get; set; }

        
        /// <summary>
        /// A set of payment terms associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Statement. Payment Terms
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Statement
        /// <para />PropertyTerm: Payment Terms
        /// <para />AssociatedObjectClass: Payment Terms
        /// <para />RepresentationTerm: Payment Terms
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<PaymentTermsType> PaymentTerms { get; set; }

        
        /// <summary>
        /// A discount or charge that applies to a price component.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Statement. Allowance Charge
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Statement
        /// <para />PropertyTerm: Allowance Charge
        /// <para />AssociatedObjectClass: Allowance Charge
        /// <para />RepresentationTerm: Allowance Charge
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<AllowanceChargeType> AllowanceCharge { get; set; }

        
        /// <summary>
        /// The total amount of a specific type of tax.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Statement. Tax Total
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Statement
        /// <para />PropertyTerm: Tax Total
        /// <para />AssociatedObjectClass: Tax Total
        /// <para />RepresentationTerm: Tax Total
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TaxTotalType> TaxTotal { get; set; }

        
        /// <summary>
        /// A Statement Line.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Statement. Statement Line
        /// <para />Cardinality: 1..n
        /// <para />ObjectClass: Statement
        /// <para />PropertyTerm: Statement Line
        /// <para />AssociatedObjectClass: Statement Line
        /// <para />RepresentationTerm: Statement Line
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<StatementLineType> StatementLine { get; set; }

        
        /// <summary>
        /// Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Statement. UBL Version Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTerm: UBL Version Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>2.0.5</example>
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
        /// <para />DictionaryEntryName: Statement. Customization Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTerm: Customization Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>NES</example>
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
        /// <para />DictionaryEntryName: Statement. Profile Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTerm: Profile Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>BasicProcurementProcess</example>
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
        /// <para />DictionaryEntryName: Statement. Profile Execution Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTerm: Profile Execution Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>BPP-1001</example>
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
        /// <para />DictionaryEntryName: Statement. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Statement
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
        /// <para />DictionaryEntryName: Statement. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
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
        /// <para />DictionaryEntryName: Statement. UUID. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
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
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Statement. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Statement
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
        /// <para />DictionaryEntryName: Statement. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
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
        /// The default currency for the Statement.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Statement. Document_ Currency Code. Code
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTermQualifier: Document
        /// <para />PropertyTerm: Currency Code
        /// <para />RepresentationTerm: Code
        /// <para />DataTypeQualifier: Currency
        /// <para />DataType: Currency_ Code. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType DocumentCurrencyCode
        {
            get
            {
                if (__DocumentCurrencyCode == null) { __DocumentCurrencyCode = new CodeType(); }
                return __DocumentCurrencyCode;
            }
            set
            {
                __DocumentCurrencyCode = value;
            }
        }

        
        /// <summary>
        /// The total of all debit amounts for the Statement.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Statement. Total_ Debit Amount. Amount
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTermQualifier: Total
        /// <para />PropertyTerm: Debit Amount
        /// <para />RepresentationTerm: Amount
        /// <para />DataType: Amount. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public AmountType TotalDebitAmount
        {
            get
            {
                if (__TotalDebitAmount == null) { __TotalDebitAmount = new AmountType(); }
                return __TotalDebitAmount;
            }
            set
            {
                __TotalDebitAmount = value;
            }
        }

        
        /// <summary>
        /// The total of all credit amounts for the Statement.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Statement. Total_ Credit Amount. Amount
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTermQualifier: Total
        /// <para />PropertyTerm: Credit Amount
        /// <para />RepresentationTerm: Amount
        /// <para />DataType: Amount. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public AmountType TotalCreditAmount
        {
            get
            {
                if (__TotalCreditAmount == null) { __TotalCreditAmount = new AmountType(); }
                return __TotalCreditAmount;
            }
            set
            {
                __TotalCreditAmount = value;
            }
        }

        
        /// <summary>
        /// The total amount for the Statement.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Statement. Total_ Balance Amount. Amount
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTermQualifier: Total
        /// <para />PropertyTerm: Balance Amount
        /// <para />RepresentationTerm: Amount
        /// <para />DataType: Amount. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public AmountType TotalBalanceAmount
        {
            get
            {
                if (__TotalBalanceAmount == null) { __TotalBalanceAmount = new AmountType(); }
                return __TotalBalanceAmount;
            }
            set
            {
                __TotalBalanceAmount = value;
            }
        }

        
        /// <summary>
        /// The number of Statement Lines in the Statement.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Statement. Line Count. Numeric
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTerm: Line Count
        /// <para />RepresentationTerm: Numeric
        /// <para />DataType: Numeric. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public NumericType LineCountNumeric
        {
            get
            {
                if (__LineCountNumeric == null) { __LineCountNumeric = new NumericType(); }
                return __LineCountNumeric;
            }
            set
            {
                __LineCountNumeric = value;
            }
        }

        
        /// <summary>
        /// A code signifying the type of the Statement.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Statement. Statement Type Code. Code
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTerm: Statement Type Code
        /// <para />RepresentationTerm: Code
        /// <para />DataType: Code. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType StatementTypeCode
        {
            get
            {
                if (__StatementTypeCode == null) { __StatementTypeCode = new CodeType(); }
                return __StatementTypeCode;
            }
            set
            {
                __StatementTypeCode = value;
            }
        }

        
        /// <summary>
        /// A period to which the Statement applies.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Statement. Statement_ Period. Period
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTermQualifier: Statement
        /// <para />PropertyTerm: Period
        /// <para />AssociatedObjectClass: Period
        /// <para />RepresentationTerm: Period
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PeriodType StatementPeriod
        {
            get
            {
                if (__StatementPeriod == null) { __StatementPeriod = new PeriodType(); }
                return __StatementPeriod;
            }
            set
            {
                __StatementPeriod = value;
            }
        }

        
        /// <summary>
        /// The accounting supplier party.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Statement. Accounting_ Supplier Party. Supplier Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTermQualifier: Accounting
        /// <para />PropertyTerm: Supplier Party
        /// <para />AssociatedObjectClass: Supplier Party
        /// <para />RepresentationTerm: Supplier Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public SupplierPartyType AccountingSupplierParty
        {
            get
            {
                if (__AccountingSupplierParty == null) { __AccountingSupplierParty = new SupplierPartyType(); }
                return __AccountingSupplierParty;
            }
            set
            {
                __AccountingSupplierParty = value;
            }
        }

        
        /// <summary>
        /// The accounting customer party.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Statement. Accounting_ Customer Party. Customer Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTermQualifier: Accounting
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CustomerPartyType AccountingCustomerParty
        {
            get
            {
                if (__AccountingCustomerParty == null) { __AccountingCustomerParty = new CustomerPartyType(); }
                return __AccountingCustomerParty;
            }
            set
            {
                __AccountingCustomerParty = value;
            }
        }

        
        /// <summary>
        /// The buyer.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Statement. Buyer_ Customer Party. Customer Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTermQualifier: Buyer
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                if (__BuyerCustomerParty == null) { __BuyerCustomerParty = new CustomerPartyType(); }
                return __BuyerCustomerParty;
            }
            set
            {
                __BuyerCustomerParty = value;
            }
        }

        
        /// <summary>
        /// The seller.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Statement. Seller_ Supplier Party. Supplier Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTermQualifier: Seller
        /// <para />PropertyTerm: Supplier Party
        /// <para />AssociatedObjectClass: Supplier Party
        /// <para />RepresentationTerm: Supplier Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                if (__SellerSupplierParty == null) { __SellerSupplierParty = new SupplierPartyType(); }
                return __SellerSupplierParty;
            }
            set
            {
                __SellerSupplierParty = value;
            }
        }

        
        /// <summary>
        /// The originator.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Statement. Originator_ Customer Party. Customer Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTermQualifier: Originator
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CustomerPartyType OriginatorCustomerParty
        {
            get
            {
                if (__OriginatorCustomerParty == null) { __OriginatorCustomerParty = new CustomerPartyType(); }
                return __OriginatorCustomerParty;
            }
            set
            {
                __OriginatorCustomerParty = value;
            }
        }

        
        /// <summary>
        /// The payee.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Statement. Payee_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Statement
        /// <para />PropertyTermQualifier: Payee
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType PayeeParty
        {
            get
            {
                if (__PayeeParty == null) { __PayeeParty = new PartyType(); }
                return __PayeeParty;
            }
            set
            {
                __PayeeParty = value;
            }
        }

    }
}
