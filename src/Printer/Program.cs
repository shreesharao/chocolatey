var print = true;
Console.CancelKeyPress += (s, e) => { Console.WriteLine("Received cancel request"); print = false; };
while (print)
{
    Console.WriteLine("Enter Msg..");
    var input = Console.ReadLine();
    Console.WriteLine("Msg: {0}", input);
}
