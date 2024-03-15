class Program
{
    /*Basic friend request, removing and interacting system,
    for interacting. Use the HelloFriend method to send a
    confirmed message to a friend, for adding a friend use
    AddFriend method, for removing a friend that you may do
    not like anymore or just want to remove, use RemoveFriend
    method.*/
    public static class Messages
    {
        static void Main(string[] args)
        {
            Messages.HelloFriend();
        }
        public static int friends = 0;

        public static string? friendMessage;

        public static void AddFriend()
        {
            // adding a friend  
            if (friends > 100)
            {
                System.Console.WriteLine("You've reached max friends capacity, in order to add this friend, remove another.");
                return;
            }
            else
            {
                System.Console.WriteLine("A new friend added! Congrats!");
                friends++;
                System.Console.WriteLine($"You have now {friends} friends!");
            }
            System.Console.WriteLine();
        }
        public static void RemoveFriend()
        {
            // friend removal
            if (friends == 0)
            {
                System.Console.WriteLine("You can't remove anything... you have 0 friends :c");
                return;
            }
            else
            {
                System.Console.WriteLine("Friend removed.");
                friends--;
                System.Console.WriteLine($"Now you have {friends} friends");
            }
            System.Console.WriteLine();
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