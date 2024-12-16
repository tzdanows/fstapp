namespace JobSite.API.Models;

public class Application
{
    public Guid ApplicationId { get; set; }
    public Guid ApplicantId { get; set; }
    public Guid JobId { get; set; }
    public string Status { get; set; }
    public DateTime SubmissionDate { get; set; }
    public DateTime LastUpdated { get; set; }

    public Applicant Applicant { get; set; }
    public Job Job { get; set; }
}