# Alloy - CMS 13

## Getting Started

1. Unzip `App_Data.zip` in the sandbox folder.

2. Create a `appsettings.Development.json` file in the same directory as `appsettings.json` and add the following:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "EPiServer": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "ConnectionStrings": {
    "EPiServerDB": "Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Alloy.mdf;Initial Catalog=Alloy;Integrated Security=True;Connect Timeout=30"
  },
  "EPiServer": {
    "Cms": {
      "DataAccess": {
        "UpdateDatabaseSchema": "true"
      },
      "MappedRoles": {
        "Items": {
          "CmsEditors": {
            "MappedRoles": [ "WebEditors", "WebAdmins" ]
          },
          "CmsAdmins": {
            "MappedRoles": [ "WebAdmins" ]
          }
        }
      }
    }
  }
}
```

3. Login to the admin interface using the following credentials:

   - **Username:** `Admin`
   - **Password:** `Welcome123!`