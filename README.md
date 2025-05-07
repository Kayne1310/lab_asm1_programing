# Water Billing Application

A Windows Forms application for calculating and generating water bills for different customer types.

## Screenshots

<p align="center">
 <img src="https://github.com/user-attachments/assets/892407d6-e4a0-417f-8cac-7c44d92297f4"  />
</p>    
<p align="center">
 <img src="https://github.com/user-attachments/assets/214066b4-d7ee-499f-bade-6cc79fe3a1da"  />
</p>  

## Features

- **Customer Information Management**: Input and store customer details including name and type
- **Water Consumption Calculation**: Calculate water usage based on previous and current meter readings
- **Multiple Customer Types**:
  - Household customers (with tiered pricing based on consumption per person)
  - Administrative agencies and public services
  - Production units
  - Business services
- **PDF Export**: Generate professional PDF invoices for water bills
- **Form Validation**: Comprehensive input validation to ensure accurate calculations

## Technical Details

- **Framework**: .NET 8.0 Windows Forms
- **Language**: C#
- **Dependencies**: 
  - iTextSharp (v5.5.13.4) - For PDF generation

## Usage

1. Enter customer information (name, type, population if household)
2. Input water meter readings (previous month and current month)
3. Click "Calculate" to compute the total amount
4. Use "Export to PDF" to generate a downloadable invoice
5. Click "Clear" to reset the form for a new entry

## Pricing Logic

### Household Customers
Tiered pricing based on consumption per person:
- 0-10 m³ per person: 5,973 VND/m³
- 10-20 m³ per person: 7,052 VND/m³
- 20-30 m³ per person: 8,699 VND/m³
- Above 30 m³ per person: 15,929 VND/m³

### Other Customer Types
Flat rates:
- Administrative agencies and public services: 9,955 VND/m³
- Production units: 11,615 VND/m³
- Business services: 22,068 VND/m³

All prices are subject to 10% VAT.

## Building and Running the Application

1. Clone the repository
2. Open the solution in Visual Studio 2022
3. Build and run the application 
