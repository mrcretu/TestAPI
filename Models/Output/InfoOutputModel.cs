using System;

namespace OMRO.Models.Output
{
    public class InfoOutputModel
    {
        public Guid SessionId
        {
            get { return Guid.Parse("4296b050-99f8-4ace-aadb-d740948451db"); }
            set
            {
            }
        }

        public int TacVersion
        {
            get { return 1; }
            set
            {
            }
        }

        public DateTime? TacLastUpdateDate
        {
            get { return DateTime.Parse("2019-11-19T00:00:00"); }
            set
            {
            }
        }

        public string TacContent
        {
            get { return "<h1>Termeni si conditii</h1> continut TOC"; }
            set
            {
            }
        }

        public string MarketingAccord
        {
            get { return "<h1>Acord marketing</h1> Termeni"; }
            set
            {
            }
        }

        public string GDPRAccord
        {
            get { return "< h1 > Acord GDPR </ h1 > Termenii"; }
            set
            {
            }
        }
    }
}
