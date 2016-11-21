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
    /// Base document for other UBL 2.1 maindoc documents.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WaybillType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UtilityStatementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnawardedNotificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransportServiceDescriptionRequestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransportServiceDescriptionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransportProgressStatusRequestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransportProgressStatusType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransportExecutionPlanRequestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransportExecutionPlanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransportationStatusRequestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransportationStatusType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TradeItemLocationProfileType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TenderReceiptType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TendererQualificationResponseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TendererQualificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TenderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StockAvailabilityReportType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SelfBilledInvoiceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SelfBilledCreditNoteType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RetailEventType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestForQuotationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RemittanceAdviceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReminderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReceiptAdviceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuotationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductActivityType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PriorInformationNoticeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PackingListType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderResponseSimpleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderResponseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderChangeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderCancellationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ItemInformationRequestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvoiceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InventoryReportType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InstructionForReturnsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GuaranteeCertificateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GoodsItemItineraryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FulfilmentCancellationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FreightInvoiceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ForwardingInstructionsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ForecastRevisionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ForecastType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExceptionNotificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExceptionCriteriaType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentStatusRequestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentStatusType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DespatchAdviceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DebitNoteType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreditNoteType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContractNoticeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContractAwardNoticeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CertificateOfOriginType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CatalogueRequestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CataloguePricingUpdateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CatalogueItemSpecificationUpdateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CatalogueDeletionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CatalogueType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CallForTendersType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BillOfLadingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AwardedNotificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttachedDocumentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationResponseType))]
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("BaseDocument", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:BaseDocument-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:BaseDocument-2", IsNullable=false)]
    public partial class BaseDocument : IBaseDocument
    {
    }
}
