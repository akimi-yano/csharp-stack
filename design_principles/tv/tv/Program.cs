using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tv
{
    class Program
    {
        static void Main(string[] args)
        {
            Television myTV = new Television();
            RemoteControl myRemote = new RemoteControl(myTV);
            myRemote.click();
            myRemote.click();
            myRemote.click();
            myRemote.click();
        }
    }

    // ORIGINAL CODE

    //class RemoteControl
    //{
    //    public Television TV;
    //    public RemoteControl(Television tv)
    //    {
    //        TV = tv;
    //    }

    //    public void click()
    //    {
    //        if (TV.IsOn)
    //        {
    //            TV.TurnTVOff();
    //        }
    //        else
    //        {
    //            TV.TurnTVOn();
    //        }
    //        TV.IsOn = !TV.IsOn;
    //    }
    //}

    //class Television
    //{
    //    public bool IsOn;

    //    public Television()
    //    {
    //        IsOn = false;
    //    }
    //    public void TurnTVOn()
    //    {
    //        Console.WriteLine("Turning tv on..");
    //    }

    //    public void TurnTVOff()
    //    {
    //        Console.WriteLine("Turning tv off..");
    //    }
    //}



    //GROUP SOLUTION 

    //abstract class OnOffDevice
    //{
    //    public bool IsOn;
    //    public abstract void TurnOn();
    //    public abstract void TurnOff();
    //}

    //class RemoteControl
    //{
    //    public OnOffDevice Device;
    //    public RemoteControl(OnOffDevice device)
    //    {
    //        Device = device;
    //    }

    //    public void click()
    //    {
    //        if (Device.IsOn)
    //        {
    //            Device.TurnOff();
    //        }
    //        else
    //        {
    //            Device.TurnOn();
    //        }
    //        Device.IsOn = !Device.IsOn;
    //    }
    //}

    //class Television : OnOffDevice
    //{
    //    public Television()
    //    {
    //        IsOn = false;
    //    }
    //    public override void TurnOn()
    //    {
    //        Console.WriteLine("Turning tv on..");
    //    }

    //    public override void TurnOff()
    //    {
    //        Console.WriteLine("Turning tv off..");
    //    }
    //}

    //Instructor Solution 

    class RemoteControl
    {
        public OnOffDevice Device;
        public RemoteControl(OnOffDevice device)
        {
            Device = device;
        }

        public void click()
        {
            if (Device.getStatus())
            {
                Device.turnOff();
            }
            else
            {
                Device.turnOn();
            }
        }
    }

    interface OnOffDevice
    {
        void turnOn();
        void turnOff();
        bool getStatus();
    }

    class Television : OnOffDevice
    {
        public bool IsOn;

        public Television()
        {
            IsOn = false;
        }
        public bool getStatus()
        {
            return IsOn;
        }
        public void turnOn()
        {
            Console.WriteLine("Turning tv on..");
            IsOn = !IsOn;
        }

        public void turnOff()
        {
            Console.WriteLine("Turning tv off..");
            IsOn = !IsOn;
        }
    }
}
