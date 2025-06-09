namespace ServiceReference
{


       /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
        "")]
    public partial class CRSysSecurity
    {

        private string usernameField;

        private string passwordField;

        private string contextField;

        private RemoteUserType remoteUserField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string Context
        {
            get
            {
                return this.contextField;
            }
            set
            {
                this.contextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public RemoteUserType RemoteUser
        {
            get
            {
                return this.remoteUserField;
            }
            set
            {
                this.remoteUserField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RemoteUserType
    {

        private string nameField;

        private string emailField;

        private string phoneField;

        private string locationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomType
    {

        private RoomTypeRoomType roomType1Field;

        private RoomTypeRoomRate[] roomRatesField;

        private string rPHField;

        private string bestField;

        private RoomTypeStatus statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoomType", Order = 0)]
        public RoomTypeRoomType RoomType1
        {
            get
            {
                return this.roomType1Field;
            }
            set
            {
                this.roomType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomRate", IsNullable = false)]
        public RoomTypeRoomRate[] RoomRates
        {
            get
            {
                return this.roomRatesField;
            }
            set
            {
                this.roomRatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Best
        {
            get
            {
                return this.bestField;
            }
            set
            {
                this.bestField = value;
            }
        }

       
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomTypeRoomType
    {

        private string descriptionField;

        private string[] extraInfoField;

        private string specialField;

        private string specialIdsField;

        private int codeField;

        private string nameField;

        private string supplierRoomCodeField;

        private string productTypeInfo1Field;

        private string productTypeInfo2Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Msg", IsNullable = false)]
        public string[] ExtraInfo
        {
            get
            {
                return this.extraInfoField;
            }
            set
            {
                this.extraInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Special
        {
            get
            {
                return this.specialField;
            }
            set
            {
                this.specialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string SpecialIds
        {
            get
            {
                return this.specialIdsField;
            }
            set
            {
                this.specialIdsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SupplierRoomCode
        {
            get
            {
                return this.supplierRoomCodeField;
            }
            set
            {
                this.supplierRoomCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductTypeInfo1
        {
            get
            {
                return this.productTypeInfo1Field;
            }
            set
            {
                this.productTypeInfo1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductTypeInfo2
        {
            get
            {
                return this.productTypeInfo2Field;
            }
            set
            {
                this.productTypeInfo2Field = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomTypeRoomRate
    {

        private RoomTypeRoomRateRate[] ratesField;

        private RoomTypeRoomRateTotal totalField;

        private RoomTypeRoomRateCost costField;

        private RoomTypeRoomRateSupplierCommission supplierCommissionField;

        private RoomTypeRoomRateCancelPenalties cancelPenaltiesField;

        private RoomTypeRoomRateInsurance[] insuranceField;

        private RoomTypeRoomRateMealPlan mealPlanField;

        private string supplierMealPlanField;

        private string bookingCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Rate", IsNullable = false)]
        public RoomTypeRoomRateRate[] Rates
        {
            get
            {
                return this.ratesField;
            }
            set
            {
                this.ratesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public RoomTypeRoomRateTotal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public RoomTypeRoomRateCost Cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public RoomTypeRoomRateSupplierCommission SupplierCommission
        {
            get
            {
                return this.supplierCommissionField;
            }
            set
            {
                this.supplierCommissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public RoomTypeRoomRateCancelPenalties CancelPenalties
        {
            get
            {
                return this.cancelPenaltiesField;
            }
            set
            {
                this.cancelPenaltiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Insurance", Order = 5)]
        public RoomTypeRoomRateInsurance[] Insurance
        {
            get
            {
                return this.insuranceField;
            }
            set
            {
                this.insuranceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RoomTypeRoomRateMealPlan MealPlan
        {
            get
            {
                return this.mealPlanField;
            }
            set
            {
                this.mealPlanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SupplierMealPlan
        {
            get
            {
                return this.supplierMealPlanField;
            }
            set
            {
                this.supplierMealPlanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BookingCode
        {
            get
            {
                return this.bookingCodeField;
            }
            set
            {
                this.bookingCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomTypeRoomRateRate
    {

        private RoomTypeRoomRateRateTotal totalField;

        private System.DateTime effectiveDateField;

        private System.DateTime expireDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public RoomTypeRoomRateRateTotal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomTypeRoomRateRateTotal
    {

        private double amountField;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomTypeRoomRateTotal
    {

        private double amountField;

        private double commissionField;

        private double minPriceField;

        private bool minPriceFieldSpecified;

        private double addChargeField;

        private bool addChargeFieldSpecified;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Commission
        {
            get
            {
                return this.commissionField;
            }
            set
            {
                this.commissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double MinPrice
        {
            get
            {
                return this.minPriceField;
            }
            set
            {
                this.minPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinPriceSpecified
        {
            get
            {
                return this.minPriceFieldSpecified;
            }
            set
            {
                this.minPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double AddCharge
        {
            get
            {
                return this.addChargeField;
            }
            set
            {
                this.addChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddChargeSpecified
        {
            get
            {
                return this.addChargeFieldSpecified;
            }
            set
            {
                this.addChargeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomTypeRoomRateCost
    {

        private double amountField;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomTypeRoomRateSupplierCommission
    {

        private double amountField;

        private string currencyField;

        private int netField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Net
        {
            get
            {
                return this.netField;
            }
            set
            {
                this.netField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomTypeRoomRateCancelPenalties
    {

        private CancelPenaltyType[] cancelPenaltyField;

        private string descriptionField;

        private bool cancellationCostsTodayField;

        private bool cancellationCostsTodayFieldSpecified;

        private bool nonRefundableField;

        private bool nonRefundableFieldSpecified;

        private bool additionalRequestField;

        private bool additionalRequestFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CancelPenalty", Order = 0)]
        public CancelPenaltyType[] CancelPenalty
        {
            get
            {
                return this.cancelPenaltyField;
            }
            set
            {
                this.cancelPenaltyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CancellationCostsToday
        {
            get
            {
                return this.cancellationCostsTodayField;
            }
            set
            {
                this.cancellationCostsTodayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CancellationCostsTodaySpecified
        {
            get
            {
                return this.cancellationCostsTodayFieldSpecified;
            }
            set
            {
                this.cancellationCostsTodayFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonRefundable
        {
            get
            {
                return this.nonRefundableField;
            }
            set
            {
                this.nonRefundableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NonRefundableSpecified
        {
            get
            {
                return this.nonRefundableFieldSpecified;
            }
            set
            {
                this.nonRefundableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AdditionalRequest
        {
            get
            {
                return this.additionalRequestField;
            }
            set
            {
                this.additionalRequestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdditionalRequestSpecified
        {
            get
            {
                return this.additionalRequestFieldSpecified;
            }
            set
            {
                this.additionalRequestFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class CancelPenaltyType
    {

        private CancelPenaltyTypeDeadline deadlineField;

        private CancelPenaltyTypeCharge chargeField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CancelPenaltyTypeDeadline Deadline
        {
            get
            {
                return this.deadlineField;
            }
            set
            {
                this.deadlineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public CancelPenaltyTypeCharge Charge
        {
            get
            {
                return this.chargeField;
            }
            set
            {
                this.chargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class CancelPenaltyTypeDeadline
    {

        private CancelPenaltyTypeDeadlineTimeUnit timeUnitField;

        private int unitsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CancelPenaltyTypeDeadlineTimeUnit TimeUnit
        {
            get
            {
                return this.timeUnitField;
            }
            set
            {
                this.timeUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum CancelPenaltyTypeDeadlineTimeUnit
    {

        /// <remarks/>
        Day,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class CancelPenaltyTypeCharge
    {

        private double amountField;

        private double addChargeField;

        private bool addChargeFieldSpecified;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double AddCharge
        {
            get
            {
                return this.addChargeField;
            }
            set
            {
                this.addChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddChargeSpecified
        {
            get
            {
                return this.addChargeFieldSpecified;
            }
            set
            {
                this.addChargeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomTypeRoomRateInsurance
    {

        private string typeField;

        private double amountField;

        private string currencyField;

        private bool includedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Included
        {
            get
            {
                return this.includedField;
            }
            set
            {
                this.includedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum RoomTypeRoomRateMealPlan
    {

        /// <remarks/>
        RO,

        /// <remarks/>
        BB,

        /// <remarks/>
        HB,

        /// <remarks/>
        FB,

        /// <remarks/>
        AI,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum RoomTypeStatus
    {

        /// <remarks/>
        AV,

        /// <remarks/>
        OR,

        /// <remarks/>
        CD,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class GuestType
    {

        private GuestTypePersonName personNameField;

        private GuestTypeAgeCode ageCodeField;

        private bool leadGuestField;

        private bool leadGuestFieldSpecified;

        private int ageField;

        private bool ageFieldSpecified;

        private int idField;

        private bool idFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public GuestTypePersonName PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GuestTypeAgeCode AgeCode
        {
            get
            {
                return this.ageCodeField;
            }
            set
            {
                this.ageCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool LeadGuest
        {
            get
            {
                return this.leadGuestField;
            }
            set
            {
                this.leadGuestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LeadGuestSpecified
        {
            get
            {
                return this.leadGuestFieldSpecified;
            }
            set
            {
                this.leadGuestFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgeSpecified
        {
            get
            {
                return this.ageFieldSpecified;
            }
            set
            {
                this.ageFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class GuestTypePersonName
    {

        private string namePrefixField;

        private string givenNameField;

        private string surnameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string NamePrefix
        {
            get
            {
                return this.namePrefixField;
            }
            set
            {
                this.namePrefixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string GivenName
        {
            get
            {
                return this.givenNameField;
            }
            set
            {
                this.givenNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum GuestTypeAgeCode
    {

        /// <remarks/>
        A,

        /// <remarks/>
        C,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomResType
    {

        private RoomResTypeRoomType roomTypeField;

        private RoomResTypeRoomRate roomRateField;

        private GuestType[] guestsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public RoomResTypeRoomType RoomType
        {
            get
            {
                return this.roomTypeField;
            }
            set
            {
                this.roomTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public RoomResTypeRoomRate RoomRate
        {
            get
            {
                return this.roomRateField;
            }
            set
            {
                this.roomRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Guest", IsNullable = false)]
        public GuestType[] Guests
        {
            get
            {
                return this.guestsField;
            }
            set
            {
                this.guestsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomResTypeRoomType
    {

        private string[] extraInfoField;

        private string specialField;

        private int codeField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Msg", IsNullable = false)]
        public string[] ExtraInfo
        {
            get
            {
                return this.extraInfoField;
            }
            set
            {
                this.extraInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Special
        {
            get
            {
                return this.specialField;
            }
            set
            {
                this.specialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomResTypeRoomRate
    {

        private RoomResTypeRoomRateRates ratesField;

        private RoomResTypeRoomRateTotal totalField;

        private RoomResTypeRoomRateCancelPenalties cancelPenaltiesField;

        private string mealPlanField;

        private System.DateTime startField;

        private System.DateTime endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public RoomResTypeRoomRateRates Rates
        {
            get
            {
                return this.ratesField;
            }
            set
            {
                this.ratesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public RoomResTypeRoomRateTotal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public RoomResTypeRoomRateCancelPenalties CancelPenalties
        {
            get
            {
                return this.cancelPenaltiesField;
            }
            set
            {
                this.cancelPenaltiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MealPlan
        {
            get
            {
                return this.mealPlanField;
            }
            set
            {
                this.mealPlanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomResTypeRoomRateRates
    {

        private RoomResTypeRoomRateRatesRate[] rateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rate", Order = 0)]
        public RoomResTypeRoomRateRatesRate[] Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomResTypeRoomRateRatesRate
    {

        private RoomResTypeRoomRateRatesRateTotal totalField;

        private System.DateTime effectiveDateField;

        private System.DateTime expireDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public RoomResTypeRoomRateRatesRateTotal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomResTypeRoomRateRatesRateTotal
    {

        private double amountField;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomResTypeRoomRateTotal
    {

        private double amountField;

        private double commissionField;

        private bool commissionFieldSpecified;

        private double minPriceField;

        private bool minPriceFieldSpecified;

        private double addChargeField;

        private bool addChargeFieldSpecified;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Commission
        {
            get
            {
                return this.commissionField;
            }
            set
            {
                this.commissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CommissionSpecified
        {
            get
            {
                return this.commissionFieldSpecified;
            }
            set
            {
                this.commissionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double MinPrice
        {
            get
            {
                return this.minPriceField;
            }
            set
            {
                this.minPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinPriceSpecified
        {
            get
            {
                return this.minPriceFieldSpecified;
            }
            set
            {
                this.minPriceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double AddCharge
        {
            get
            {
                return this.addChargeField;
            }
            set
            {
                this.addChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddChargeSpecified
        {
            get
            {
                return this.addChargeFieldSpecified;
            }
            set
            {
                this.addChargeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class RoomResTypeRoomRateCancelPenalties
    {

        private CancelPenaltyType[] cancelPenaltyField;

        private bool cancellationCostsTodayField;

        private bool nonRefundableField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CancelPenalty", Order = 0)]
        public CancelPenaltyType[] CancelPenalty
        {
            get
            {
                return this.cancelPenaltyField;
            }
            set
            {
                this.cancelPenaltyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CancellationCostsToday
        {
            get
            {
                return this.cancellationCostsTodayField;
            }
            set
            {
                this.cancellationCostsTodayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonRefundable
        {
            get
            {
                return this.nonRefundableField;
            }
            set
            {
                this.nonRefundableField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class InfoType
    {

        private object hotelProviderField;

        private object hotelIdentField;

        private InfoTypePosition positionField;

        private object imageField;

        private InfoTypeAddress addressField;

        private InfoTypeContacts contactsField;

        private InfoTypePolicy policyField;

        private string[] warningsField;

        private int hotelCodeField;

        private string hotelNameField;

        private int hotelCityCodeField;

        private string ratingField;

        private int masterCodeField;

        private bool masterCodeFieldSpecified;

        private int recommendedField;

        private bool recommendedFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public object HotelProvider
        {
            get
            {
                return this.hotelProviderField;
            }
            set
            {
                this.hotelProviderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public object HotelIdent
        {
            get
            {
                return this.hotelIdentField;
            }
            set
            {
                this.hotelIdentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public InfoTypePosition Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public object Image
        {
            get
            {
                return this.imageField;
            }
            set
            {
                this.imageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public InfoTypeAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public InfoTypeContacts Contacts
        {
            get
            {
                return this.contactsField;
            }
            set
            {
                this.contactsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public InfoTypePolicy Policy
        {
            get
            {
                return this.policyField;
            }
            set
            {
                this.policyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Msg", IsNullable = false)]
        public string[] Warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int HotelCode
        {
            get
            {
                return this.hotelCodeField;
            }
            set
            {
                this.hotelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelName
        {
            get
            {
                return this.hotelNameField;
            }
            set
            {
                this.hotelNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int HotelCityCode
        {
            get
            {
                return this.hotelCityCodeField;
            }
            set
            {
                this.hotelCityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rating
        {
            get
            {
                return this.ratingField;
            }
            set
            {
                this.ratingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int MasterCode
        {
            get
            {
                return this.masterCodeField;
            }
            set
            {
                this.masterCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MasterCodeSpecified
        {
            get
            {
                return this.masterCodeFieldSpecified;
            }
            set
            {
                this.masterCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Recommended
        {
            get
            {
                return this.recommendedField;
            }
            set
            {
                this.recommendedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecommendedSpecified
        {
            get
            {
                return this.recommendedFieldSpecified;
            }
            set
            {
                this.recommendedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class InfoTypePosition
    {

        private double lonField;

        private double latField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Lon
        {
            get
            {
                return this.lonField;
            }
            set
            {
                this.lonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Lat
        {
            get
            {
                return this.latField;
            }
            set
            {
                this.latField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class InfoTypeAddress
    {

        private string addressLineField;

        private string cityNameField;

        private string postalCodeField;

        private string countryNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string AddressLine
        {
            get
            {
                return this.addressLineField;
            }
            set
            {
                this.addressLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string CityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string CountryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class InfoTypeContacts
    {

        private string phoneField;

        private string faxField;

        private string websiteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Website
        {
            get
            {
                return this.websiteField;
            }
            set
            {
                this.websiteField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class InfoTypePolicy
    {

        private string checkInTimeField;

        private string checkOutTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CheckInTime
        {
            get
            {
                return this.checkInTimeField;
            }
            set
            {
                this.checkInTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CheckOutTime
        {
            get
            {
                return this.checkOutTimeField;
            }
            set
            {
                this.checkOutTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class ErrorsType
    {

        private ErrorsTypeError errorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ErrorsTypeError Error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class ErrorsTypeError
    {

        private string languageField;

        private string statusField;

        private string valueField;

        public ErrorsTypeError()
        {
            this.languageField = "en-GB";
            this.statusField = "NotProcessed";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRQ
    {

        private OTA_HotelAvailRQHotelSearch hotelSearchField;

        private string echoTokenField;

        private string languageField;

        private bool rateDetailsField;

        private bool rateDetailsFieldSpecified;

        private int detailLevelField;

        private bool detailLevelFieldSpecified;

        private bool cancelPenaltiesField;

        private bool cancelPenaltiesFieldSpecified;

        private int siteField;

        private bool siteFieldSpecified;

        private long timeoutField;

        private bool timeoutFieldSpecified;

        private bool showNotActiveField;

        private bool showNotActiveFieldSpecified;

        private bool showStatisticsField;

        private bool showStatisticsFieldSpecified;

        private bool noCacheField;

        private string optionsField;

        public OTA_HotelAvailRQ()
        {
            this.noCacheField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_HotelAvailRQHotelSearch HotelSearch
        {
            get
            {
                return this.hotelSearchField;
            }
            set
            {
                this.hotelSearchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EchoToken
        {
            get
            {
                return this.echoTokenField;
            }
            set
            {
                this.echoTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RateDetails
        {
            get
            {
                return this.rateDetailsField;
            }
            set
            {
                this.rateDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateDetailsSpecified
        {
            get
            {
                return this.rateDetailsFieldSpecified;
            }
            set
            {
                this.rateDetailsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int DetailLevel
        {
            get
            {
                return this.detailLevelField;
            }
            set
            {
                this.detailLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DetailLevelSpecified
        {
            get
            {
                return this.detailLevelFieldSpecified;
            }
            set
            {
                this.detailLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CancelPenalties
        {
            get
            {
                return this.cancelPenaltiesField;
            }
            set
            {
                this.cancelPenaltiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CancelPenaltiesSpecified
        {
            get
            {
                return this.cancelPenaltiesFieldSpecified;
            }
            set
            {
                this.cancelPenaltiesFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Site
        {
            get
            {
                return this.siteField;
            }
            set
            {
                this.siteField = value;
            }
        }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRQHotelSearch
    {

        private OTA_HotelAvailRQHotelSearchCurrency currencyField;

        private OTA_HotelAvailRQHotelSearchPosition positionField;

        private OTA_HotelAvailRQHotelSearchHotelLocation hotelLocationField;

        private OTA_HotelAvailRQHotelSearchHotelRef hotelRefField;

        private OTA_HotelAvailRQHotelSearchDateRange dateRangeField;

        private OTA_HotelAvailRQHotelSearchRateRange rateRangeField;

        private OTA_HotelAvailRQHotelSearchGuestCountry guestCountryField;

        private OTA_HotelAvailRQHotelSearchRating ratingField;

        private OTA_HotelAvailRQHotelSearchMealPlan mealPlanField;

        private OTA_HotelAvailRQHotelSearchRoomCandidate[] roomCandidatesField;

        private bool bestOnlyField;

        private bool bestOnlyFieldSpecified;

        private bool availableOnlyField;

        private bool availableOnlyFieldSpecified;

        private bool filterNonRefundableField;

        private bool filterNonRefundableFieldSpecified;

        private bool filterCancellationCostsTodayField;

        private bool filterCancellationCostsTodayFieldSpecified;

        private string specialProductField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_HotelAvailRQHotelSearchCurrency Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_HotelAvailRQHotelSearchPosition Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public OTA_HotelAvailRQHotelSearchHotelLocation HotelLocation
        {
            get
            {
                return this.hotelLocationField;
            }
            set
            {
                this.hotelLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public OTA_HotelAvailRQHotelSearchHotelRef HotelRef
        {
            get
            {
                return this.hotelRefField;
            }
            set
            {
                this.hotelRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public OTA_HotelAvailRQHotelSearchDateRange DateRange
        {
            get
            {
                return this.dateRangeField;
            }
            set
            {
                this.dateRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public OTA_HotelAvailRQHotelSearchRateRange RateRange
        {
            get
            {
                return this.rateRangeField;
            }
            set
            {
                this.rateRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public OTA_HotelAvailRQHotelSearchGuestCountry GuestCountry
        {
            get
            {
                return this.guestCountryField;
            }
            set
            {
                this.guestCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public OTA_HotelAvailRQHotelSearchRating Rating
        {
            get
            {
                return this.ratingField;
            }
            set
            {
                this.ratingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public OTA_HotelAvailRQHotelSearchMealPlan MealPlan
        {
            get
            {
                return this.mealPlanField;
            }
            set
            {
                this.mealPlanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 9)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomCandidate", IsNullable = false)]
        public OTA_HotelAvailRQHotelSearchRoomCandidate[] RoomCandidates
        {
            get
            {
                return this.roomCandidatesField;
            }
            set
            {
                this.roomCandidatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool BestOnly
        {
            get
            {
                return this.bestOnlyField;
            }
            set
            {
                this.bestOnlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BestOnlySpecified
        {
            get
            {
                return this.bestOnlyFieldSpecified;
            }
            set
            {
                this.bestOnlyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AvailableOnly
        {
            get
            {
                return this.availableOnlyField;
            }
            set
            {
                this.availableOnlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AvailableOnlySpecified
        {
            get
            {
                return this.availableOnlyFieldSpecified;
            }
            set
            {
                this.availableOnlyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FilterNonRefundable
        {
            get
            {
                return this.filterNonRefundableField;
            }
            set
            {
                this.filterNonRefundableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FilterNonRefundableSpecified
        {
            get
            {
                return this.filterNonRefundableFieldSpecified;
            }
            set
            {
                this.filterNonRefundableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool FilterCancellationCostsToday
        {
            get
            {
                return this.filterCancellationCostsTodayField;
            }
            set
            {
                this.filterCancellationCostsTodayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FilterCancellationCostsTodaySpecified
        {
            get
            {
                return this.filterCancellationCostsTodayFieldSpecified;
            }
            set
            {
                this.filterCancellationCostsTodayFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SpecialProduct
        {
            get
            {
                return this.specialProductField;
            }
            set
            {
                this.specialProductField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRQHotelSearchCurrency
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRQHotelSearchPosition
    {

        private double latField;

        private double lonField;

        private int radiusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Lat
        {
            get
            {
                return this.latField;
            }
            set
            {
                this.latField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Lon
        {
            get
            {
                return this.lonField;
            }
            set
            {
                this.lonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Radius
        {
            get
            {
                return this.radiusField;
            }
            set
            {
                this.radiusField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRQHotelSearchHotelLocation
    {

        private int regionCodeField;

        private bool regionCodeFieldSpecified;

        private string cityCodeField;

        private int zoneCodeField;

        private bool zoneCodeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int RegionCode
        {
            get
            {
                return this.regionCodeField;
            }
            set
            {
                this.regionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegionCodeSpecified
        {
            get
            {
                return this.regionCodeFieldSpecified;
            }
            set
            {
                this.regionCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CityCode
        {
            get
            {
                return this.cityCodeField;
            }
            set
            {
                this.cityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ZoneCode
        {
            get
            {
                return this.zoneCodeField;
            }
            set
            {
                this.zoneCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZoneCodeSpecified
        {
            get
            {
                return this.zoneCodeFieldSpecified;
            }
            set
            {
                this.zoneCodeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRQHotelSearchHotelRef
    {

        private string hotelCodeField;

        private string hotelNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelCode
        {
            get
            {
                return this.hotelCodeField;
            }
            set
            {
                this.hotelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelName
        {
            get
            {
                return this.hotelNameField;
            }
            set
            {
                this.hotelNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRQHotelSearchDateRange
    {

        private System.DateTime startField;

        private System.DateTime endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRQHotelSearchRateRange
    {

        private double minField;

        private bool minFieldSpecified;

        private double maxField;

        private bool maxFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinSpecified
        {
            get
            {
                return this.minFieldSpecified;
            }
            set
            {
                this.minFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxSpecified
        {
            get
            {
                return this.maxFieldSpecified;
            }
            set
            {
                this.maxFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRQHotelSearchGuestCountry
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRQHotelSearchRating
    {

        private int codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRQHotelSearchMealPlan
    {

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRQHotelSearchRoomCandidate
    {

        private OTA_HotelAvailRQHotelSearchRoomCandidateGuest[] guestsField;

        private string rPHField;

        private int roomTypeCodeField;

        private bool roomTypeCodeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Guest", IsNullable = false)]
        public OTA_HotelAvailRQHotelSearchRoomCandidateGuest[] Guests
        {
            get
            {
                return this.guestsField;
            }
            set
            {
                this.guestsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int RoomTypeCode
        {
            get
            {
                return this.roomTypeCodeField;
            }
            set
            {
                this.roomTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RoomTypeCodeSpecified
        {
            get
            {
                return this.roomTypeCodeFieldSpecified;
            }
            set
            {
                this.roomTypeCodeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRQHotelSearchRoomCandidateGuest
    {

        private OTA_HotelAvailRQHotelSearchRoomCandidateGuestAgeCode ageCodeField;

        private int countField;

        private int ageField;

        private bool ageFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_HotelAvailRQHotelSearchRoomCandidateGuestAgeCode AgeCode
        {
            get
            {
                return this.ageCodeField;
            }
            set
            {
                this.ageCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgeSpecified
        {
            get
            {
                return this.ageFieldSpecified;
            }
            set
            {
                this.ageFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_HotelAvailRQHotelSearchRoomCandidateGuestAgeCode
    {

        /// <remarks/>
        A,

        /// <remarks/>
        C,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRS
    {

        private object itemField;

        private System.DateTime timeStampField;

        private string primaryLangIDField;

        private string echoTokenField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Errors", typeof(ErrorsType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Hotels", typeof(OTA_HotelAvailRSHotels), Order = 0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this.timeStampField;
            }
            set
            {
                this.timeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PrimaryLangID
        {
            get
            {
                return this.primaryLangIDField;
            }
            set
            {
                this.primaryLangIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EchoToken
        {
            get
            {
                return this.echoTokenField;
            }
            set
            {
                this.echoTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    [System.Xml.Serialization.XmlRoot]
    public partial class OTA_HotelAvailRSHotels
    {

        private OTA_HotelAvailRSHotelsDateRange dateRangeField;

        private OTA_HotelAvailRSHotelsRoomCandidate[] roomCandidatesField;

        private object statisticsField;

        private OTA_HotelAvailRSHotelsHotel[] hotelField;

        private int hotelCountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_HotelAvailRSHotelsDateRange DateRange
        {
            get
            {
                return this.dateRangeField;
            }
            set
            {
                this.dateRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomCandidate", IsNullable = false)]
        public OTA_HotelAvailRSHotelsRoomCandidate[] RoomCandidates
        {
            get
            {
                return this.roomCandidatesField;
            }
            set
            {
                this.roomCandidatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public object Statistics
        {
            get
            {
                return this.statisticsField;
            }
            set
            {
                this.statisticsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Hotel", Order = 3)]
        public OTA_HotelAvailRSHotelsHotel[] Hotel
        {
            get
            {
                return this.hotelField;
            }
            set
            {
                this.hotelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int HotelCount
        {
            get
            {
                return this.hotelCountField;
            }
            set
            {
                this.hotelCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRSHotelsDateRange
    {

        private System.DateTime startField;

        private System.DateTime endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRSHotelsRoomCandidate
    {

        private OTA_HotelAvailRSHotelsRoomCandidateGuest[] guestsField;

        private string rPHField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Guest", IsNullable = false)]
        public OTA_HotelAvailRSHotelsRoomCandidateGuest[] Guests
        {
            get
            {
                return this.guestsField;
            }
            set
            {
                this.guestsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRSHotelsRoomCandidateGuest
    {

        private OTA_HotelAvailRSHotelsRoomCandidateGuestAgeCode ageCodeField;

        private int countField;

        private int ageField;

        private bool ageFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_HotelAvailRSHotelsRoomCandidateGuestAgeCode AgeCode
        {
            get
            {
                return this.ageCodeField;
            }
            set
            {
                this.ageCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AgeSpecified
        {
            get
            {
                return this.ageFieldSpecified;
            }
            set
            {
                this.ageFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_HotelAvailRSHotelsRoomCandidateGuestAgeCode
    {

        /// <remarks/>
        A,

        /// <remarks/>
        C,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRSHotelsHotel
    {

        private OTA_HotelAvailRSHotelsHotelInfo infoField;

        private OTA_HotelAvailRSHotelsHotelBestPrice bestPriceField;

        private RoomType[] roomsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_HotelAvailRSHotelsHotelInfo Info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_HotelAvailRSHotelsHotelBestPrice BestPrice
        {
            get
            {
                return this.bestPriceField;
            }
            set
            {
                this.bestPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Room", IsNullable = false)]
        public RoomType[] Rooms
        {
            get
            {
                return this.roomsField;
            }
            set
            {
                this.roomsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRSHotelsHotelInfo
    {

        private string hotelProviderField;

        private string hotelIdentField;

        private string shortDescriptionField;

        private int correspondentCodeField;

        private bool correspondentCodeFieldSpecified;

        private int remoteProviderCodeField;

        private bool remoteProviderCodeFieldSpecified;

        private OTA_HotelAvailRSHotelsHotelInfoFacility[] facilitiesField;

        private string[] warningsField;

        private OTA_HotelAvailRSHotelsHotelInfoPosition positionField;

        private string imageField;

        private OTA_HotelAvailRSHotelsHotelInfoAddress addressField;

        private OTA_HotelAvailRSHotelsHotelInfoContacts contactsField;

        private OTA_HotelAvailRSHotelsHotelInfoPolicy policyField;

        private int hotelCodeField;

        private string hotelNameField;

        private int hotelCityCodeField;

        private string ratingField;

        private int recommendedField;

        private bool recommendedFieldSpecified;

        private int masterCodeField;

        private bool masterCodeFieldSpecified;

        private string locationField;

        private int locationCodeField;

        private bool locationCodeFieldSpecified;

        private string regionCodeField;

        private string chainField;

        private string supplierHotelCodeField;

        private string commissionTypeField;

        private int hotelCountryCodeField;

        private bool hotelCountryCodeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string HotelProvider
        {
            get
            {
                return this.hotelProviderField;
            }
            set
            {
                this.hotelProviderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string HotelIdent
        {
            get
            {
                return this.hotelIdentField;
            }
            set
            {
                this.hotelIdentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ShortDescription
        {
            get
            {
                return this.shortDescriptionField;
            }
            set
            {
                this.shortDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public int CorrespondentCode
        {
            get
            {
                return this.correspondentCodeField;
            }
            set
            {
                this.correspondentCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CorrespondentCodeSpecified
        {
            get
            {
                return this.correspondentCodeFieldSpecified;
            }
            set
            {
                this.correspondentCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public int RemoteProviderCode
        {
            get
            {
                return this.remoteProviderCodeField;
            }
            set
            {
                this.remoteProviderCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RemoteProviderCodeSpecified
        {
            get
            {
                return this.remoteProviderCodeFieldSpecified;
            }
            set
            {
                this.remoteProviderCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Facility", IsNullable = false)]
        public OTA_HotelAvailRSHotelsHotelInfoFacility[] Facilities
        {
            get
            {
                return this.facilitiesField;
            }
            set
            {
                this.facilitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Msg", IsNullable = false)]
        public string[] Warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public OTA_HotelAvailRSHotelsHotelInfoPosition Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string Image
        {
            get
            {
                return this.imageField;
            }
            set
            {
                this.imageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public OTA_HotelAvailRSHotelsHotelInfoAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public OTA_HotelAvailRSHotelsHotelInfoContacts Contacts
        {
            get
            {
                return this.contactsField;
            }
            set
            {
                this.contactsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public OTA_HotelAvailRSHotelsHotelInfoPolicy Policy
        {
            get
            {
                return this.policyField;
            }
            set
            {
                this.policyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int HotelCode
        {
            get
            {
                return this.hotelCodeField;
            }
            set
            {
                this.hotelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelName
        {
            get
            {
                return this.hotelNameField;
            }
            set
            {
                this.hotelNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int HotelCityCode
        {
            get
            {
                return this.hotelCityCodeField;
            }
            set
            {
                this.hotelCityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Rating
        {
            get
            {
                return this.ratingField;
            }
            set
            {
                this.ratingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Recommended
        {
            get
            {
                return this.recommendedField;
            }
            set
            {
                this.recommendedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecommendedSpecified
        {
            get
            {
                return this.recommendedFieldSpecified;
            }
            set
            {
                this.recommendedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int MasterCode
        {
            get
            {
                return this.masterCodeField;
            }
            set
            {
                this.masterCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MasterCodeSpecified
        {
            get
            {
                return this.masterCodeFieldSpecified;
            }
            set
            {
                this.masterCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int LocationCode
        {
            get
            {
                return this.locationCodeField;
            }
            set
            {
                this.locationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LocationCodeSpecified
        {
            get
            {
                return this.locationCodeFieldSpecified;
            }
            set
            {
                this.locationCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RegionCode
        {
            get
            {
                return this.regionCodeField;
            }
            set
            {
                this.regionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Chain
        {
            get
            {
                return this.chainField;
            }
            set
            {
                this.chainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SupplierHotelCode
        {
            get
            {
                return this.supplierHotelCodeField;
            }
            set
            {
                this.supplierHotelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CommissionType
        {
            get
            {
                return this.commissionTypeField;
            }
            set
            {
                this.commissionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int HotelCountryCode
        {
            get
            {
                return this.hotelCountryCodeField;
            }
            set
            {
                this.hotelCountryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HotelCountryCodeSpecified
        {
            get
            {
                return this.hotelCountryCodeFieldSpecified;
            }
            set
            {
                this.hotelCountryCodeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRSHotelsHotelInfoFacility
    {

        private int codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRSHotelsHotelInfoPosition
    {

        private double latField;

        private double lonField;

        private int accuracyField;

        private bool accuracyFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Lat
        {
            get
            {
                return this.latField;
            }
            set
            {
                this.latField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Lon
        {
            get
            {
                return this.lonField;
            }
            set
            {
                this.lonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Accuracy
        {
            get
            {
                return this.accuracyField;
            }
            set
            {
                this.accuracyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccuracySpecified
        {
            get
            {
                return this.accuracyFieldSpecified;
            }
            set
            {
                this.accuracyFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRSHotelsHotelInfoAddress
    {

        private string addressLineField;

        private string cityNameField;

        private string postalCodeField;

        private string countryNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string AddressLine
        {
            get
            {
                return this.addressLineField;
            }
            set
            {
                this.addressLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string CityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string CountryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRSHotelsHotelInfoContacts
    {

        private string phoneField;

        private string faxField;

        private string websiteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Website
        {
            get
            {
                return this.websiteField;
            }
            set
            {
                this.websiteField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRSHotelsHotelInfoPolicy
    {

        private string checkInTimeField;

        private string checkOutTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CheckInTime
        {
            get
            {
                return this.checkInTimeField;
            }
            set
            {
                this.checkInTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CheckOutTime
        {
            get
            {
                return this.checkOutTimeField;
            }
            set
            {
                this.checkOutTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelAvailRSHotelsHotelBestPrice
    {

        private double amountField;

        private double addChargeField;

        private bool addChargeFieldSpecified;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double AddCharge
        {
            get
            {
                return this.addChargeField;
            }
            set
            {
                this.addChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddChargeSpecified
        {
            get
            {
                return this.addChargeFieldSpecified;
            }
            set
            {
                this.addChargeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
   // [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getAvailableHotelsRequest
    {

        //[System.ServiceModel.MessageHeaderAttribute(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
         //   "")]
        public ServiceReference.CRSysSecurity CRSysSecurity;

        //[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact", Order = 0)]
        public ServiceReference.OTA_HotelAvailRQ OTA_HotelAvailRQ;

        public getAvailableHotelsRequest()
        {
        }

        public getAvailableHotelsRequest(ServiceReference.CRSysSecurity CRSysSecurity, ServiceReference.OTA_HotelAvailRQ OTA_HotelAvailRQ)
        {
            this.CRSysSecurity = CRSysSecurity;
            this.OTA_HotelAvailRQ = OTA_HotelAvailRQ;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
   // [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getAvailableHotelsResponse
    {

       // [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
        public ServiceReference.OTA_HotelAvailRS OTA_HotelAvailRS;

        public getAvailableHotelsResponse()
        {
        }

        public getAvailableHotelsResponse(ServiceReference.OTA_HotelAvailRS OTA_HotelAvailRS)
        {
            this.OTA_HotelAvailRS = OTA_HotelAvailRS;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelResRQ
    {

        private OTA_HotelResRQUniqueID uniqueIDField;

        private OTA_HotelResRQHotelRes hotelResField;

        private string echoTokenField;

        private OTA_HotelResRQTransaction transactionField;

        private int detailLevelField;

        private bool detailLevelFieldSpecified;

        private bool rateDetailsField;

        private bool rateDetailsFieldSpecified;

        private string languageField;

        private bool roomInfoField;

        private bool roomInfoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_HotelResRQUniqueID UniqueID
        {
            get
            {
                return this.uniqueIDField;
            }
            set
            {
                this.uniqueIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_HotelResRQHotelRes HotelRes
        {
            get
            {
                return this.hotelResField;
            }
            set
            {
                this.hotelResField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EchoToken
        {
            get
            {
                return this.echoTokenField;
            }
            set
            {
                this.echoTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_HotelResRQTransaction Transaction
        {
            get
            {
                return this.transactionField;
            }
            set
            {
                this.transactionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int DetailLevel
        {
            get
            {
                return this.detailLevelField;
            }
            set
            {
                this.detailLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DetailLevelSpecified
        {
            get
            {
                return this.detailLevelFieldSpecified;
            }
            set
            {
                this.detailLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RateDetails
        {
            get
            {
                return this.rateDetailsField;
            }
            set
            {
                this.rateDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateDetailsSpecified
        {
            get
            {
                return this.rateDetailsFieldSpecified;
            }
            set
            {
                this.rateDetailsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RoomInfo
        {
            get
            {
                return this.roomInfoField;
            }
            set
            {
                this.roomInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RoomInfoSpecified
        {
            get
            {
                return this.roomInfoFieldSpecified;
            }
            set
            {
                this.roomInfoFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelResRQUniqueID
    {

        private OTA_HotelResRQUniqueIDType typeField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_HotelResRQUniqueIDType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_HotelResRQUniqueIDType
    {

        /// <remarks/>
        ClientReference,

        /// <remarks/>
        Reservation,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelResRQHotelRes
    {

        private OTA_HotelResRQHotelResRoom[] roomsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Room", IsNullable = false)]
        public OTA_HotelResRQHotelResRoom[] Rooms
        {
            get
            {
                return this.roomsField;
            }
            set
            {
                this.roomsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelResRQHotelResRoom
    {

        private OTA_HotelResRQHotelResRoomRoomRate roomRateField;

        private GuestType[] guestsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_HotelResRQHotelResRoomRoomRate RoomRate
        {
            get
            {
                return this.roomRateField;
            }
            set
            {
                this.roomRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Guest", IsNullable = false)]
        public GuestType[] Guests
        {
            get
            {
                return this.guestsField;
            }
            set
            {
                this.guestsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_HotelResRQHotelResRoomRoomRate
    {

        private string bookingCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BookingCode
        {
            get
            {
                return this.bookingCodeField;
            }
            set
            {
                this.bookingCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_HotelResRQTransaction
    {

        /// <remarks/>
        PreBooking,

        /// <remarks/>
        Booking,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRS
    {

        private object[] itemsField;

        private string echoTokenField;

        private System.DateTime timeStampField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Errors", typeof(ErrorsType), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("HotelResList", typeof(OTA_BookingInfoRSHotelResList), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ResGlobalInfo", typeof(OTA_BookingInfoRSResGlobalInfo), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Rooms", typeof(OTA_BookingInfoRSRooms), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ServiceResList", typeof(OTA_BookingInfoRSServiceResList), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Success", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Total", typeof(OTA_BookingInfoRSTotal), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Warnings", typeof(OTA_BookingInfoRSWarnings), Order = 0)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EchoToken
        {
            get
            {
                return this.echoTokenField;
            }
            set
            {
                this.echoTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this.timeStampField;
            }
            set
            {
                this.timeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSHotelResList
    {

        private OTA_BookingInfoRSHotelResListHotelRes[] hotelResField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HotelRes", Order = 0)]
        public OTA_BookingInfoRSHotelResListHotelRes[] HotelRes
        {
            get
            {
                return this.hotelResField;
            }
            set
            {
                this.hotelResField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSHotelResListHotelRes
    {

        private RoomResType[] roomsField;

        private InfoType infoField;

        private OTA_BookingInfoRSHotelResListHotelResHotelResInfo hotelResInfoField;

        private OTA_BookingInfoRSHotelResListHotelResResStatus resStatusField;

        private System.DateTime createDateTimeField;

        private System.DateTime lastModifyDateTimeField;

        private bool newItemField;

        private bool newItemFieldSpecified;

        private bool canceledItemField;

        private bool canceledItemFieldSpecified;

        private bool selectedItemField;

        private bool selectedItemFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Room", IsNullable = false)]
        public RoomResType[] Rooms
        {
            get
            {
                return this.roomsField;
            }
            set
            {
                this.roomsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public InfoType Info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public OTA_BookingInfoRSHotelResListHotelResHotelResInfo HotelResInfo
        {
            get
            {
                return this.hotelResInfoField;
            }
            set
            {
                this.hotelResInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_BookingInfoRSHotelResListHotelResResStatus ResStatus
        {
            get
            {
                return this.resStatusField;
            }
            set
            {
                this.resStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime CreateDateTime
        {
            get
            {
                return this.createDateTimeField;
            }
            set
            {
                this.createDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastModifyDateTime
        {
            get
            {
                return this.lastModifyDateTimeField;
            }
            set
            {
                this.lastModifyDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NewItem
        {
            get
            {
                return this.newItemField;
            }
            set
            {
                this.newItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewItemSpecified
        {
            get
            {
                return this.newItemFieldSpecified;
            }
            set
            {
                this.newItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CanceledItem
        {
            get
            {
                return this.canceledItemField;
            }
            set
            {
                this.canceledItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CanceledItemSpecified
        {
            get
            {
                return this.canceledItemFieldSpecified;
            }
            set
            {
                this.canceledItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SelectedItem
        {
            get
            {
                return this.selectedItemField;
            }
            set
            {
                this.selectedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SelectedItemSpecified
        {
            get
            {
                return this.selectedItemFieldSpecified;
            }
            set
            {
                this.selectedItemFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSHotelResListHotelResHotelResInfo
    {

        private OTA_BookingInfoRSHotelResListHotelResHotelResInfoDateRange dateRangeField;

        private OTA_BookingInfoRSHotelResListHotelResHotelResInfoTotal totalField;

        private OTA_BookingInfoRSHotelResListHotelResHotelResInfoHotelResID[] hotelResIDsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_BookingInfoRSHotelResListHotelResHotelResInfoDateRange DateRange
        {
            get
            {
                return this.dateRangeField;
            }
            set
            {
                this.dateRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_BookingInfoRSHotelResListHotelResHotelResInfoTotal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("HotelResID", IsNullable = false)]
        public OTA_BookingInfoRSHotelResListHotelResHotelResInfoHotelResID[] HotelResIDs
        {
            get
            {
                return this.hotelResIDsField;
            }
            set
            {
                this.hotelResIDsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSHotelResListHotelResHotelResInfoDateRange
    {

        private System.DateTime startField;

        private System.DateTime endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSHotelResListHotelResHotelResInfoTotal
    {

        private double amountField;

        private double commissionField;

        private double addChargeField;

        private bool addChargeFieldSpecified;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Commission
        {
            get
            {
                return this.commissionField;
            }
            set
            {
                this.commissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double AddCharge
        {
            get
            {
                return this.addChargeField;
            }
            set
            {
                this.addChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddChargeSpecified
        {
            get
            {
                return this.addChargeFieldSpecified;
            }
            set
            {
                this.addChargeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSHotelResListHotelResHotelResInfoHotelResID
    {

        private OTA_BookingInfoRSHotelResListHotelResHotelResInfoHotelResIDType typeField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_BookingInfoRSHotelResListHotelResHotelResInfoHotelResIDType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_BookingInfoRSHotelResListHotelResHotelResInfoHotelResIDType
    {

        /// <remarks/>
        Locator,

        /// <remarks/>
        ProviderReference,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_BookingInfoRSHotelResListHotelResResStatus
    {

        /// <remarks/>
        OR,

        /// <remarks/>
        OK,

        /// <remarks/>
        CA,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSResGlobalInfo
    {

        private OTA_BookingInfoRSResGlobalInfoWarnings warningsField;

        private OTA_BookingInfoRSResGlobalInfoDateRange dateRangeField;

        private OTA_BookingInfoRSResGlobalInfoTotal totalField;

        private OTA_BookingInfoRSResGlobalInfoResID[] resIDsField;

        private string leadGuestField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_BookingInfoRSResGlobalInfoWarnings Warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_BookingInfoRSResGlobalInfoDateRange DateRange
        {
            get
            {
                return this.dateRangeField;
            }
            set
            {
                this.dateRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public OTA_BookingInfoRSResGlobalInfoTotal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ResID", IsNullable = false)]
        public OTA_BookingInfoRSResGlobalInfoResID[] ResIDs
        {
            get
            {
                return this.resIDsField;
            }
            set
            {
                this.resIDsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string LeadGuest
        {
            get
            {
                return this.leadGuestField;
            }
            set
            {
                this.leadGuestField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSResGlobalInfoWarnings
    {

        private string warningField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSResGlobalInfoDateRange
    {

        private System.DateTime startField;

        private System.DateTime endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSResGlobalInfoTotal
    {

        private double amountField;

        private double commissionField;

        private double addChargeField;

        private bool addChargeFieldSpecified;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Commission
        {
            get
            {
                return this.commissionField;
            }
            set
            {
                this.commissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double AddCharge
        {
            get
            {
                return this.addChargeField;
            }
            set
            {
                this.addChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddChargeSpecified
        {
            get
            {
                return this.addChargeFieldSpecified;
            }
            set
            {
                this.addChargeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSResGlobalInfoResID
    {

        private OTA_BookingInfoRSResGlobalInfoResIDType typeField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_BookingInfoRSResGlobalInfoResIDType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_BookingInfoRSResGlobalInfoResIDType
    {

        /// <remarks/>
        Reservation,

        /// <remarks/>
        ClientReference,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSRooms
    {

        private RoomType[] roomField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Room", Order = 0)]
        public RoomType[] Room
        {
            get
            {
                return this.roomField;
            }
            set
            {
                this.roomField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSServiceResList
    {

        private OTA_BookingInfoRSServiceResListServiceRes[] serviceResField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceRes", Order = 0)]
        public OTA_BookingInfoRSServiceResListServiceRes[] ServiceRes
        {
            get
            {
                return this.serviceResField;
            }
            set
            {
                this.serviceResField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSServiceResListServiceRes
    {

        private OTA_BookingInfoRSServiceResListServiceResService serviceField;

        private OTA_BookingInfoRSServiceResListServiceResInfo infoField;

        private OTA_BookingInfoRSServiceResListServiceResServiceResInfo serviceResInfoField;

        private OTA_BookingInfoRSServiceResListServiceResQuestion[] questionListField;

        private OTA_BookingInfoRSServiceResListServiceResResStatus resStatusField;

        private System.DateTime createDateTimeField;

        private System.DateTime lastModifyDateTimeField;

        private bool newItemField;

        private bool newItemFieldSpecified;

        private bool canceledItemField;

        private bool canceledItemFieldSpecified;

        private bool selectedItemField;

        private bool selectedItemFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_BookingInfoRSServiceResListServiceResService Service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_BookingInfoRSServiceResListServiceResInfo Info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public OTA_BookingInfoRSServiceResListServiceResServiceResInfo ServiceResInfo
        {
            get
            {
                return this.serviceResInfoField;
            }
            set
            {
                this.serviceResInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Question", IsNullable = false)]
        public OTA_BookingInfoRSServiceResListServiceResQuestion[] QuestionList
        {
            get
            {
                return this.questionListField;
            }
            set
            {
                this.questionListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_BookingInfoRSServiceResListServiceResResStatus ResStatus
        {
            get
            {
                return this.resStatusField;
            }
            set
            {
                this.resStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime CreateDateTime
        {
            get
            {
                return this.createDateTimeField;
            }
            set
            {
                this.createDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastModifyDateTime
        {
            get
            {
                return this.lastModifyDateTimeField;
            }
            set
            {
                this.lastModifyDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NewItem
        {
            get
            {
                return this.newItemField;
            }
            set
            {
                this.newItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewItemSpecified
        {
            get
            {
                return this.newItemFieldSpecified;
            }
            set
            {
                this.newItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CanceledItem
        {
            get
            {
                return this.canceledItemField;
            }
            set
            {
                this.canceledItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CanceledItemSpecified
        {
            get
            {
                return this.canceledItemFieldSpecified;
            }
            set
            {
                this.canceledItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SelectedItem
        {
            get
            {
                return this.selectedItemField;
            }
            set
            {
                this.selectedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SelectedItemSpecified
        {
            get
            {
                return this.selectedItemFieldSpecified;
            }
            set
            {
                this.selectedItemFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSServiceResListServiceResService
    {

        private OTA_BookingInfoRSServiceResListServiceResServiceServiceRate serviceRateField;

        private GuestType[] guestsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_BookingInfoRSServiceResListServiceResServiceServiceRate ServiceRate
        {
            get
            {
                return this.serviceRateField;
            }
            set
            {
                this.serviceRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Guest", IsNullable = false)]
        public GuestType[] Guests
        {
            get
            {
                return this.guestsField;
            }
            set
            {
                this.guestsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSServiceResListServiceResServiceServiceRate
    {

        private OTA_BookingInfoRSServiceResListServiceResServiceServiceRateTotal totalField;

        private OTA_BookingInfoRSServiceResListServiceResServiceServiceRateCancelPenalties cancelPenaltiesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_BookingInfoRSServiceResListServiceResServiceServiceRateTotal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_BookingInfoRSServiceResListServiceResServiceServiceRateCancelPenalties CancelPenalties
        {
            get
            {
                return this.cancelPenaltiesField;
            }
            set
            {
                this.cancelPenaltiesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSServiceResListServiceResServiceServiceRateTotal
    {

        private double amountField;

        private double commissionField;

        private bool commissionFieldSpecified;

        private double addChargeField;

        private bool addChargeFieldSpecified;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Commission
        {
            get
            {
                return this.commissionField;
            }
            set
            {
                this.commissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CommissionSpecified
        {
            get
            {
                return this.commissionFieldSpecified;
            }
            set
            {
                this.commissionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double AddCharge
        {
            get
            {
                return this.addChargeField;
            }
            set
            {
                this.addChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddChargeSpecified
        {
            get
            {
                return this.addChargeFieldSpecified;
            }
            set
            {
                this.addChargeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSServiceResListServiceResServiceServiceRateCancelPenalties
    {

        private CancelPenaltyType[] cancelPenaltyField;

        private bool cancellationCostsTodayField;

        private bool nonRefundableField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CancelPenalty", Order = 0)]
        public CancelPenaltyType[] CancelPenalty
        {
            get
            {
                return this.cancelPenaltyField;
            }
            set
            {
                this.cancelPenaltyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CancellationCostsToday
        {
            get
            {
                return this.cancellationCostsTodayField;
            }
            set
            {
                this.cancellationCostsTodayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool NonRefundable
        {
            get
            {
                return this.nonRefundableField;
            }
            set
            {
                this.nonRefundableField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSServiceResListServiceResInfo
    {

        private OTA_BookingInfoRSServiceResListServiceResInfoTransfer transferField;

        private string[] imagesField;

        private string[] warningsField;

        private int serviceCodeField;

        private string serviceNameField;

        private int serviceTypeField;

        private int serviceCityCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_BookingInfoRSServiceResListServiceResInfoTransfer Transfer
        {
            get
            {
                return this.transferField;
            }
            set
            {
                this.transferField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Image", IsNullable = false)]
        public string[] Images
        {
            get
            {
                return this.imagesField;
            }
            set
            {
                this.imagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Msg", IsNullable = false)]
        public string[] Warnings
        {
            get
            {
                return this.warningsField;
            }
            set
            {
                this.warningsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ServiceCode
        {
            get
            {
                return this.serviceCodeField;
            }
            set
            {
                this.serviceCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServiceName
        {
            get
            {
                return this.serviceNameField;
            }
            set
            {
                this.serviceNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ServiceType
        {
            get
            {
                return this.serviceTypeField;
            }
            set
            {
                this.serviceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ServiceCityCode
        {
            get
            {
                return this.serviceCityCodeField;
            }
            set
            {
                this.serviceCityCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSServiceResListServiceResInfoTransfer
    {

        private int hotelCodeField;

        private string hotelNameField;

        private int hotelCityCodeField;

        private string airportCodeField;

        private string flightNumberField;

        private string timeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int HotelCode
        {
            get
            {
                return this.hotelCodeField;
            }
            set
            {
                this.hotelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HotelName
        {
            get
            {
                return this.hotelNameField;
            }
            set
            {
                this.hotelNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int HotelCityCode
        {
            get
            {
                return this.hotelCityCodeField;
            }
            set
            {
                this.hotelCityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirportCode
        {
            get
            {
                return this.airportCodeField;
            }
            set
            {
                this.airportCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FlightNumber
        {
            get
            {
                return this.flightNumberField;
            }
            set
            {
                this.flightNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSServiceResListServiceResServiceResInfo
    {

        private OTA_BookingInfoRSServiceResListServiceResServiceResInfoServiceDate serviceDateField;

        private OTA_BookingInfoRSServiceResListServiceResServiceResInfoTotal totalField;

        private OTA_BookingInfoRSServiceResListServiceResServiceResInfoServiceResID[] serviceResIDsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_BookingInfoRSServiceResListServiceResServiceResInfoServiceDate ServiceDate
        {
            get
            {
                return this.serviceDateField;
            }
            set
            {
                this.serviceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_BookingInfoRSServiceResListServiceResServiceResInfoTotal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ServiceResID", IsNullable = false)]
        public OTA_BookingInfoRSServiceResListServiceResServiceResInfoServiceResID[] ServiceResIDs
        {
            get
            {
                return this.serviceResIDsField;
            }
            set
            {
                this.serviceResIDsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSServiceResListServiceResServiceResInfoServiceDate
    {

        private System.DateTime dateField;

        private string timeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSServiceResListServiceResServiceResInfoTotal
    {

        private double amountField;

        private double commissionField;

        private bool commissionFieldSpecified;

        private double addChargeField;

        private bool addChargeFieldSpecified;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Commission
        {
            get
            {
                return this.commissionField;
            }
            set
            {
                this.commissionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CommissionSpecified
        {
            get
            {
                return this.commissionFieldSpecified;
            }
            set
            {
                this.commissionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double AddCharge
        {
            get
            {
                return this.addChargeField;
            }
            set
            {
                this.addChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddChargeSpecified
        {
            get
            {
                return this.addChargeFieldSpecified;
            }
            set
            {
                this.addChargeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSServiceResListServiceResServiceResInfoServiceResID
    {

        private OTA_BookingInfoRSServiceResListServiceResServiceResInfoServiceResIDType typeField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_BookingInfoRSServiceResListServiceResServiceResInfoServiceResIDType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_BookingInfoRSServiceResListServiceResServiceResInfoServiceResIDType
    {

        /// <remarks/>
        Locator,

        /// <remarks/>
        ProviderReference,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSServiceResListServiceResQuestion
    {

        private string txtField;

        private string rspTxtField;

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Txt
        {
            get
            {
                return this.txtField;
            }
            set
            {
                this.txtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string RspTxt
        {
            get
            {
                return this.rspTxtField;
            }
            set
            {
                this.rspTxtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_BookingInfoRSServiceResListServiceResResStatus
    {

        /// <remarks/>
        OR,

        /// <remarks/>
        OK,

        /// <remarks/>
        CA,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSTotal
    {

        private double amountField;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingInfoRSWarnings
    {

        private string[] msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Msg", Order = 0)]
        public string[] Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class sendBookingRequestRequest
    {

       /* [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
            "")]*/
        public ServiceReference.CRSysSecurity CRSysSecurity;

       // [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact", Order = 0)]
        public ServiceReference.OTA_HotelResRQ OTA_HotelResRQ;

        public sendBookingRequestRequest()
        {
        }

        public sendBookingRequestRequest(ServiceReference.CRSysSecurity CRSysSecurity, ServiceReference.OTA_HotelResRQ OTA_HotelResRQ)
        {
            this.CRSysSecurity = CRSysSecurity;
            this.OTA_HotelResRQ = OTA_HotelResRQ;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class sendBookingRequestResponse
    {

        //[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact", Order = 0)]
        public ServiceReference.OTA_BookingInfoRS OTA_BookingInfoRS;

        public sendBookingRequestResponse()
        {
        }

        public sendBookingRequestResponse(ServiceReference.OTA_BookingInfoRS OTA_BookingInfoRS)
        {
            this.OTA_BookingInfoRS = OTA_BookingInfoRS;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_CancelRQ
    {

        private OTA_CancelRQUniqueID uniqueIDField;

        private string echoTokenField;

        private OTA_CancelRQTransaction transactionField;

        private string languageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_CancelRQUniqueID UniqueID
        {
            get
            {
                return this.uniqueIDField;
            }
            set
            {
                this.uniqueIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EchoToken
        {
            get
            {
                return this.echoTokenField;
            }
            set
            {
                this.echoTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_CancelRQTransaction Transaction
        {
            get
            {
                return this.transactionField;
            }
            set
            {
                this.transactionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_CancelRQUniqueID
    {

        private OTA_CancelRQUniqueIDType typeField;

        private int idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_CancelRQUniqueIDType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_CancelRQUniqueIDType
    {

        /// <remarks/>
        Locator,

        /// <remarks/>
        Reservation,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_CancelRQTransaction
    {

        /// <remarks/>
        Cancel,

        /// <remarks/>
        PreCancel,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class cancelBookingRequest
    {

        /*[System.ServiceModel.MessageHeaderAttribute(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
            "")]*/
        public ServiceReference.CRSysSecurity CRSysSecurity;

        //[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact", Order = 0)]
        public ServiceReference.OTA_CancelRQ OTA_CancelRQ;

        public cancelBookingRequest()
        {
        }

        public cancelBookingRequest(ServiceReference.CRSysSecurity CRSysSecurity, ServiceReference.OTA_CancelRQ OTA_CancelRQ)
        {
            this.CRSysSecurity = CRSysSecurity;
            this.OTA_CancelRQ = OTA_CancelRQ;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class cancelBookingResponse
    {

       // [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact", Order = 0)]
        public ServiceReference.OTA_BookingInfoRS OTA_BookingInfoRS;

        public cancelBookingResponse()
        {
        }

        public cancelBookingResponse(ServiceReference.OTA_BookingInfoRS OTA_BookingInfoRS)
        {
            this.OTA_BookingInfoRS = OTA_BookingInfoRS;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_CancelRS
    {

        private object itemField;

        private System.DateTime timeStampField;

        private string echoTokenField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CancelInfoRS", typeof(OTA_CancelRSCancelInfoRS), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("Errors", typeof(ErrorsType), Order = 0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this.timeStampField;
            }
            set
            {
                this.timeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EchoToken
        {
            get
            {
                return this.echoTokenField;
            }
            set
            {
                this.echoTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_CancelRSCancelInfoRS
    {

        private OTA_CancelRSCancelInfoRSUniqueID uniqueIDField;

        private OTA_CancelRSCancelInfoRSCancellationCosts cancellationCostsField;

        private OTA_CancelRSCancelInfoRSRoomType[] roomsField;

        private OTA_CancelRSCancelInfoRSService[] servicesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_CancelRSCancelInfoRSUniqueID UniqueID
        {
            get
            {
                return this.uniqueIDField;
            }
            set
            {
                this.uniqueIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_CancelRSCancelInfoRSCancellationCosts CancellationCosts
        {
            get
            {
                return this.cancellationCostsField;
            }
            set
            {
                this.cancellationCostsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RoomType", IsNullable = false)]
        public OTA_CancelRSCancelInfoRSRoomType[] Rooms
        {
            get
            {
                return this.roomsField;
            }
            set
            {
                this.roomsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Service", IsNullable = false)]
        public OTA_CancelRSCancelInfoRSService[] Services
        {
            get
            {
                return this.servicesField;
            }
            set
            {
                this.servicesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_CancelRSCancelInfoRSUniqueID
    {

        private OTA_CancelRSCancelInfoRSUniqueIDType typeField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_CancelRSCancelInfoRSUniqueIDType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_CancelRSCancelInfoRSUniqueIDType
    {

        /// <remarks/>
        Reservation,

        /// <remarks/>
        Locator,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_CancelRSCancelInfoRSCancellationCosts
    {

        private double amountField;

        private string currencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_CancelRSCancelInfoRSRoomType
    {

        private CancelPenaltyType cancelPenaltyField;

        private int codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CancelPenaltyType CancelPenalty
        {
            get
            {
                return this.cancelPenaltyField;
            }
            set
            {
                this.cancelPenaltyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_CancelRSCancelInfoRSService
    {

        private CancelPenaltyType cancelPenaltyField;

        private int codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public CancelPenaltyType CancelPenalty
        {
            get
            {
                return this.cancelPenaltyField;
            }
            set
            {
                this.cancelPenaltyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class sendPreCancelRequestRequest
    {

        /*[System.ServiceModel.MessageHeaderAttribute(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
            "")]*/
        public ServiceReference.CRSysSecurity CRSysSecurity;

        //[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact", Order = 0)]
        public ServiceReference.OTA_CancelRQ OTA_CancelRQ;

        public sendPreCancelRequestRequest()
        {
        }

        public sendPreCancelRequestRequest(ServiceReference.CRSysSecurity CRSysSecurity, ServiceReference.OTA_CancelRQ OTA_CancelRQ)
        {
            this.CRSysSecurity = CRSysSecurity;
            this.OTA_CancelRQ = OTA_CancelRQ;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class sendPreCancelRequestResponse
    {

        //[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact", Order = 0)]
        public ServiceReference.OTA_CancelRS OTA_CancelRS;

        public sendPreCancelRequestResponse()
        {
        }

        public sendPreCancelRequestResponse(ServiceReference.OTA_CancelRS OTA_CancelRS)
        {
            this.OTA_CancelRS = OTA_CancelRS;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_ReadRQ
    {

        private OTA_ReadRQUniqueID uniqueIDField;

        private string echoTokenField;

        private bool rateDetailsField;

        private bool rateDetailsFieldSpecified;

        private int detailLevelField;

        private bool detailLevelFieldSpecified;

        private string languageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_ReadRQUniqueID UniqueID
        {
            get
            {
                return this.uniqueIDField;
            }
            set
            {
                this.uniqueIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EchoToken
        {
            get
            {
                return this.echoTokenField;
            }
            set
            {
                this.echoTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool RateDetails
        {
            get
            {
                return this.rateDetailsField;
            }
            set
            {
                this.rateDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RateDetailsSpecified
        {
            get
            {
                return this.rateDetailsFieldSpecified;
            }
            set
            {
                this.rateDetailsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int DetailLevel
        {
            get
            {
                return this.detailLevelField;
            }
            set
            {
                this.detailLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DetailLevelSpecified
        {
            get
            {
                return this.detailLevelFieldSpecified;
            }
            set
            {
                this.detailLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_ReadRQUniqueID
    {

        private OTA_ReadRQUniqueIDType typeField;

        private int idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_ReadRQUniqueIDType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_ReadRQUniqueIDType
    {

        /// <remarks/>
        Locator,

        /// <remarks/>
        Reservation,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getBookingInfoRequest
    {

        /*[System.ServiceModel.MessageHeaderAttribute(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
            "")]*/
        public ServiceReference.CRSysSecurity CRSysSecurity;

       // [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact", Order = 0)]
        public ServiceReference.OTA_ReadRQ OTA_ReadRQ;

        public getBookingInfoRequest()
        {
        }

        public getBookingInfoRequest(ServiceReference.CRSysSecurity CRSysSecurity, ServiceReference.OTA_ReadRQ OTA_ReadRQ)
        {
            this.CRSysSecurity = CRSysSecurity;
            this.OTA_ReadRQ = OTA_ReadRQ;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getBookingInfoResponse
    {

        //[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact", Order = 0)]
        public ServiceReference.OTA_BookingInfoRS OTA_BookingInfoRS;

        public getBookingInfoResponse()
        {
        }

        public getBookingInfoResponse(ServiceReference.OTA_BookingInfoRS OTA_BookingInfoRS)
        {
            this.OTA_BookingInfoRS = OTA_BookingInfoRS;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingListRQ
    {

        private OTA_BookingListRQBookingSearch bookingSearchField;

        private string echoTokenField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_BookingListRQBookingSearch BookingSearch
        {
            get
            {
                return this.bookingSearchField;
            }
            set
            {
                this.bookingSearchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EchoToken
        {
            get
            {
                return this.echoTokenField;
            }
            set
            {
                this.echoTokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingListRQBookingSearch
    {

        private OTA_BookingListRQBookingSearchDateRange dateRangeField;

        private OTA_BookingListRQBookingSearchHotelRef hotelRefField;

        private OTA_BookingListRQBookingSearchResStatus resStatusField;

        private bool resStatusFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_BookingListRQBookingSearchDateRange DateRange
        {
            get
            {
                return this.dateRangeField;
            }
            set
            {
                this.dateRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_BookingListRQBookingSearchHotelRef HotelRef
        {
            get
            {
                return this.hotelRefField;
            }
            set
            {
                this.hotelRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_BookingListRQBookingSearchResStatus ResStatus
        {
            get
            {
                return this.resStatusField;
            }
            set
            {
                this.resStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResStatusSpecified
        {
            get
            {
                return this.resStatusFieldSpecified;
            }
            set
            {
                this.resStatusFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingListRQBookingSearchDateRange
    {

        private System.DateTime startField;

        private bool startFieldSpecified;

        private System.DateTime endField;

        private bool endFieldSpecified;

        private OTA_BookingListRQBookingSearchDateRangeDateType dateTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartSpecified
        {
            get
            {
                return this.startFieldSpecified;
            }
            set
            {
                this.startFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndSpecified
        {
            get
            {
                return this.endFieldSpecified;
            }
            set
            {
                this.endFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_BookingListRQBookingSearchDateRangeDateType DateType
        {
            get
            {
                return this.dateTypeField;
            }
            set
            {
                this.dateTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_BookingListRQBookingSearchDateRangeDateType
    {

        /// <remarks/>
        Arrival,

        /// <remarks/>
        Departure,

        /// <remarks/>
        Creation,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingListRQBookingSearchHotelRef
    {

        private int hotelCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int HotelCode
        {
            get
            {
                return this.hotelCodeField;
            }
            set
            {
                this.hotelCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_BookingListRQBookingSearchResStatus
    {

        /// <remarks/>
        OK,

        /// <remarks/>
        CAN,

        /// <remarks/>
        MOD,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingListRS
    {

        private OTA_BookingListRSBookingList bookingListField;

        private System.DateTime timeStampField;

        private string echoTokenField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_BookingListRSBookingList BookingList
        {
            get
            {
                return this.bookingListField;
            }
            set
            {
                this.bookingListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this.timeStampField;
            }
            set
            {
                this.timeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EchoToken
        {
            get
            {
                return this.echoTokenField;
            }
            set
            {
                this.echoTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingListRSBookingList
    {

        private OTA_BookingListRSBookingListResGlobalInfo[] resGlobalInfoField;

        private int bookingCountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResGlobalInfo", Order = 0)]
        public OTA_BookingListRSBookingListResGlobalInfo[] ResGlobalInfo
        {
            get
            {
                return this.resGlobalInfoField;
            }
            set
            {
                this.resGlobalInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int BookingCount
        {
            get
            {
                return this.bookingCountField;
            }
            set
            {
                this.bookingCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingListRSBookingListResGlobalInfo
    {

        private OTA_BookingListRSBookingListResGlobalInfoDateRange dateRangeField;

        private OTA_BookingListRSBookingListResGlobalInfoTotal totalField;

        private OTA_BookingListRSBookingListResGlobalInfoResID[] resIDsField;

        private string leadGuestField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OTA_BookingListRSBookingListResGlobalInfoDateRange DateRange
        {
            get
            {
                return this.dateRangeField;
            }
            set
            {
                this.dateRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public OTA_BookingListRSBookingListResGlobalInfoTotal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ResID", IsNullable = false)]
        public OTA_BookingListRSBookingListResGlobalInfoResID[] ResIDs
        {
            get
            {
                return this.resIDsField;
            }
            set
            {
                this.resIDsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string LeadGuest
        {
            get
            {
                return this.leadGuestField;
            }
            set
            {
                this.leadGuestField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingListRSBookingListResGlobalInfoDateRange
    {

        private System.DateTime startField;

        private bool startFieldSpecified;

        private System.DateTime endField;

        private bool endFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartSpecified
        {
            get
            {
                return this.startFieldSpecified;
            }
            set
            {
                this.startFieldSpecified = value;
            }
        }

      
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingListRSBookingListResGlobalInfoTotal
    {

        private double amountField;

        private double commissionField;

        private string currencyField;

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public partial class OTA_BookingListRSBookingListResGlobalInfoResID
    {

        private OTA_BookingListRSBookingListResGlobalInfoResIDType typeField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OTA_BookingListRSBookingListResGlobalInfoResIDType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public enum OTA_BookingListRSBookingListResGlobalInfoResIDType
    {

        /// <remarks/>
        Reservation,

        /// <remarks/>
        ClientReference,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getBookingListRequest
    {

        /*[System.ServiceModel.MessageHeaderAttribute(Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" +
            "")]*/
        public ServiceReference.CRSysSecurity CRSysSecurity;

        //[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact", Order = 0)]
        public ServiceReference.OTA_BookingListRQ OTA_BookingListRQ;

        public getBookingListRequest()
        {
        }

        public getBookingListRequest(ServiceReference.CRSysSecurity CRSysSecurity, ServiceReference.OTA_BookingListRQ OTA_BookingListRQ)
        {
            this.CRSysSecurity = CRSysSecurity;
            this.OTA_BookingListRQ = OTA_BookingListRQ;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    //[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getBookingListResponse
    {

       // [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://parsec.es/hotelapi/OTA2014Compact", Order = 0)]
        public ServiceReference.OTA_BookingListRS OTA_BookingListRS;

        public getBookingListResponse()
        {
        }

        public getBookingListResponse(ServiceReference.OTA_BookingListRS OTA_BookingListRS)
        {
            this.OTA_BookingListRS = OTA_BookingListRS;
        }
    }
}
