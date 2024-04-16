#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace HPiLO4HealthReader.XmlGenerated
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RIBCLRESPONSE
    {

        private string sTATUSField;

        private string mESSAGEField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MESSAGE
        {
            get
            {
                return this.mESSAGEField;
            }
            set
            {
                this.mESSAGEField = value;
            }
        }
    }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
