namespace OMRO.Models.Input
{
    public class StartUserRegistrationModel
    {
        public string Email { get; set; }

        public string Cif { get; set; }

        public bool TermsAndConditionsAccepted { get; set; }

        public bool MarketingConsentIsGiven { get; set; }
    }
}
