using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesAndObjects
{
    class Battery
    {
        private string model;
        private ushort idleTime;
        private byte talkTime;
        public BatteryType BattType { get; set; }

        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length > 10) //task 05
                {
                    throw new ArgumentException("Invalid input for battery model. Too long!");
                }
                else { this.model = value ?? "unknown"; }
            } 
        }

        public ushort IdleTime
        {
            get { return idleTime; }
            set
            {
                if (0 > idleTime) //task 05
                {
                    throw new ArgumentException("The phone cannot have negative idle time");
                }
                else { this.idleTime = value; }
            } 
        }

        public byte TalkTime
        {
            get { return talkTime; }
            set
            {
                if (talkTime > idleTime) //task 05
                {
                    throw new ArgumentException("Invalid input data. Talk time cannot be more than idle time!");
                }
                else { this.talkTime = value; }
            }
        }

        public Battery()
        { }
        public Battery(string model, ushort idle, byte talk, BatteryType batType)
        {
            this.Model = model;
            this.IdleTime = idle;
            this.TalkTime = talk;
            this.BattType = batType;
        }
    }

    public enum BatteryType //task 03
    {
        NiMH, NiCD, LiIon
    }
}
