namespace Contract_Monthly_Claim_System.Models
{
    public class Claims
    {
        public int ClaimId { get; set; }
        public string ClaimName { get; set; }
        public DateTime ClaimDate { get; set; }
        public IFormFile ClaimFile { get; set; }
        public string ClaimStatus { get; set; }
        public string ClaimContent { get; set; }

    }
}
