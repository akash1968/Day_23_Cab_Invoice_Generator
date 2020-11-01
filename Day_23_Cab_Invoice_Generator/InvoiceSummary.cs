﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InvoiceSummary.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Day_23_Cab_Invoice_Generator
{
    public class InvoiceSummary
    {
        // Attributes for the invoice summary 
        public int numberOfRides;
        public double totalFare;
        public double averageFare;
        public int length;
    // Parameterised constructor to initialise the data attributes with the user defined values
        public InvoiceSummary(double totalFare, int length)
        {
            this.totalFare = totalFare;
            this.length = length;
        }
        // Over riding the Equals method so as to match the value of the object references
        // Default Equals method comapre the reference of the objects and not the values
        public override bool Equals(object obj)
        {
            // checking if object is not null
            if (obj == null)
                return false;
            // checking if object is equal to invoice summary or not
            if (!(obj is InvoiceSummary))
                return false;
            // converting object into InvoiceSummary Type
            InvoiceSummary invoice = (InvoiceSummary)obj;
            // Returning after comparing value of both the objects
            return ((this.numberOfRides == invoice.numberOfRides) && (this.totalFare == invoice.totalFare) && (this.averageFare == invoice.averageFare));
        }
        // Overriding equals method require overriding the GetHashCode method also
        public override int GetHashCode()
        {
            return this.numberOfRides.GetHashCode() ^ this.totalFare.GetHashCode() ^ this.averageFare.GetHashCode() ^ this.length.GetHashCode();
        }
    }
}