using System;
namespace NovertisPharma
{
    public class Sales
    {
        private int medCode;
        private int quantSold;
        private double plannedSales;
        private double actualSales;
        private string region;
        public Sales(int medCode, int quantSold, double plannedSales, double actualSales, string region)
        {
            MedCode = medCode;
            QuantSold = quantSold;
            PlannedSales = plannedSales;
            ActualSales = actualSales;
            Region = region;
        }
        public string Region
        {
            get { return region; }
            private set { region = value; }
        }
        
        public double ActualSales
        {
            get { return actualSales; }
            private set { actualSales = value; }
        }
        
        public double PlannedSales
        {
            get { return plannedSales; }
            private set { plannedSales = value; }
        }
        
        public int QuantSold
        {
            get { return quantSold; }
            private set { quantSold = value; }
        }
        
        public int MedCode
        {
            get { return medCode; }
            private set { medCode = value; }
        }

        public string Display()
        {
            return $"The details of the sales are: {MedCode}, {QuantSold}, {PlannedSales}, {ActualSales}, {Region}";
        }
        public string Display (int medCode)
        {
            return $"Difference between Actual Sales and Planned Sales of {MedCode} is {PlannedSales - ActualSales}";
        }
    }
}