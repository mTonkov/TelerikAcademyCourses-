using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesAndObjects
{
    class GSM
    {
        private static GSM iPhone4S = new GSM(); //task 06
        public static GSM IPhone4S // property
        // task 06
        {
            get { return iPhone4S; }
        }
        static GSM() //static constructor
        // task 06
        {
            iPhone4S.manufacturer = "Apple";
            iPhone4S.model = "iPhone 4S";
            iPhone4S.Owner = String.Empty;
            iPhone4S.Price = 900;
            iPhone4S.Batt = new Battery("APL-IP4S", 84, 10, BatteryType.LiIon);
            iPhone4S.Disp = new Display(4, 16500000);
        }
        private const decimal PRICE_PER_MINUTE = 0.37m;

        private string model;
        private string manufacturer;
        private List<Call> callHistory = new List<Call>(); // task 09

        #region Properties
        public string Owner { get; set; }
        public decimal Price { get; set; }
        //owners and prices are characteristics of an item, which can be changed under certain circumstances
        public Battery Batt { get; set; }
        public Display Disp { get; set; }
        public string Model
        {
            get { return model; }
            private set
            {
                if (value.Length > 20)      //task 05
                {
                    throw new ArgumentException("Invalid input for phone model is too long!");
                }
                else { this.model = value; }
            }
        }
        //manufacturer and model should be readonly, because a mobile phone can be of only one make and model
        public string Manufacturer
        {
            get { return manufacturer; }
            private set
            {
                if (value != "HTC" && value != "Samsung" && value != "Apple" && value != "Nokia" && value != "Blackberry" && value != "Alcatel") //task 05
                {
                    throw new ArgumentException("Invalid input for phone maker!");
                }
                else { this.manufacturer = value; }
            }
        }

        public List<Call> CallHistory // task 09
        {
            get { return callHistory; }
        }
        #endregion


        #region Constructors
        public GSM(string make, string model, string owned, decimal price)
            : this()
        {
            this.Manufacturer = make;
            this.Model = model;
            this.Owner = owned;
            this.Price = price;
        }
        public GSM() // task 02            
        {
            this.Batt = new Battery();
            this.Disp = new Display();
        }
        public GSM(string make, string model)
            : this() // task 02
        {
            this.Manufacturer = make;
            this.Model = model;
        }
        public GSM(string make, string model, Battery batt, Display diplay)
            : this(make, model)
        {
            this.Batt = batt;
            this.Disp = diplay;
        }
        #endregion


        public override string ToString() //Task 04
        {
            string maker = this.Manufacturer ?? "unknown";
            string model = this.Model ?? "unknown";
            string owner = this.Owner ?? "unknown";
            string battModel = this.Batt.Model ?? "unknown";

            return (String.Format("Make: {0} \nModel: {1} \nPrice: {2:C}  \nOwned by: {3} \nBattery model: {4} \nBattery idle time: {5} \n" +
            "Battery talk time: {6} \nBattery type: {7} \nDisplay size: {8} \nDisplay colours: {9} \n", maker, model, this.Price,
            owner, battModel, this.Batt.IdleTime, this.Batt.TalkTime, this.Batt.BattType, this.Disp.Size, this.Disp.Colours));
        }

        public List<Call> AddCalls(Call newCall) //task 10
        {
            callHistory.Add(newCall);
            return callHistory;
        }

        public List<Call> RemoveCall(int numberOfCall) //task 10
        {
            callHistory.RemoveAt(numberOfCall);
            return callHistory;
        }

        public List<Call> ClearHistory() //task 10
        {
            callHistory.Clear();
            return callHistory;
        }

        public decimal CallsCost() //task 11 
        {
            int allCallsDuration = 0;
            foreach (var call in callHistory)
            {
                allCallsDuration += call.Duration;
            }
            return (allCallsDuration / 60) * PRICE_PER_MINUTE;
        }
    }
}
