using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fly
{
    class Program
    {
        static void Main(string[] args)
        {
            // 	Duck myDuck = new Duck();
            //   myDuck.fly();
            //   myDuck.MigrationFly();


            FlyBehaviors myFlyBehavior = new MigrationFly();
            Duck myDuck = new Duck(myFlyBehavior);
            myDuck.Behavior.fly();
        }
    }


    //   class Duck
    // {
    //   public void fly()
    //   {
    //     Console.WriteLine ("Flying...");
    //   }
    //   public void MigrationFly()
    //   {
    //     Console.WriteLine ("Migrating...");
    //   }
    // }


    class Duck
    {
        public FlyBehaviors Behavior;

        public Duck(FlyBehaviors behavior)
        {
            Behavior = behavior;
        }
    }

    abstract class FlyBehaviors
    {
        public abstract void fly();
    }

    class Fly : FlyBehaviors
    {
        public override void fly()
        {
            Console.WriteLine("Flying");
        }
    }


    class MigrationFly : FlyBehaviors
    {
        public override void fly()
        {
            Console.WriteLine("Migration flying");
        }
    }
}
