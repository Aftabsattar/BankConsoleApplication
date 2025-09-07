# BankConsoleApplication

A simple C#/.NET console application that simulates basic banking operations. It’s designed as a learning project to practice C# fundamentals, console I/O, and clean code structure.

## Features

- Create a new bank account
- View account details and current balance
- Deposit and withdraw funds with input validation
- Transfer funds between accounts
- View transaction history (per account)
- Simple, menu-driven console UI

## Tech Stack

- Language: C#
- Runtime: .NET (SDK 7.0+ recommended; .NET 8 works as well)
- Project Type: Console Application

## Getting Started

### Prerequisites
- .NET SDK 7.0 or later installed
  - Check with: `dotnet --version`

### Clone the repository
```bash
git clone https://github.com/Aftabsattar/BankConsoleApplication.git
cd BankConsoleApplication
```

### Build and run

Option 1: Using the solution
```bash
dotnet restore
dotnet build
# Run the console project (adjust the path if needed)
dotnet run --project BankConsoleApplication/BankConsoleApplication.csproj
```

Option 2: From the project directory
```bash
cd BankConsoleApplication
dotnet run
```

Option 3: Using Visual Studio
- Open `BankConsoleApplication.sln`
- Set `BankConsoleApplication` as the startup project
- Press F5 to run

## Usage

When the app starts, you’ll see a menu like:

```
==============================
       Bank Application
==============================
1) Create Account
2) View Balance
3) Deposit
4) Withdraw
5) Transfer
6) Transaction History
0) Exit
Select an option: _
```

- Follow the prompts to enter account numbers, amounts, etc.
- Input is validated; you’ll be reprompted if the value is invalid.

## Project Structure

```
BankConsoleApplication.sln
BankConsoleApplication/
  ├─ Program.cs
  ├─ (Additional folders like Models/, Services/, or Data/ if applicable)
  └─ BankConsoleApplication.csproj
```

Note: The internal structure may evolve (e.g., adding models for Account/Transaction, services for business logic, and repositories for storage).

## Roadmap Ideas

- Persist data to a file or database
- Add validation and error handling improvements
- Unit tests for core banking operations
- Support for account types (Savings/Current)
- Export statements (CSV/JSON)

## Contributing

- Fork the repository
- Create a feature branch
- Commit your changes with clear messages
- Open a pull request

## License

No license has been specified yet. If you plan to share or reuse this project, consider adding a license (see https://choosealicense.com).

## Contact

- Author: [Aftabsattar](https://github.com/Aftabsattar)
- Repository: https://github.com/Aftabsattar/BankConsoleApplication
