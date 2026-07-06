# 💊 PharmacyApp — Pharmacy Management REST API

A RESTful API for pharmacy operations management — drugs, orders, suppliers, and pharmacy records — built with **ASP.NET Core 8** and **Entity Framework Core** over **SQL Server**.

## 🛠️ Stack

| Layer | Tech |
|---|---|
| **API** | C# · ASP.NET Core 8 Web API |
| **Data** | Entity Framework Core (code-first migrations) · SQL Server |
| **Docs** | Swagger / OpenAPI (Swashbuckle) |

## ✨ Endpoints

| Resource | Route | Operations |
|---|---|---|
| Drugs | `api/drugs` | Full CRUD |
| Orders | `api/orders` | Full CRUD |
| Pharmacies | `api/pharmacies` | Full CRUD |
| Suppliers | `api/suppliers` | Full CRUD |
| Auth | `api/auth` | Login |

Every endpoint is documented and testable through the **Swagger UI**.

## 🚀 Run locally

**Prerequisites:** .NET 8 SDK · SQL Server (Express/LocalDB)

```bash
git clone https://github.com/nisithSaranga/PharmacyApp.git
cd PharmacyApp/pharmacyapp.server

# point the connection string in appsettings.json at your SQL Server instance,
# then create the database from migrations:
dotnet tool install --global dotnet-ef   # once, if not installed
dotnet ef database update

dotnet run
```

Open the Swagger UI at the URL shown in the console (e.g. `https://localhost:<port>/swagger`) to explore and test the API. A default admin and sample user are seeded on first run.

---

Built by **Nisith Saranga**
