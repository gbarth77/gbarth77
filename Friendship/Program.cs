class Program
{
    /*Basic friend request, removing and interacting system.
    For interacting, use the HelloFriend method to send a
    confirmed message to a friend, for adding a friend use
    AddFriend method, for removing a friend that you may do
    not like anymore or just want to remove, use RemoveFriend
    method.*/
    public class Messages
    {
        static void Main(string[] args)
        {
            Messages.HelloFriend();
        }
        public static string? friendMessage;

        public static void AddFriend()
        {
            // adding a friend  
            int friends;
            System.Console.WriteLine("1 friend added! Congrats!");
            friends = 1;
            System.Console.WriteLine($"You have now {friends} friends!");
        }
        public static void RemoveFriend()
        {
            // friend removal
            int friends;
            System.Console.WriteLine("Friend removed.");
            friends = -1;
            System.Console.WriteLine($"Now you have {friends} friends");
        }
        public static void HelloFriend()
        {
            // This is for sending a confirmed message for some of your friends
            string? confirmedMessage = "Hello! My dear friend!";
            do
            {
                System.Console.WriteLine("Send a message for a friend!");
                string? friendMessage = Console.ReadLine();
                if (friendMessage != "")
                {
                    System.Console.WriteLine($"Are you sure that you want to send this message?\n '{friendMessage}'");
                    System.Console.WriteLine("Type 'y' if you want to send it or 'n' if you want to delete it");
                    string? confirm = Console.ReadLine();
                    if (confirm == "y")
                    {
                        confirmedMessage = friendMessage;
                        System.Console.WriteLine($"Your message was sent! Check in here: {confirmedMessage}");
                    }
                    else if (confirm == "n")
                    {
                        friendMessage = null;
                    }
                }
                else
                {
                    System.Console.WriteLine("Please type a valid message...");
                }
            } while (friendMessage == null);
        }
    }
}
