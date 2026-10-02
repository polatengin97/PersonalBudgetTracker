# Personal Budget Tracker

## Description

Personal Budget Tracker is a Windows Forms application created with C#. It allows users to add income and expense transactions and monitor their personal budget.

## Features

- Add income and expense transactions
- Enter amount, category, description, and date
- Display total income, total expenses, and current balance
- View recent transactions
- Double-click a transaction to view its details
- Delete selected transactions
- Save and load transactions using a JSON file
- Handle invalid input and file errors

## OOP Concepts

The project demonstrates:

- Classes and objects
- Encapsulation
- Inheritance
- Abstraction
- Polymorphism
- Exception handling

`Transaction` is the abstract parent class. `Income` and `Expense` inherit from `Transaction` and override the `GetValue()` method. `TransactionManager` manages the transaction list and calculates the totals.

## How to Run

1. Download or clone the repository.
2. Open the solution file in Microsoft Visual Studio.
3. Build the solution.
4. Press the Start button or F5 to run the application.

## Requirements

- Windows
- Microsoft Visual Studio
- .NET Windows Forms

## References and Tools Used

- Microsoft Visual Studio
- C#
- .NET Windows Forms
- System.Text.Json
- Git
- GitHub
- ITS203 lecture and tutorial materials