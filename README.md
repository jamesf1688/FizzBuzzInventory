# FizzBuzz Inventory System

This is a C# console application I created for my Level 3 IT programming practice at Gloucestershire College.

## What it does

The program uses a `for` loop to go through item numbers 1 to 50. It displays:
- **Restock** if the item number is divisible by 3
- **Overstock** if it is divisible by 5
- **Critical Alert** if it is divisible by both 3 and 5
- **OK** for all other item numbers

## How it works

I used `if`, `else if` and `else` statements to check each number. The `%` operator checks for a remainder when dividing, and `&&` means both conditions must be true. I put the Critical Alert check first so items like 15, 30 and 45 show the correct message.

I tested it in Visual Studio 2026 and checked the console output.

## Running the code

Create a C# Console App in Visual Studio (.NET 10), replace the contents of `Program.cs` with the code in this repository, and run using **Ctrl + F5**.

*Study and Practice task — 12 October 2026.*
