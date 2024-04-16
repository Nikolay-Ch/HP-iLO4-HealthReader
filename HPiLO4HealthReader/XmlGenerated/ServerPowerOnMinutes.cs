#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HPiLO4HealthReader.XmlGenerated
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "RIBCL", Namespace = "", IsNullable = false)]
    public partial class ServerPowerOnMinutes
    {

        private RIBCLRESPONSE rESPONSEField;

        private RIBCLSERVER_POWER_ON_MINUTES sERVER_POWER_ON_MINUTESField;

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
        public RIBCLSERVER_POWER_ON_MINUTES SERVER_POWER_ON_MINUTES
        {
            get
            {
                return this.sERVER_POWER_ON_MINUTESField;
            }
            set
            {
                this.sERVER_POWER_ON_MINUTESField = value;
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
    public partial class RIBCLSERVER_POWER_ON_MINUTES
    {

        private uint vALUEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint VALUE
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
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
