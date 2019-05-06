using System;
using System.Collections.Generic;

namespace _02._Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();

            while (true)
            {
                string[] line = Console.ReadLine().Split();
                string command = line[0];
                if (command == "end")
                {
                    break;
                }
                else if (command == "Chat")
                {
                    string message = line[1];
                    chat.Add(message);
                }
                else if (command == "Delete")
                {
                    string messageToDelete = line[1];
                    if (chat.Contains(messageToDelete))
                    {
                        chat.Remove(messageToDelete);
                    }
                }
                else if (command == "Edit")
                {
                    string messageToEdit = line[1];
                    int index = chat.IndexOf(messageToEdit);
                    string editedVersion = line[2];
                    if (chat.Contains(messageToEdit))
                    {
                        chat[index] = editedVersion;
                    }
                }
                else if (command == "Pin")
                {
                    string message = line[1];
                    if (chat.Contains(message))
                    {
                        chat.Remove(message);
                        chat.Add(message);
                    }
                }
                else if (command == "Spam")
                {
                    for (int i = 1; i < line.Length; i++)
                    {
                        chat.Add(line[i]);
                    }
                }
            }
            foreach (var chats in chat)
            {
                Console.WriteLine(chats);
            }
        }
    }
}
