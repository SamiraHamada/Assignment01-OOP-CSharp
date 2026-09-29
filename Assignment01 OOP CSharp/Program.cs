using System.Security.Principal;
using System.Threading.Channels;

namespace Assignment01_OOP_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st Question
            // a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?

            // When we copy one DeliveryAddress variable into another, a separate copy of the value is created.
            //So if we modify the copied variable, the original variable does not change.

            // b) What happens when a Customer variable is copied into another variable and one variable modifies the object?

            //When we copy a Customer variable, both variables refer to the same object.
            //Therefore, if one variable modifies the object's data, the other variable sees the modification too.



            #endregion

            #region 2nd Question
            //public struct Shipment {
            //public string
            //Description;
            //public double Weight;
            //public decimal DeliveryFee;
            //}

            // a) Identify at least three problems with this design from an encapsulation perspective.

            //Fields are public, so anyone can change them directly
            //There is no validation for Weight.
            //There is no validation for DeliveryFee.
            //Description can be assigned null, empty, or whitespace.

            //b) How can private fields and public properties improve this design?

            // Make the fields private and access them through public properties.
            //The properties can validate the values before changing the fields.


            #endregion

            #region 1st Question practical
            DeliveryAddress address1 = new DeliveryAddress("Cairo", "Tahrir Street", 15);

            DeliveryAddress address2 = address1;

            address2.BuildingNumber = 20;
            address2.Street = "Makram Ebeid Street";

            Console.WriteLine("Original Address: " + address1.GetFullAddress());
            Console.WriteLine("Copied Address: " + address2.GetFullAddress());

            #endregion

            #region 6th Question practical



            DeliveryCenter center = new DeliveryCenter();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter Shipment {i} Data");

                Console.Write("Tracking Code: ");
                string trackingCode = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Weight: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Delivery Fee: ");
                decimal deliveryFee = decimal.Parse(Console.ReadLine());

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("Building Number: ");
                int buildingNumber = int.Parse(Console.ReadLine());

                DeliveryAddress address = new DeliveryAddress(
                    city,
                    street,
                    buildingNumber
                );

                Shipment shipment = new Shipment(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    address
                );

                if (center.AddShipment(shipment))
                {
                    Console.WriteLine("Shipment added successfully.");
                }
            }

            Console.WriteLine("--- All Shipments ---");

            for (int i = 0; i < 3; i++)
            {
                center[i].PrintShipment();
            }

            Console.Write("Enter a tracking code to search: ");
            string searchCode = Console.ReadLine();

            Shipment foundShipment = center[searchCode];

            if (foundShipment.TrackingCode != null)
            {
                Console.WriteLine(
                    $"Shipment found: {foundShipment.TrackingCode} - {foundShipment.Description}"
                );
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }



            #endregion

        }
    }
}

