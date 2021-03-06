using System;
namespace NovertisPharma
{
    public class Medicine
    {
        private int medCode;
        private string medName;
        private string manufName;
        private double unitPrice;
        private int stockQuantity;
        private Date manufDate;
        private Date expDate;
        private int batchNum;

        public Medicine(int medCode, string medName, string manufName, double unitPrice, int stockQuantity, Date manufDate, Date expDate, int batchNum)
        {
         MedCode = medCode;
         MedName = medName;
         ManufName = manufName;
         UnitPrice =unitPrice;
         StockQuantity = stockQuantity;
         ManufDate = manufDate;
         ExpDate = expDate;
         BatchNum = batchNum;   
        }

        public int BatchNum
        {
            get { return batchNum; }
            private set { batchNum = value; }
        }
        
        public Date ExpDate
        {
            get { return expDate; }
            private set { expDate = value; }
        }
        
        public Date ManufDate
        {
            get { return manufDate; }
            private set { manufDate = value; }
        }
        
        public int StockQuantity
        {
            get { return stockQuantity; }
            private set { stockQuantity = value; }
        }
        
        public double UnitPrice
        {
            get { return unitPrice; }
            private set { 
               if(value > 0){
                unitPrice = value;
               }else{
                   throw new ArgumentOutOfRangeException();
               }
                 }
        }
        
        public string ManufName
        {
            get { return manufName; }
            private set { manufName = value; }
        }
        
        public string MedName
        {
            get { return medName; }
            private set { medName = value; }
        }
        
        public int MedCode
        {
            get { return medCode; }
            private set { medCode = value; }
        }

        public string Print ()
        {
            return $"The details of the medicine are {MedCode}, {MedName}, {ManufName}, {UnitPrice}, {StockQuantity}, {ManufDate}, {ExpDate}, {BatchNum}";
        }

        public string Print(int medCode)
        {
            return $"The Quantities in stock of medicine with code {MedCode} is {StockQuantity}";
        }

        public string Print(int medCode, string medName)
        {
            return $"{MedName} with code {MedCode} has a manufactured date of {ManufDate} and expiry date of {ExpDate}";
        }


        public int IncreaseStock(int num)
        {
            if(StockQuantity == 0)
            {
               return StockQuantity += 50;
            }else{
                return StockQuantity;
            }
        }
        
    }
}