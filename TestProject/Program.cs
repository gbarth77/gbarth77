using Microsoft.VisualBasic;

namespace Friendship
{
    class Program
    {
        public class Messages
        {
            public static string? friendMessage;

            public static void addFriend()
            {
                int friends;
                System.Console.WriteLine("1 friend added! Congrats!");
                friends = 1;
                System.Console.WriteLine(friends);
            }
            public static void removeFriend()
            {
                int friends;
                System.Console.WriteLine("Friend removed.");
                friends = -1;
                System.Console.WriteLine(friends);
            }
            public static void helloFriend()
            {
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
        static void Main (string[] args)
        {
            Messages.helloFriend();
        }
    }
}