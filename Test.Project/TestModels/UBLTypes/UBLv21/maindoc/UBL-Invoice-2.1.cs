namespace EFatura.Core.UBLTypes.UBLv21
{
    using Cac;
    using Udt;
    
    
    /// <summary>
    /// ComponentType: ABIE
    /// <para>DictionaryEntryName: Invoice. Details</para>
    /// <para>Definition: A document used to request payment.</para>
    /// <para>ObjectClass: Invoice</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("Invoice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("Invoice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", IsNullable=false)]
#endif
    public partial class InvoiceType : UblBaseDocumentType
    {
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Copy_ Indicator. Indicator</para>
        /// <para>Definition: Indicates whether this document is a copy (true) or not (false).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Copy</para>
        /// <para>PropertyTerm: Indicator</para>
        /// <para>RepresentationTerm: Indicator</para>
        /// <para>DataType: Indicator. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CopyIndicator { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. UUID. Identifier</para>
        /// <para>Definition: A universally unique identifier for an instance of this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: UUID</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Issue Date. Date</para>
        /// <para>Definition: The date, assigned by the sender, on which this document was issued.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Issue Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// <para>AlternativeBusinessTerms: Invoice Date</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Issue Time. Time</para>
        /// <para>Definition: The time, assigned by the sender, at which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Issue Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Due Date. Date</para>
        /// <para>Definition: The date on which Invoice is due.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Due Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType DueDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Invoice Type Code. Code</para>
        /// <para>Definition: A code signifying the type of the Invoice.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Invoice Type Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataType: Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType InvoiceTypeCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Note. Text</para>
        /// <para>Definition: Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Note</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Tax Point Date. Date</para>
        /// <para>Definition: The date of the Invoice, used to indicate the point at which tax becomes applicable.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Tax Point Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType TaxPointDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Document_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the default currency for this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Document</para>
        /// <para>PropertyTerm: Currency Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataTypeQualifier: Currency</para>
        /// <para>DataType: Currency_ Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DocumentCurrencyCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Tax_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the currency used for tax amounts in the Invoice.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Tax</para>
        /// <para>PropertyTerm: Currency Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataTypeQualifier: Currency</para>
        /// <para>DataType: Currency_ Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TaxCurrencyCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Pricing_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the currency used for prices in the Invoice.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Pricing</para>
        /// <para>PropertyTerm: Currency Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataTypeQualifier: Currency</para>
        /// <para>DataType: Currency_ Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType PricingCurrencyCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Payment_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the currency used for payment in the Invoice.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Payment</para>
        /// <para>PropertyTerm: Currency Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataTypeQualifier: Currency</para>
        /// <para>DataType: Currency_ Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType PaymentCurrencyCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Payment Alternative_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the alternative currency used for payment in the Invoice.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Payment Alternative</para>
        /// <para>PropertyTerm: Currency Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataTypeQualifier: Currency</para>
        /// <para>DataType: Currency_ Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType PaymentAlternativeCurrencyCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Accounting Cost Code. Code</para>
        /// <para>Definition: The buyer's accounting code, applied to the Invoice as a whole.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Accounting Cost Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataType: Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType AccountingCostCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Accounting Cost. Text</para>
        /// <para>Definition: The buyer's accounting code, applied to the Invoice as a whole, expressed as text.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Accounting Cost</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType AccountingCost { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Line Count. Numeric</para>
        /// <para>Definition: The number of lines in the document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Line Count</para>
        /// <para>RepresentationTerm: Numeric</para>
        /// <para>DataType: Numeric. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType LineCountNumeric { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Invoice. Buyer_ Reference. Text</para>
        /// <para>Definition: A reference provided by the buyer used for internal routing of the document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Buyer</para>
        /// <para>PropertyTerm: Reference</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType BuyerReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Invoice_ Period. Period</para>
        /// <para>Definition: A period to which the Invoice applies.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Invoice</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType[] InvoicePeriod { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Order Reference</para>
        /// <para>Definition: A reference to the Order with which this Invoice is associated.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Order Reference</para>
        /// <para>AssociatedObjectClass: Order Reference</para>
        /// <para>RepresentationTerm: Order Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public OrderReferenceType OrderReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Billing Reference</para>
        /// <para>Definition: A reference to a billing document associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Billing Reference</para>
        /// <para>AssociatedObjectClass: Billing Reference</para>
        /// <para>RepresentationTerm: Billing Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public BillingReferenceType[] BillingReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Despatch_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to a Despatch Advice associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Despatch</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DespatchDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] DespatchDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Receipt_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to a Receipt Advice associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Receipt</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ReceiptDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] ReceiptDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Statement_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to a Statement associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Statement</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("StatementDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] StatementDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Originator_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to an originator document associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Originator</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OriginatorDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] OriginatorDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Contract_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to a contract associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Contract</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ContractDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] ContractDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Additional_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to an additional document associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Additional</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] AdditionalDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Project Reference</para>
        /// <para>Definition: Information about a project.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Project Reference</para>
        /// <para>AssociatedObjectClass: Project Reference</para>
        /// <para>RepresentationTerm: Project Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ProjectReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ProjectReferenceType[] ProjectReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Signature</para>
        /// <para>Definition: A signature applied to this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Signature</para>
        /// <para>AssociatedObjectClass: Signature</para>
        /// <para>RepresentationTerm: Signature</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature { get; set; }

        /// <summary>
        /// ComponentType: ASBIE
        /// Bu elemanda faturay� d�zenleyen taraf�n bilgileri yer alacakt�r.
        /// <para>DictionaryEntryName: Invoice. Accounting_ Supplier Party. Supplier Party</para>
        /// <para>Definition: The accounting supplier party.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Accounting</para>
        /// <para>PropertyTerm: Supplier Party</para>
        /// <para>AssociatedObjectClass: Supplier Party</para>
        /// <para>RepresentationTerm: Supplier Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType AccountingSupplierParty { get; set; }

        /// <summary>
        /// ComponentType: ASBIE
        /// Bu elemanda faturay� alan taraf�n bilgileri yer alacakt�r.
        /// <para>DictionaryEntryName: Invoice. Accounting_ Customer Party. Customer Party</para>
        /// <para>Definition: The accounting customer party.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Accounting</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType AccountingCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Payee_ Party. Party</para>
        /// <para>Definition: The payee.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Payee</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType PayeeParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Buyer_ Customer Party. Customer Party</para>
        /// <para>Definition: The buyer.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Buyer</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType BuyerCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Seller_ Supplier Party. Supplier Party</para>
        /// <para>Definition: The seller.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Seller</para>
        /// <para>PropertyTerm: Supplier Party</para>
        /// <para>AssociatedObjectClass: Supplier Party</para>
        /// <para>RepresentationTerm: Supplier Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType SellerSupplierParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Tax Representative_ Party. Party</para>
        /// <para>Definition: The tax representative.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Tax Representative</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType TaxRepresentativeParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Delivery</para>
        /// <para>Definition: A delivery associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Delivery</para>
        /// <para>AssociatedObjectClass: Delivery</para>
        /// <para>RepresentationTerm: Delivery</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DeliveryType[] Delivery { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Delivery Terms</para>
        /// <para>Definition: A set of delivery terms associated with this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Delivery Terms</para>
        /// <para>AssociatedObjectClass: Delivery Terms</para>
        /// <para>RepresentationTerm: Delivery Terms</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DeliveryTermsType DeliveryTerms { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Payment Means</para>
        /// <para>Definition: Expected means of payment.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Payment Means</para>
        /// <para>AssociatedObjectClass: Payment Means</para>
        /// <para>RepresentationTerm: Payment Means</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentMeansType[] PaymentMeans { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Payment Terms</para>
        /// <para>Definition: A set of payment terms associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Payment Terms</para>
        /// <para>AssociatedObjectClass: Payment Terms</para>
        /// <para>RepresentationTerm: Payment Terms</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentTermsType[] PaymentTerms { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Prepaid_ Payment. Payment</para>
        /// <para>Definition: A prepaid payment.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Prepaid</para>
        /// <para>PropertyTerm: Payment</para>
        /// <para>AssociatedObjectClass: Payment</para>
        /// <para>RepresentationTerm: Payment</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("PrepaidPayment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentType[] PrepaidPayment { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Allowance Charge</para>
        /// <para>Definition: A discount or charge that applies to a price component.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Allowance Charge</para>
        /// <para>AssociatedObjectClass: Allowance Charge</para>
        /// <para>RepresentationTerm: Allowance Charge</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AllowanceChargeType[] AllowanceCharge { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Tax_ Exchange Rate. Exchange Rate</para>
        /// <para>Definition: The exchange rate between the document currency and the tax currency.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Tax</para>
        /// <para>PropertyTerm: Exchange Rate</para>
        /// <para>AssociatedObjectClass: Exchange Rate</para>
        /// <para>RepresentationTerm: Exchange Rate</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType TaxExchangeRate { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Pricing_ Exchange Rate. Exchange Rate</para>
        /// <para>Definition: The exchange rate between the document currency and the pricing currency.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Pricing</para>
        /// <para>PropertyTerm: Exchange Rate</para>
        /// <para>AssociatedObjectClass: Exchange Rate</para>
        /// <para>RepresentationTerm: Exchange Rate</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PricingExchangeRate { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Payment_ Exchange Rate. Exchange Rate</para>
        /// <para>Definition: The exchange rate between the document currency and the payment currency.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Payment</para>
        /// <para>PropertyTerm: Exchange Rate</para>
        /// <para>AssociatedObjectClass: Exchange Rate</para>
        /// <para>RepresentationTerm: Exchange Rate</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentExchangeRate { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Payment Alternative_ Exchange Rate. Exchange Rate</para>
        /// <para>Definition: The exchange rate between the document currency and the payment alternative currency.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Payment Alternative</para>
        /// <para>PropertyTerm: Exchange Rate</para>
        /// <para>AssociatedObjectClass: Exchange Rate</para>
        /// <para>RepresentationTerm: Exchange Rate</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentAlternativeExchangeRate { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Tax Total</para>
        /// <para>Definition: The total amount of a specific type of tax.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Tax Total</para>
        /// <para>AssociatedObjectClass: Tax Total</para>
        /// <para>RepresentationTerm: Tax Total</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotalType[] TaxTotal { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Withholding_ Tax Total. Tax Total</para>
        /// <para>Definition: The total withholding tax.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Withholding</para>
        /// <para>PropertyTerm: Tax Total</para>
        /// <para>AssociatedObjectClass: Tax Total</para>
        /// <para>RepresentationTerm: Tax Total</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("WithholdingTaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotalType[] WithholdingTaxTotal { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Legal_ Monetary Total. Monetary Total</para>
        /// <para>Definition: The total amount payable on the Invoice, including Allowances, Charges, and Taxes.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTermQualifier: Legal</para>
        /// <para>PropertyTerm: Monetary Total</para>
        /// <para>AssociatedObjectClass: Monetary Total</para>
        /// <para>RepresentationTerm: Monetary Total</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public MonetaryTotalType LegalMonetaryTotal { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Invoice. Invoice Line</para>
        /// <para>Definition: A line describing an invoice item.</para>
        /// <para>Cardinality: 1..n</para>
        /// <para>ObjectClass: Invoice</para>
        /// <para>PropertyTerm: Invoice Line</para>
        /// <para>AssociatedObjectClass: Invoice Line</para>
        /// <para>RepresentationTerm: Invoice Line</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public InvoiceLineType[] InvoiceLine { get; set; }
    }
}
