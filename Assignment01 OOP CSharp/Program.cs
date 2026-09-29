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

         

    }
    }
}
