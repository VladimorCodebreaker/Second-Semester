using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Programming_4.Task_2
{

    internal class MobilePhone
    {
        public static ArrayList nokiaN95;

        public void NokiaN95(MobilePhone mb, Battery b, Display d)
        {
            nokiaN95 = new ArrayList { mb.Model, mb.Manufacturer, mb.Price, mb.Owner, b.BatteryModel, b.IdleTime, b.HoursTalk, d.ScreenSize, d.ScreenColour };

            Console.WriteLine("Nokia N95\n\n");
            foreach (var element in nokiaN95)
            {
                Console.WriteLine(element.ToString() + " ");
            }
        }

        private string model;
        private string manufacturer;
        private int price;
        private string owner;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public MobilePhone()
        {
            this.model = Model;
            this.manufacturer = Manufacturer;
            this.price = Price;
            this.owner = Owner;
        }

        public MobilePhone(string Model, string Manufacturer, int Price, string Owner)
        {
            this.model = Model;
            this.manufacturer = Manufacturer;
            this.price = Price;
            this.owner = Owner;
        }
    }
    internal class Battery
    {
        private int batterymodel;
        private int idleTime;
        private int hoursTalk;

        public int BatteryModel
        {
            get { return this.batterymodel; }
            set { this.batterymodel = value; }
        }

        public int IdleTime
        {
            get { return this.idleTime; }
            set { this.idleTime = value; }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public Battery()
        {
            this.batterymodel = BatteryModel;
            this.idleTime = IdleTime;
            this.hoursTalk = HoursTalk;
        }

        public Battery(int BatteryModel, int IdleTime, int HoursTalk)
        {
            this.batterymodel = BatteryModel;
            this.idleTime = IdleTime;
            this.hoursTalk = HoursTalk;
        }

        private enum BatteryType { Lilon, NiMH, NiCd }
    }
    internal class Display
    {
        private int screenSize;
        private string screenColour;

        public int ScreenSize
        {
            get { return this.screenSize; }
            set { this.screenSize = value; }
        }

        public string ScreenColour
        {
            get { return this.screenColour; }
            set { this.screenColour = value; }
        }

        public Display()
        {
            this.screenSize = ScreenSize;
            this.screenColour = ScreenColour;
        }

        public Display(int ScreenSize, string ScreenColour)
        {
            this.screenSize = ScreenSize;
            this.screenColour = ScreenColour;
        }
    }
    internal class GSM
    {
        public void Print(MobilePhone mb, Battery b, Display d)
        {
            Console.WriteLine($"Model: {mb.Model}\n" +
                $"Manufacturer: {mb.Manufacturer}\n" +
                $"Price: {mb.Price}\n" +
                $"Owner: {mb.Owner}\n" +
                $"\n" +
                $"BatteryModel: {b.BatteryModel}\n" +
                $"IdleTime: {b.IdleTime}\n" +
                $"HoursTalk: {b.HoursTalk}\n" +
                $"\n" +
                $"ScreenSize: {d.ScreenSize}\n" +
                $"ScreenColour: {d.ScreenColour}");
        }
    }

}
