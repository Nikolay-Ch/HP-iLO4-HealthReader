#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HPiLO4HealthReader.XmlGenerated
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "RIBCL", Namespace = "", IsNullable = false)]
    public partial class EmbeddedHealthData
    {

        private RIBCLRESPONSE rESPONSEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATA gET_EMBEDDED_HEALTH_DATAField;

        private decimal vERSIONField;

        /// <remarks/>
        public RIBCLRESPONSE RESPONSE
        {
            get
            {
                return this.rESPONSEField;
            }
            set
            {
                this.rESPONSEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATA GET_EMBEDDED_HEALTH_DATA
        {
            get
            {
                return this.gET_EMBEDDED_HEALTH_DATAField;
            }
            set
            {
                this.gET_EMBEDDED_HEALTH_DATAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal VERSION
        {
            get
            {
                return this.vERSIONField;
            }
            set
            {
                this.vERSIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATA
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAFAN[] fANSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATATEMP[] tEMPERATUREField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIES pOWER_SUPPLIESField;

        private object vRMField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORS pROCESSORSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORY mEMORYField;

        private RIBCLGET_EMBEDDED_HEALTH_DATANIC[] nIC_INFORMATIONField;

        private RIBCLGET_EMBEDDED_HEALTH_DATASTORAGE sTORAGEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATION fIRMWARE_INFORMATIONField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCE hEALTH_AT_A_GLANCEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FAN", IsNullable = false)]
        public RIBCLGET_EMBEDDED_HEALTH_DATAFAN[] FANS
        {
            get
            {
                return this.fANSField;
            }
            set
            {
                this.fANSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TEMP", IsNullable = false)]
        public RIBCLGET_EMBEDDED_HEALTH_DATATEMP[] TEMPERATURE
        {
            get
            {
                return this.tEMPERATUREField;
            }
            set
            {
                this.tEMPERATUREField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIES POWER_SUPPLIES
        {
            get
            {
                return this.pOWER_SUPPLIESField;
            }
            set
            {
                this.pOWER_SUPPLIESField = value;
            }
        }

        /// <remarks/>
        public object VRM
        {
            get
            {
                return this.vRMField;
            }
            set
            {
                this.vRMField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORS PROCESSORS
        {
            get
            {
                return this.pROCESSORSField;
            }
            set
            {
                this.pROCESSORSField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORY MEMORY
        {
            get
            {
                return this.mEMORYField;
            }
            set
            {
                this.mEMORYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("NIC", IsNullable = false)]
        public RIBCLGET_EMBEDDED_HEALTH_DATANIC[] NIC_INFORMATION
        {
            get
            {
                return this.nIC_INFORMATIONField;
            }
            set
            {
                this.nIC_INFORMATIONField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATASTORAGE STORAGE
        {
            get
            {
                return this.sTORAGEField;
            }
            set
            {
                this.sTORAGEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATION FIRMWARE_INFORMATION
        {
            get
            {
                return this.fIRMWARE_INFORMATIONField;
            }
            set
            {
                this.fIRMWARE_INFORMATIONField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCE HEALTH_AT_A_GLANCE
        {
            get
            {
                return this.hEALTH_AT_A_GLANCEField;
            }
            set
            {
                this.hEALTH_AT_A_GLANCEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFAN
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAFANZONE zONEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFANLABEL lABELField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFANSTATUS sTATUSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFANSPEED sPEEDField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFANZONE ZONE
        {
            get
            {
                return this.zONEField;
            }
            set
            {
                this.zONEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFANLABEL LABEL
        {
            get
            {
                return this.lABELField;
            }
            set
            {
                this.lABELField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFANSTATUS STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFANSPEED SPEED
        {
            get
            {
                return this.sPEEDField;
            }
            set
            {
                this.sPEEDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFANZONE
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFANLABEL
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFANSTATUS
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFANSPEED
    {

        private byte vALUEField;

        private string uNITField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UNIT
        {
            get
            {
                return this.uNITField;
            }
            set
            {
                this.uNITField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATATEMP
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATATEMPLABEL lABELField;

        private RIBCLGET_EMBEDDED_HEALTH_DATATEMPLOCATION lOCATIONField;

        private RIBCLGET_EMBEDDED_HEALTH_DATATEMPSTATUS sTATUSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATATEMPCURRENTREADING cURRENTREADINGField;

        private RIBCLGET_EMBEDDED_HEALTH_DATATEMPCAUTION cAUTIONField;

        private RIBCLGET_EMBEDDED_HEALTH_DATATEMPCRITICAL cRITICALField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATATEMPLABEL LABEL
        {
            get
            {
                return this.lABELField;
            }
            set
            {
                this.lABELField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATATEMPLOCATION LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATATEMPSTATUS STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATATEMPCURRENTREADING CURRENTREADING
        {
            get
            {
                return this.cURRENTREADINGField;
            }
            set
            {
                this.cURRENTREADINGField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATATEMPCAUTION CAUTION
        {
            get
            {
                return this.cAUTIONField;
            }
            set
            {
                this.cAUTIONField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATATEMPCRITICAL CRITICAL
        {
            get
            {
                return this.cRITICALField;
            }
            set
            {
                this.cRITICALField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATATEMPLABEL
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATATEMPLOCATION
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATATEMPSTATUS
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATATEMPCURRENTREADING
    {

        private string vALUEField;

        private string uNITField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UNIT
        {
            get
            {
                return this.uNITField;
            }
            set
            {
                this.uNITField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATATEMPCAUTION
    {

        private string vALUEField;

        private string uNITField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UNIT
        {
            get
            {
                return this.uNITField;
            }
            set
            {
                this.uNITField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATATEMPCRITICAL
    {

        private string vALUEField;

        private string uNITField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UNIT
        {
            get
            {
                return this.uNITField;
            }
            set
            {
                this.uNITField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIES
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARY pOWER_SUPPLY_SUMMARYField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLY[] sUPPLYField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARY POWER_SUPPLY_SUMMARY
        {
            get
            {
                return this.pOWER_SUPPLY_SUMMARYField;
            }
            set
            {
                this.pOWER_SUPPLY_SUMMARYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SUPPLY")]
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLY[] SUPPLY
        {
            get
            {
                return this.sUPPLYField;
            }
            set
            {
                this.sUPPLYField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARY
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARYPRESENT_POWER_READING pRESENT_POWER_READINGField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARYPOWER_MANAGEMENT_CONTROLLER_FIRMWARE_VERSION pOWER_MANAGEMENT_CONTROLLER_FIRMWARE_VERSIONField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARYHP_POWER_DISCOVERY_SERVICES_REDUNDANCY_STATUS hP_POWER_DISCOVERY_SERVICES_REDUNDANCY_STATUSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARYHIGH_EFFICIENCY_MODE hIGH_EFFICIENCY_MODEField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARYPRESENT_POWER_READING PRESENT_POWER_READING
        {
            get
            {
                return this.pRESENT_POWER_READINGField;
            }
            set
            {
                this.pRESENT_POWER_READINGField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARYPOWER_MANAGEMENT_CONTROLLER_FIRMWARE_VERSION POWER_MANAGEMENT_CONTROLLER_FIRMWARE_VERSION
        {
            get
            {
                return this.pOWER_MANAGEMENT_CONTROLLER_FIRMWARE_VERSIONField;
            }
            set
            {
                this.pOWER_MANAGEMENT_CONTROLLER_FIRMWARE_VERSIONField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARYHP_POWER_DISCOVERY_SERVICES_REDUNDANCY_STATUS HP_POWER_DISCOVERY_SERVICES_REDUNDANCY_STATUS
        {
            get
            {
                return this.hP_POWER_DISCOVERY_SERVICES_REDUNDANCY_STATUSField;
            }
            set
            {
                this.hP_POWER_DISCOVERY_SERVICES_REDUNDANCY_STATUSField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARYHIGH_EFFICIENCY_MODE HIGH_EFFICIENCY_MODE
        {
            get
            {
                return this.hIGH_EFFICIENCY_MODEField;
            }
            set
            {
                this.hIGH_EFFICIENCY_MODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARYPRESENT_POWER_READING
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARYPOWER_MANAGEMENT_CONTROLLER_FIRMWARE_VERSION
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARYHP_POWER_DISCOVERY_SERVICES_REDUNDANCY_STATUS
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESPOWER_SUPPLY_SUMMARYHIGH_EFFICIENCY_MODE
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLY
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYLABEL lABELField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYPRESENT pRESENTField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYSTATUS sTATUSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYPDS pDSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYHOTPLUG_CAPABLE hOTPLUG_CAPABLEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYMODEL mODELField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYSPARE sPAREField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYSERIAL_NUMBER sERIAL_NUMBERField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYCAPACITY cAPACITYField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYFIRMWARE_VERSION fIRMWARE_VERSIONField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYLABEL LABEL
        {
            get
            {
                return this.lABELField;
            }
            set
            {
                this.lABELField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYPRESENT PRESENT
        {
            get
            {
                return this.pRESENTField;
            }
            set
            {
                this.pRESENTField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYSTATUS STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYPDS PDS
        {
            get
            {
                return this.pDSField;
            }
            set
            {
                this.pDSField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYHOTPLUG_CAPABLE HOTPLUG_CAPABLE
        {
            get
            {
                return this.hOTPLUG_CAPABLEField;
            }
            set
            {
                this.hOTPLUG_CAPABLEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYMODEL MODEL
        {
            get
            {
                return this.mODELField;
            }
            set
            {
                this.mODELField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYSPARE SPARE
        {
            get
            {
                return this.sPAREField;
            }
            set
            {
                this.sPAREField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYSERIAL_NUMBER SERIAL_NUMBER
        {
            get
            {
                return this.sERIAL_NUMBERField;
            }
            set
            {
                this.sERIAL_NUMBERField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYCAPACITY CAPACITY
        {
            get
            {
                return this.cAPACITYField;
            }
            set
            {
                this.cAPACITYField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYFIRMWARE_VERSION FIRMWARE_VERSION
        {
            get
            {
                return this.fIRMWARE_VERSIONField;
            }
            set
            {
                this.fIRMWARE_VERSIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYLABEL
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYPRESENT
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYSTATUS
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYPDS
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYHOTPLUG_CAPABLE
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYMODEL
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYSPARE
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYSERIAL_NUMBER
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYCAPACITY
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPOWER_SUPPLIESSUPPLYFIRMWARE_VERSION
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORS
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSOR pROCESSORField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSOR PROCESSOR
        {
            get
            {
                return this.pROCESSORField;
            }
            set
            {
                this.pROCESSORField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSOR
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORLABEL lABELField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORNAME nAMEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORSTATUS sTATUSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORSPEED sPEEDField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSOREXECUTION_TECHNOLOGY eXECUTION_TECHNOLOGYField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORMEMORY_TECHNOLOGY mEMORY_TECHNOLOGYField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORINTERNAL_L1_CACHE iNTERNAL_L1_CACHEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORINTERNAL_L2_CACHE iNTERNAL_L2_CACHEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORINTERNAL_L3_CACHE iNTERNAL_L3_CACHEField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORLABEL LABEL
        {
            get
            {
                return this.lABELField;
            }
            set
            {
                this.lABELField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORNAME NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORSTATUS STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORSPEED SPEED
        {
            get
            {
                return this.sPEEDField;
            }
            set
            {
                this.sPEEDField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSOREXECUTION_TECHNOLOGY EXECUTION_TECHNOLOGY
        {
            get
            {
                return this.eXECUTION_TECHNOLOGYField;
            }
            set
            {
                this.eXECUTION_TECHNOLOGYField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORMEMORY_TECHNOLOGY MEMORY_TECHNOLOGY
        {
            get
            {
                return this.mEMORY_TECHNOLOGYField;
            }
            set
            {
                this.mEMORY_TECHNOLOGYField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORINTERNAL_L1_CACHE INTERNAL_L1_CACHE
        {
            get
            {
                return this.iNTERNAL_L1_CACHEField;
            }
            set
            {
                this.iNTERNAL_L1_CACHEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORINTERNAL_L2_CACHE INTERNAL_L2_CACHE
        {
            get
            {
                return this.iNTERNAL_L2_CACHEField;
            }
            set
            {
                this.iNTERNAL_L2_CACHEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORINTERNAL_L3_CACHE INTERNAL_L3_CACHE
        {
            get
            {
                return this.iNTERNAL_L3_CACHEField;
            }
            set
            {
                this.iNTERNAL_L3_CACHEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORLABEL
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORNAME
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORSTATUS
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORSPEED
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSOREXECUTION_TECHNOLOGY
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORMEMORY_TECHNOLOGY
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORINTERNAL_L1_CACHE
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORINTERNAL_L2_CACHE
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAPROCESSORSPROCESSORINTERNAL_L3_CACHE
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORY
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYADVANCED_MEMORY_PROTECTION aDVANCED_MEMORY_PROTECTIONField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARY mEMORY_DETAILS_SUMMARYField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1[] mEMORY_DETAILSField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYADVANCED_MEMORY_PROTECTION ADVANCED_MEMORY_PROTECTION
        {
            get
            {
                return this.aDVANCED_MEMORY_PROTECTIONField;
            }
            set
            {
                this.aDVANCED_MEMORY_PROTECTIONField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARY MEMORY_DETAILS_SUMMARY
        {
            get
            {
                return this.mEMORY_DETAILS_SUMMARYField;
            }
            set
            {
                this.mEMORY_DETAILS_SUMMARYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CPU_1", IsNullable = false)]
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1[] MEMORY_DETAILS
        {
            get
            {
                return this.mEMORY_DETAILSField;
            }
            set
            {
                this.mEMORY_DETAILSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYADVANCED_MEMORY_PROTECTION
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYADVANCED_MEMORY_PROTECTIONAMP_MODE_STATUS aMP_MODE_STATUSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYADVANCED_MEMORY_PROTECTIONCONFIGURED_AMP_MODE cONFIGURED_AMP_MODEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYADVANCED_MEMORY_PROTECTIONAVAILABLE_AMP_MODES aVAILABLE_AMP_MODESField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYADVANCED_MEMORY_PROTECTIONAMP_MODE_STATUS AMP_MODE_STATUS
        {
            get
            {
                return this.aMP_MODE_STATUSField;
            }
            set
            {
                this.aMP_MODE_STATUSField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYADVANCED_MEMORY_PROTECTIONCONFIGURED_AMP_MODE CONFIGURED_AMP_MODE
        {
            get
            {
                return this.cONFIGURED_AMP_MODEField;
            }
            set
            {
                this.cONFIGURED_AMP_MODEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYADVANCED_MEMORY_PROTECTIONAVAILABLE_AMP_MODES AVAILABLE_AMP_MODES
        {
            get
            {
                return this.aVAILABLE_AMP_MODESField;
            }
            set
            {
                this.aVAILABLE_AMP_MODESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYADVANCED_MEMORY_PROTECTIONAMP_MODE_STATUS
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYADVANCED_MEMORY_PROTECTIONCONFIGURED_AMP_MODE
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYADVANCED_MEMORY_PROTECTIONAVAILABLE_AMP_MODES
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARY
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1 cPU_1Field;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1 CPU_1
        {
            get
            {
                return this.cPU_1Field;
            }
            set
            {
                this.cPU_1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1NUMBER_OF_SOCKETS nUMBER_OF_SOCKETSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1TOTAL_MEMORY_SIZE tOTAL_MEMORY_SIZEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1OPERATING_FREQUENCY oPERATING_FREQUENCYField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1OPERATING_VOLTAGE oPERATING_VOLTAGEField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1NUMBER_OF_SOCKETS NUMBER_OF_SOCKETS
        {
            get
            {
                return this.nUMBER_OF_SOCKETSField;
            }
            set
            {
                this.nUMBER_OF_SOCKETSField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1TOTAL_MEMORY_SIZE TOTAL_MEMORY_SIZE
        {
            get
            {
                return this.tOTAL_MEMORY_SIZEField;
            }
            set
            {
                this.tOTAL_MEMORY_SIZEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1OPERATING_FREQUENCY OPERATING_FREQUENCY
        {
            get
            {
                return this.oPERATING_FREQUENCYField;
            }
            set
            {
                this.oPERATING_FREQUENCYField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1OPERATING_VOLTAGE OPERATING_VOLTAGE
        {
            get
            {
                return this.oPERATING_VOLTAGEField;
            }
            set
            {
                this.oPERATING_VOLTAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1NUMBER_OF_SOCKETS
    {

        private byte vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1TOTAL_MEMORY_SIZE
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1OPERATING_FREQUENCY
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYMEMORY_DETAILS_SUMMARYCPU_1OPERATING_VOLTAGE
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1SOCKET sOCKETField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1STATUS sTATUSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1HP_SMART_MEMORY hP_SMART_MEMORYField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1PART pARTField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1TYPE tYPEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1SIZE sIZEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1FREQUENCY fREQUENCYField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1MINIMUM_VOLTAGE mINIMUM_VOLTAGEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1RANKS rANKSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1TECHNOLOGY tECHNOLOGYField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1SOCKET SOCKET
        {
            get
            {
                return this.sOCKETField;
            }
            set
            {
                this.sOCKETField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1STATUS STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1HP_SMART_MEMORY HP_SMART_MEMORY
        {
            get
            {
                return this.hP_SMART_MEMORYField;
            }
            set
            {
                this.hP_SMART_MEMORYField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1PART PART
        {
            get
            {
                return this.pARTField;
            }
            set
            {
                this.pARTField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1TYPE TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1SIZE SIZE
        {
            get
            {
                return this.sIZEField;
            }
            set
            {
                this.sIZEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1FREQUENCY FREQUENCY
        {
            get
            {
                return this.fREQUENCYField;
            }
            set
            {
                this.fREQUENCYField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1MINIMUM_VOLTAGE MINIMUM_VOLTAGE
        {
            get
            {
                return this.mINIMUM_VOLTAGEField;
            }
            set
            {
                this.mINIMUM_VOLTAGEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1RANKS RANKS
        {
            get
            {
                return this.rANKSField;
            }
            set
            {
                this.rANKSField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1TECHNOLOGY TECHNOLOGY
        {
            get
            {
                return this.tECHNOLOGYField;
            }
            set
            {
                this.tECHNOLOGYField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1SOCKET
    {

        private byte vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1STATUS
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1HP_SMART_MEMORY
    {

        private string vALUEField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1PART
    {

        private string nUMBERField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NUMBER
        {
            get
            {
                return this.nUMBERField;
            }
            set
            {
                this.nUMBERField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1TYPE
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1SIZE
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1FREQUENCY
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1MINIMUM_VOLTAGE
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1RANKS
    {

        private byte vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAMEMORYCPU_1TECHNOLOGY
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATANIC
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATANICNETWORK_PORT nETWORK_PORTField;

        private RIBCLGET_EMBEDDED_HEALTH_DATANICPORT_DESCRIPTION pORT_DESCRIPTIONField;

        private RIBCLGET_EMBEDDED_HEALTH_DATANICLOCATION lOCATIONField;

        private RIBCLGET_EMBEDDED_HEALTH_DATANICMAC_ADDRESS mAC_ADDRESSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATANICIP_ADDRESS iP_ADDRESSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATANICSTATUS sTATUSField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATANICNETWORK_PORT NETWORK_PORT
        {
            get
            {
                return this.nETWORK_PORTField;
            }
            set
            {
                this.nETWORK_PORTField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATANICPORT_DESCRIPTION PORT_DESCRIPTION
        {
            get
            {
                return this.pORT_DESCRIPTIONField;
            }
            set
            {
                this.pORT_DESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATANICLOCATION LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATANICMAC_ADDRESS MAC_ADDRESS
        {
            get
            {
                return this.mAC_ADDRESSField;
            }
            set
            {
                this.mAC_ADDRESSField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATANICIP_ADDRESS IP_ADDRESS
        {
            get
            {
                return this.iP_ADDRESSField;
            }
            set
            {
                this.iP_ADDRESSField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATANICSTATUS STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATANICNETWORK_PORT
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATANICPORT_DESCRIPTION
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATANICLOCATION
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATANICMAC_ADDRESS
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATANICIP_ADDRESS
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATANICSTATUS
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATASTORAGE
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATASTORAGEDISCOVERY_STATUS dISCOVERY_STATUSField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATASTORAGEDISCOVERY_STATUS DISCOVERY_STATUS
        {
            get
            {
                return this.dISCOVERY_STATUSField;
            }
            set
            {
                this.dISCOVERY_STATUSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATASTORAGEDISCOVERY_STATUS
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATASTORAGEDISCOVERY_STATUSSTATUS sTATUSField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATASTORAGEDISCOVERY_STATUSSTATUS STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATASTORAGEDISCOVERY_STATUSSTATUS
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATION
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_1 iNDEX_1Field;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_2 iNDEX_2Field;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_3 iNDEX_3Field;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_4 iNDEX_4Field;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_5 iNDEX_5Field;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_6 iNDEX_6Field;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_7 iNDEX_7Field;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_8 iNDEX_8Field;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_1 INDEX_1
        {
            get
            {
                return this.iNDEX_1Field;
            }
            set
            {
                this.iNDEX_1Field = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_2 INDEX_2
        {
            get
            {
                return this.iNDEX_2Field;
            }
            set
            {
                this.iNDEX_2Field = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_3 INDEX_3
        {
            get
            {
                return this.iNDEX_3Field;
            }
            set
            {
                this.iNDEX_3Field = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_4 INDEX_4
        {
            get
            {
                return this.iNDEX_4Field;
            }
            set
            {
                this.iNDEX_4Field = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_5 INDEX_5
        {
            get
            {
                return this.iNDEX_5Field;
            }
            set
            {
                this.iNDEX_5Field = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_6 INDEX_6
        {
            get
            {
                return this.iNDEX_6Field;
            }
            set
            {
                this.iNDEX_6Field = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_7 INDEX_7
        {
            get
            {
                return this.iNDEX_7Field;
            }
            set
            {
                this.iNDEX_7Field = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_8 INDEX_8
        {
            get
            {
                return this.iNDEX_8Field;
            }
            set
            {
                this.iNDEX_8Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_1
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_1FIRMWARE_NAME fIRMWARE_NAMEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_1FIRMWARE_VERSION fIRMWARE_VERSIONField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_1FIRMWARE_NAME FIRMWARE_NAME
        {
            get
            {
                return this.fIRMWARE_NAMEField;
            }
            set
            {
                this.fIRMWARE_NAMEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_1FIRMWARE_VERSION FIRMWARE_VERSION
        {
            get
            {
                return this.fIRMWARE_VERSIONField;
            }
            set
            {
                this.fIRMWARE_VERSIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_1FIRMWARE_NAME
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_1FIRMWARE_VERSION
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_2
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_2FIRMWARE_NAME fIRMWARE_NAMEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_2FIRMWARE_VERSION fIRMWARE_VERSIONField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_2FIRMWARE_NAME FIRMWARE_NAME
        {
            get
            {
                return this.fIRMWARE_NAMEField;
            }
            set
            {
                this.fIRMWARE_NAMEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_2FIRMWARE_VERSION FIRMWARE_VERSION
        {
            get
            {
                return this.fIRMWARE_VERSIONField;
            }
            set
            {
                this.fIRMWARE_VERSIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_2FIRMWARE_NAME
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_2FIRMWARE_VERSION
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_3
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_3FIRMWARE_NAME fIRMWARE_NAMEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_3FIRMWARE_VERSION fIRMWARE_VERSIONField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_3FIRMWARE_NAME FIRMWARE_NAME
        {
            get
            {
                return this.fIRMWARE_NAMEField;
            }
            set
            {
                this.fIRMWARE_NAMEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_3FIRMWARE_VERSION FIRMWARE_VERSION
        {
            get
            {
                return this.fIRMWARE_VERSIONField;
            }
            set
            {
                this.fIRMWARE_VERSIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_3FIRMWARE_NAME
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_3FIRMWARE_VERSION
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_4
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_4FIRMWARE_NAME fIRMWARE_NAMEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_4FIRMWARE_VERSION fIRMWARE_VERSIONField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_4FIRMWARE_NAME FIRMWARE_NAME
        {
            get
            {
                return this.fIRMWARE_NAMEField;
            }
            set
            {
                this.fIRMWARE_NAMEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_4FIRMWARE_VERSION FIRMWARE_VERSION
        {
            get
            {
                return this.fIRMWARE_VERSIONField;
            }
            set
            {
                this.fIRMWARE_VERSIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_4FIRMWARE_NAME
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_4FIRMWARE_VERSION
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_5
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_5FIRMWARE_NAME fIRMWARE_NAMEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_5FIRMWARE_VERSION fIRMWARE_VERSIONField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_5FIRMWARE_NAME FIRMWARE_NAME
        {
            get
            {
                return this.fIRMWARE_NAMEField;
            }
            set
            {
                this.fIRMWARE_NAMEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_5FIRMWARE_VERSION FIRMWARE_VERSION
        {
            get
            {
                return this.fIRMWARE_VERSIONField;
            }
            set
            {
                this.fIRMWARE_VERSIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_5FIRMWARE_NAME
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_5FIRMWARE_VERSION
    {

        private decimal vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_6
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_6FIRMWARE_NAME fIRMWARE_NAMEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_6FIRMWARE_VERSION fIRMWARE_VERSIONField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_6FIRMWARE_NAME FIRMWARE_NAME
        {
            get
            {
                return this.fIRMWARE_NAMEField;
            }
            set
            {
                this.fIRMWARE_NAMEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_6FIRMWARE_VERSION FIRMWARE_VERSION
        {
            get
            {
                return this.fIRMWARE_VERSIONField;
            }
            set
            {
                this.fIRMWARE_VERSIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_6FIRMWARE_NAME
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_6FIRMWARE_VERSION
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_7
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_7FIRMWARE_NAME fIRMWARE_NAMEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_7FIRMWARE_VERSION fIRMWARE_VERSIONField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_7FIRMWARE_NAME FIRMWARE_NAME
        {
            get
            {
                return this.fIRMWARE_NAMEField;
            }
            set
            {
                this.fIRMWARE_NAMEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_7FIRMWARE_VERSION FIRMWARE_VERSION
        {
            get
            {
                return this.fIRMWARE_VERSIONField;
            }
            set
            {
                this.fIRMWARE_VERSIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_7FIRMWARE_NAME
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_7FIRMWARE_VERSION
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_8
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_8FIRMWARE_NAME fIRMWARE_NAMEField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_8FIRMWARE_VERSION fIRMWARE_VERSIONField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_8FIRMWARE_NAME FIRMWARE_NAME
        {
            get
            {
                return this.fIRMWARE_NAMEField;
            }
            set
            {
                this.fIRMWARE_NAMEField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_8FIRMWARE_VERSION FIRMWARE_VERSION
        {
            get
            {
                return this.fIRMWARE_VERSIONField;
            }
            set
            {
                this.fIRMWARE_VERSIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_8FIRMWARE_NAME
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAFIRMWARE_INFORMATIONINDEX_8FIRMWARE_VERSION
    {

        private string vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCE
    {

        private RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEBIOS_HARDWARE bIOS_HARDWAREField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEFANS fANSField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCETEMPERATURE tEMPERATUREField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEPOWER_SUPPLIES pOWER_SUPPLIESField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEPROCESSOR pROCESSORField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEMEMORY mEMORYField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCENETWORK nETWORKField;

        private RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCESTORAGE sTORAGEField;

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEBIOS_HARDWARE BIOS_HARDWARE
        {
            get
            {
                return this.bIOS_HARDWAREField;
            }
            set
            {
                this.bIOS_HARDWAREField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEFANS FANS
        {
            get
            {
                return this.fANSField;
            }
            set
            {
                this.fANSField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCETEMPERATURE TEMPERATURE
        {
            get
            {
                return this.tEMPERATUREField;
            }
            set
            {
                this.tEMPERATUREField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEPOWER_SUPPLIES POWER_SUPPLIES
        {
            get
            {
                return this.pOWER_SUPPLIESField;
            }
            set
            {
                this.pOWER_SUPPLIESField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEPROCESSOR PROCESSOR
        {
            get
            {
                return this.pROCESSORField;
            }
            set
            {
                this.pROCESSORField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEMEMORY MEMORY
        {
            get
            {
                return this.mEMORYField;
            }
            set
            {
                this.mEMORYField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCENETWORK NETWORK
        {
            get
            {
                return this.nETWORKField;
            }
            set
            {
                this.nETWORKField = value;
            }
        }

        /// <remarks/>
        public RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCESTORAGE STORAGE
        {
            get
            {
                return this.sTORAGEField;
            }
            set
            {
                this.sTORAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEBIOS_HARDWARE
    {

        private string sTATUSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEFANS
    {

        private string sTATUSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCETEMPERATURE
    {

        private string sTATUSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEPOWER_SUPPLIES
    {

        private string sTATUSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEPROCESSOR
    {

        private string sTATUSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCEMEMORY
    {

        private string sTATUSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCENETWORK
    {

        private string sTATUSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLGET_EMBEDDED_HEALTH_DATAHEALTH_AT_A_GLANCESTORAGE
    {

        private string sTATUSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }
    }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
