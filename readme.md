# A Minimal Single Page Application Job Form
### **with a focus on milestone based development**

## Tech Stack

- **Backend**: C# .NET Core
- **Frontend**: React
- **Database**: PostgreSQL
- **Containerization**: Docker

---

## Consisting of 3 primary data models/schemas:

**Applicant (form structure & primary focus)**
```json
  "applicant": {
    "applicant_id": "123e4567-e89b-12d3-a456-426614174000",
    "name": "Tom Doe",
    "email": "tom.doe@gmail.com",
    "phone": "+123456789",
    "curr_location": "Chicago, IL",
    "curr_company": "Flock",
    "resume_filepath": "file_store/tom_doe.pdf",
    "portfolio_url": "https://tomdoe.dev",
    "github_url": "https://github.com/tomdoe",
    "linkedin_url": "https://linkedin.com/in/tomdoe",
    "additional_notes": "" // cover letter field / special notes / etc..
  }
```

**Job (job details, categorization, source data)**
```json
  "job": {
    "job_id": "789e1234-e89b-12d3-a456-426614174222",
    "title": "Software Engineer",
    "department": "Engineering",
    "location": "Chicago, IL",
    "description_url": "https://mht.dev/jobs/software-engineer",
    "posted_date": "2024-12-01T00:00:00Z"
  }
```

**Application (status oriented tracking)**
```json
  "application": {
    "application_id": "456e1237-e89b-12d3-a456-426614174111",
    "applicant_id": "123e4567-e89b-12d3-a456-426614174000",
    "job_id": "789e1234-e89b-12d3-a456-426614174222",
    "status": "applied",
    "submission_date": "2024-12-15T12:00:00Z",
    "last_updated": "2024-12-15T12:00:00Z"
  }
```

---

## Milestones

### Milestone 1: Environment Setup
- C# .NET API project setup
- PostgreSQL integration
- Basic API structure

### Milestone 2: Frontend Setup
- React application setup
- Basic routing
- Single page layout

### Milestone 3: Docker Configuration
- Containerization setup
- CI/CD setup

### Milestone 4: Core Features
- Jobs CRUD operations
- Frontend-backend integration
- Basic UI components

### Milestone 5: Job Applications
- Application form implementation
- Data management
- Full-stack integration

### Milestone 6: Deployment
- Cloud deployment (AWS/Azure)
- CI/CD pipeline
- Production environment setup

---

### Prerequisites to interact
- .NET Core SDK (latest)
- Node.js & npm
- Docker & Docker Compose
- PostgreSQL

### Local Development

1. Clone the repository:
```bash
git clone [repository-url]
cd job-application-portal
```

2. Start the development environment:
```bash
docker-compose up
```

3. Access the applications:
- Frontend: http://localhost:3073
- Backend API: http://localhost:5073
- Swagger Docs: http://localhost:5073/swagger

## sources:

docs:
- 

when attempting to structure a milestone-based approach that worked for me, I considered:
- https://www.atlassian.com/blog/project-management/project-milestones
- https://www.indeed.com/career-advice/career-development/software-project-plan
- 