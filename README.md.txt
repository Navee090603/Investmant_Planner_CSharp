# Investment Planner – Console Application

A simple C# console application that helps users calculate projected investment returns for both lump sum and SIP (Systematic Investment Plan) contributions. It provides a clean interface, formatted output, and auto-generated report files.

## Features

- Supports SIP and Lump Sum calculations
- Accepts user input with validation for amount, rate, and duration
- Calculates total invested amount, maturity value, and net gain
- Generates and appends output summaries to `Investment.txt`

## Technologies Used

- C#
- .NET Framework Console Application
- Visual Studio 2019 or later

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/investment-planner.git
```

### 2. Open and Build

- Open the `.sln` file in Visual Studio
- Build the solution (`Ctrl+Shift+B`)
- Run the application (`Ctrl+F5`)

### 3. Follow Console Prompts

- Choose investment type
- Enter required fields
- View result and location of generated report

## Project Structure

InvestmentPlanner/
├── Models/
│   └── Investment.cs
├── Services/
│   ├── Calculator.cs
│   └── ReportGenerator.cs
├── Utilities/
│   └── InputHelper.cs
├── Program.cs
└── Investment.txt

## Output Format

Investment Type: SIP
Invested: ₹120,000.00
Maturity: ₹168,912.55
Gain: ₹48,912.55
Years: 5
Rate: 12%
Date: 2025-07-04 13:15:26
--------------------------

## Image For Ref

Please Visit the Ref Images folder for better understanding via images.

## License

This project is licensed under the MIT License.