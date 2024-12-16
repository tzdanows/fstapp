namespace JobSite.API.Models;

public class Applicant
{
    public Guid ApplicantId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string CurrentLocation { get; set; }
    public string CurrentCompany { get; set; }
    public string ResumeFilePath { get; set; }
    public string PortfolioUrl { get; set; }
    public string GithubUrl { get; set; }
    public string LinkedinUrl { get; set; }
    public string AdditionalNotes { get; set; }

    public ICollection<Application> Applications { get; set; }
}
