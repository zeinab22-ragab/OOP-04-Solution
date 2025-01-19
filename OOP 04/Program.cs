using OOP_04.Q1;
using OOP_04.Q1.interFace;
using OOP_04.Q2;
using OOP_04.Q2.Interface;
using OOP_04.Q3;
using OOP_04.Q3.Interface;

namespace OOP_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part01

            ///Q1 ==> (a,b)
            ///Q2 ==> (a)
            ///Q3 ==> (b)
            ///Q4 ==> (b)
            ///Q5 ==> (:)
            ///Q6 ==> (a)
            ///Q7 ==> (b)
            ///Q8 ==> (b)
            ///Q9 ==> (b)
           ///Q10 ==> (c)

            // Part02

            ///Q1
            ///ICircle circle = new Circle { radius = 10 };
            ///circle.DisplayShapInfo();
            ///
            ///IRectangle rectangle = new Rectangle { Height = 10 , Width=5 };
            ///rectangle.DisplayShapInfo();

            ///Q2
            ///IAuthenticationService authenticationService = new BasicAuthenticationService();
            ///if (authenticationService.AuthenticateUser("admi2n", "123456"))
            ///{
            ///    Console.WriteLine("Success");
            ///
            ///    if (authenticationService.AuthorizeUser("admin", "Adminatrator"))
            ///        Console.WriteLine("Role is True");
            ///    else
            ///        Console.WriteLine("Role is false");
            ///}
            ///else
            ///    Console.WriteLine("Failed");

            ///Q3
            ///INotificationService Email = new EmailNotificationService();
            ///    Email.SendNotification("hii", "Hello");
            ///
            ///INotificationService Push = new PushNotificationService();
            ///     Push.SendNotification("hi", "Helloo");
            ///
            ///INotificationService SMS = new SmsNotificationService();
            ///     SMS.SendNotification("hiiii", "Hellooo");





        }

    }
}