# SelfHelpLedger

SelfHelpLedger is a Blazor Server application designed for a self-help group to manage member registration, deposits, withdrawals, and to view transaction history with a unique 6-character transaction number for each transaction. The app uses SQL Server for data storage.

## Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Database Setup](#database-setup)
- [Running the Application](#running-the-application)
- [Navigation](#navigation)
- [Troubleshooting](#troubleshooting)
- [License](#license)

## Features

- **Member Registration:** Add new members with a name and initial balance.
- **Deposits:** Increase a member’s balance by recording deposit transactions.
- **Withdrawals:** Decrease a member’s balance (with sufficient funds) by recording withdrawal transactions.
- **Member List:** Display all registered members with their current balances.
- **Transaction History:** View detailed transactions (including a unique 6-character transaction number) for each member.
- **Transaction Search:** Filter transactions by entering a transaction number.

## Prerequisites

Before running the application, ensure you have the following installed:

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (local installation or a cloud instance)
- A code editor (e.g., [Visual Studio Code](https://code.visualstudio.com/))

## Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/yourusername/SelfHelpLedger.git
   cd SelfHelpLedger
