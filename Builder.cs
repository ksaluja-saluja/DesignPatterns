using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

    public abstract class PackageBuilder
    {
        public Package package;

        public void CreatePackage()
        {
            package = new Package();
        }

        public abstract void SetPackageName();

        public abstract void AddAirportPickup();
        public abstract void AddAirportFare();
        public abstract void AddHotelRoom();
        public abstract void AddSightSeeing();
        public abstract void AddGift();
        public abstract void AddMeals();
    }

    public interface IPackage
    {
        string PackageName { set; get; }
        string AirportPickup { set; get; }
        string AirportFare { set; get; }
        string HotelRoom { set; get; }
        string SightSeeing { set; get; }
        string Gift { set; get; }
        string Meals { set; get; }

        string GetDetails();
    }

    public class Package : IPackage
    {
        public string PackageName { get; set; }
        public string AirportFare
        {
            get;
            set;
           
        }

        public string AirportPickup
        {
            get;
            set;
        }

        public string Gift
        {
            get;
            set;
        }

        public string HotelRoom
        {
            get;
            set;
        }

        public string Meals
        {
            get;
            set;
        }

        public string SightSeeing
        {
            get;
            set;
        }

        public string GetDetails()
        {
            return "Details of package " + this.PackageName + " are \n" + this.AirportFare + "," + this.AirportPickup + "," + this.HotelRoom + "," + this.Gift + "," + this.Meals + "," + this.SightSeeing;
        }
    }
    public class NormalPackageBuilder :PackageBuilder
    {
        public override void SetPackageName()
        {
            package.PackageName = "Normal";
        }
        public override void AddAirportFare()
        {
            package.AirportFare = "Doesn't Includes Airfare";
        }

        public override void AddAirportPickup()
        {
            package.AirportPickup = "Doesn't Includes Airport Pickup";
        }


        public override void AddGift()
        {
            package.Gift = "Doesn't Includes Gift";
        }

        public override void AddHotelRoom()
        {
            package.HotelRoom = "Includes Hotel room";
        }

        public override void AddMeals()
        {
            package.Meals = "Includes Meals";
        }

        public override void AddSightSeeing()
        {
            package.SightSeeing = "Include Sight Seeing";
        }
    }

    public class EcoPackageBuilder : PackageBuilder
    {

        public override void SetPackageName()
        {
            package.PackageName = "Economic";
        }
        public override void AddAirportFare()
        {
            package.AirportFare = "Doesn't Includes Airfare";
        }

        public override void AddAirportPickup()
        {
            package.AirportPickup = "Doesn't Includes Airport Pickup";
        }


        public override void AddGift()
        {
            package.Gift = "Doesn't Includes Gift";
        }

        public override void AddHotelRoom()
        {
            package.HotelRoom = "Includes Hotel room";
        }

        public override void AddMeals()
        {
            package.Meals = "Doesn't Includes Meals";
        }

        public override void AddSightSeeing()
        {
            package.SightSeeing = "Doesn't Include Sight Seeing";
        }
    }

    public class DeluxPackageBuilder : PackageBuilder
    {
        public override void SetPackageName()
        {
            package.PackageName = "Delux";
        }
        public override void AddAirportFare()
        {
            package.AirportFare = "Includes Airfare";
        }

        public override void AddAirportPickup()
        {
            package.AirportPickup = "Includes Airport Pickup";
        }


        public override void AddGift()
        {
            package.Gift = "Includes Gift";
        }

        public override void AddHotelRoom()
        {
            package.HotelRoom = "Includes Hotel room";
        }

        public override void AddMeals()
        {
            package.Meals = "Includes Meals";
        }

        public override void AddSightSeeing()
        {
            package.SightSeeing = "Includes Sight Seeing";
        }
    }

    public class PackageDirector
    {
        PackageBuilder packageBuilder;
        public PackageDirector(PackageBuilder packageBuilder)
        {
            this.packageBuilder = packageBuilder;
        }

        public IPackage GetPackage()
        {
            packageBuilder.CreatePackage();
            packageBuilder.SetPackageName();
            packageBuilder.AddAirportFare();
            packageBuilder.AddAirportPickup();
            packageBuilder.AddHotelRoom();
            packageBuilder.AddGift();
            packageBuilder.AddSightSeeing();
            packageBuilder.AddMeals();
            return packageBuilder.package;
        }
    }

}

