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



        }
    }
}
