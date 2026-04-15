# THA-Payroll

Windows desktop payroll application for a textile manufacturing context (attendance, payroll, HR-related screens, Crystal Reports, and optional biometric device integration). The codebase was originally developed around **2017** and is kept here as a portfolio reference.

## Technology

- **.NET Framework** (main app targets **4.6**; satellite projects may use **4.5.2**)
- **VB.NET** WinForms (primary UI)
- **SQL Server** for data
- **SAP Crystal Reports** for reporting (RPT files embedded in the main project)
- Optional **C#** jobs under `Job\` for automation

## Repository layout

| Path | Description |
|------|-------------|
| `THA-Payroll\` | Main WinForms application (open `THA-Payroll.sln`) |
| `THApayroll.AutoProcess\` | Console-style automation / email helpers (VB.NET) |
| `Job\THApayroll.JobAutomation\` | Separate C# solution: scheduled-style payroll / biometric processing |

## Prerequisites

- **Visual Studio** with **.NET desktop development** workload.
- **SAP Crystal Reports for .NET** (version compatible with the referenced Crystal assemblies in the projects).
- **SQL Server** (or compatible instance) and a restored / migrated database your schema expects (e.g. payroll-related databases referenced in code and configs).

## Configuration (required after clone)

Connection strings and SMTP settings in the repository use **placeholders** (`YOUR_SQL_SERVER`, `YOUR_PASSWORD`, `your-email@example.com`, etc.). Before running anything:

1. **`THA-Payroll\app.config`** — set `THA_Payroll.My.MySettings.TexoConnectionString` to your SQL connection string.
2. **`THA-Payroll\Connection.ini`** — used by `Module\ConnectSql.vb` for runtime connection; align server, database, and credentials with your environment.
3. **`THA-Payroll\My Project\Settings.settings`** (and generated `Settings.Designer.vb` if you change settings in the IDE) — design-time default connection string for typed settings.
4. **`Job\THApayroll.JobAutomation\THApayroll.JobAutomation\App.config`** — SQL `connectionStrings` / `appSettings` and mail settings for the job host.
5. **`THApayroll.AutoProcess\App.config`** — SMTP settings for the auto-process console.
6. **`THApayroll.AutoProcess\clsGeneral.vb`** — contains sample connection variables; align with your DB or switch to reading from config/INI as appropriate.

Never commit real passwords or private connection strings to a public repository. Use local overrides or environment-specific files that stay untracked (see `.gitignore`).

## What you typically do *not* need in Git

These are either generated, machine-specific, or restore from NuGet—your `.gitignore` already excludes most of them:

| Item | Why |
|------|-----|
| **`bin/`, `obj/`, `.vs/`** | Build and IDE caches; recreated on build. |
| **`*.user`** (e.g. `THA-Payroll.vbproj.user`) | Local paths (Crystal Reports references, debug settings). |
| **`packages/`** (under the project that uses NuGet) | Restored from `packages.config` via NuGet. |
| **`THA_Payroll.xml`, `THApayroll.AutoProcess.xml`** | XML doc files emitted next to the build output when XML documentation is enabled. |
| **`*.msi`** | Installer output, not source. |
| **Real secrets** in `app.config` / `Connection.ini` | Use placeholders in the repo; keep real values local. |

Optional: a legacy **Visual Studio Setup Project** (`.vdproj`) for MSI packaging is *not* required to browse or compile the application; add it only if you still build installers.

## Naming note

- **Product / folder / solution:** `THA-Payroll`
- **Root namespace and assembly name in code:** `THA_Payroll` (VB identifiers cannot contain a hyphen; the executable builds as **`THA_Payroll.exe`**)

## Build

1. Open `THA-Payroll.sln` in Visual Studio.
2. Restore any NuGet packages if prompted.
3. Set **`THA-Payroll`** as the startup project (for the main UI).
4. Build **Debug** or **Release**. Output for the main app is configured under the project folder (check `OutputPath` in `THA-Payroll.vbproj`).

The **Job** automation solution is opened separately: `Job\THApayroll.JobAutomation\THApayroll.JobAutomation.sln`.

## License and use

This repository is shared for **showcase / portfolio** purposes. Business logic, database schema, and third-party SDKs (e.g. biometric vendor wrappers) remain subject to their original terms; verify licensing before reuse in production.
