
using static System.Console;
namespace C_.Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            #region  What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            //هيتغير في النسخة ومش هيتغير في المتغير الاصلي عشان ستراكت من نوع فاليو 
            #endregion

            #region What happens when a Customer variable is copied into another variable and one variable modifies the object
            //هيتم تغير قيمة الفاليو عند الاتنين لان الكلاس نوعه ريفرانس الاتنين ليهم نفس العنوان بيشاورو علي نفس المتغير
            #endregion
            #endregion

            #region Question 2
            #region a) Identify at least three problems with this design from an encapsulation perspective.
            //1-استخدام بابلك في كل الفيلد الي موجودة هيساعد علي الوصول ليها في اي مكان ومن اي كود وده ضد مبداء الانكبسوليشن
            //2- عدم وجود شرط لادخال البيانات ممكن يخلي مثلا ادخال قيم الوزن بالسالب لازم يكون في شروط لادخال البيانات بحيث مستقبلش اي بيانات عشوائية
            //3- البابلك مش هتسمحلي ان اعمل اي فيلد للقراءة فقد لان البابلك بتسمح للقراءة او تعديل اي متغير تم انشائه
            #endregion
            #region b) How can private fields and public properties improve this design? 
            //تحويلهم الي برايفت يمنع الوصول ليهم من اي كود اخر خارج الكلاس وده يحافظ علي سرية وصحة القيم المدخلة
            // البروبرتي هتفصل تعريف الداتا عن استخدمها بالجيت والسيت يعني ممكن اخلي الداتا للقراءة فقط ممكن اخليها للتغير القيم فقط وممكن اخليها الاتنين مع بعض
            #endregion
            #endregion

            #region Create one DeliveryAddress value, copy it into a second variable, modify the copy, and print both values to prove that the original did not change.
            DeliveryAddress deliveryAddress = new DeliveryAddress("Cairo", "arab", 14);
            DeliveryAddress deliveryAddress02 = deliveryAddress;
            deliveryAddress.GetFullAddress();
            deliveryAddress.GetFullAddress();
            deliveryAddress02.City = "alex";
            WriteLine(deliveryAddress.City);
            #endregion

        }
    }
}
