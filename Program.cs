using System;
using System.Collections.Generic;


class Program
    {
            static void Main(string[] args)
            {

                void MagicMoose() {


                    Console.WriteLine("Welcome to the Magic Moose Simulator!");
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine();

                    string Input = Console.ReadLine();
                    randomResponse(Input);

                }
                        
                        void randomResponse(string Input) {
                            
                            while (Input != "")

                            {
                                List<string> Response = new List<string>()
                                        {
                                            "As I see it, yes.", "Ask again later.", "Better not tell you now.", "Cannot predict now.", "Concentrate and ask again.", "Don't count on it.", "It is certain.", "It is decidedly so.", "Most likely.", "My reply is no.", "My sources say no.", "Outlook not so good.", "Outlook good.", "Reply hazy, try again.", "Signs point to yes.", "Very doubtful.", "Without a doubt.", "Yes.", "Yes – definitely.", "You may rely on it."
                                        };


                                    Random randResponse = new Random();

                                    MooseSays(Response[randResponse.Next(0, 19)]);
                                    Console.WriteLine("Ask me anything!");
                                    Input = Console.ReadLine();

                        }
                        
                        void MooseSays(string message)
                            {
                                Console.WriteLine($@"
                                                                _.--^^^--,
                                                                .'          `\
                            .-^^^^^^-.                      .'              |
                            /          '.                   /            .-._/
                            |             `.                |             |
                            \              \          .-._ |          _   \
                            `^^'-.         \_.-.     \   `          ( \__/
                                    |             )     '=.       .,   \
                                /             (         \     /  \  /
                                /`               `\        |   /    `'
                                '..-`\        _.-. `\ _.__/   .=.
                                    |  _    / \  '.-`    `-.'  /
                                    \_/ |  |   './ _     _  \.'
                                        '-'    | /       \ |
                                                |  .-. .-.  |
                                                \ / o| |o \ /
                                                |   / \   |    {message}
                                                / `^`   `^` \
                                                /             \
                                                | '._.'         \
                                                |  /             |
                                                \ |             |
                                                ||    _    _   /
                                                /|\  (_\  /_) /
                                                \ \'._  ` '_.'
                                                `^^` `^^^`
                                ");
                            }

                    MagicMoose();
                }
            }
    };