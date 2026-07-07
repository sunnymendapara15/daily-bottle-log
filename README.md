# Daily Bottle Log

_A simple React + ASP.NET Core tracker for vendor bottle deliveries._

## Backend (ASP.NET Core)

### Prerequisites
- .NET 8 SDK

### Run

```bash
cd backend
dotnet restore
dotnet run
```

By default the API listens on `http://localhost:5000` and stores data in `bottles.db` next to the backend project.

## Frontend (React)

### Prerequisites
- Node.js 18+ / npm

### Run

```bash
cd frontend
npm install
npm start
```

The React UI proxies `/api` calls to the backend, letting you log daily counts and instantly see history plus monthly totals.
