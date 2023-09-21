namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<IContactable> users = new();

            IContactable contactable;

            contactable = new EmailUser("Borse","Haraldsen","BorseHaraldsen@gmail.com");
            users.Add(contactable);    

            contactable = new MessengerUser("YO","Hallo");
            users.Add(contactable);

            /*contactable = new SnapchatUser();
            users.Add(contactable);
            */
            /*
            contactable = new RemoteService();
            users.Add(contactable);
            */

            foreach (GeneralUser item in users)
            {
                Console.WriteLine(item);
                item.Contact();
            }


        }
    }
}