# A Minimal Single Page Job Form
### **with a focus on milestone based development**

## Tech Stack

- **Backend**: C# .NET Core
- **Frontend**: React
- **Database**: PostgreSQL
- **Containerization**: Docker

---

## Consisting of 3 primary data models/schemas:

**Applicant (form structure & primary focus)**

`http://localhost:5193/api/applicant`
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
    "additional_notes": ""
  }
```

**Job (job details, categorization, source data)**

`http://localhost:5193/api/jobs`
```json
  "job": {
    "job_id": "789e1234-e89b-12d3-a456-426614174222",
    "title": "Software Engineer",
    "department": "Engineering",
    "location": "Chicago, IL",
    "description_url": "https://fstapp.dev/jobs/{company}/{job-title}/{job-post-id}",
    "posted_date": "2024-12-01T00:00:00Z"
  }
```

**Application (status oriented tracking)**

`http://localhost:5193/api/application`
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

Swagger api docs at: `http://localhost:5193/`

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
- Cloud deployment, options: (AWS/Azure/Alt)
- CI/CD pipeline
- Production environment setup

---

### Prereqs to run
- .NET Core SDK (latest)
- Node.js & npm
- Docker & Docker Compose
- PostgreSQL (running)

1. Clone the repository:

2. Start the development environment:
```bash
cd fstapp
# local:
cd Jobsite.API
dotnet run
# in another terminal:
cd Frontend
npm run dev

# OR just (docker):
docker-compose up
```

3. Access the applications:
- Frontend: http://localhost:3193
- Backend APIs: http://localhost:5193/api/(dependent)
- Swagger Docs: http://localhost:5193

## sources:

docs:
- https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet
- https://www.npgsql.org/doc/basic-usage.html
- https://gist.github.com/bertt/b61b014c72c5a94b39c2d30497ba7f37
- https://support.smartbear.com/swaggerhub/getting-started/
- 

when attempting to structure a milestone-based approach that worked for me, I considered:
- https://www.atlassian.com/blog/project-management/project-milestones
- 