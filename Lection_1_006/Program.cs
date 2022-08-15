Console.Write("Vvedite imia polzovatelia: ");
string username = Console.ReadLine();

if  (username.ToLower() == "maria") {
       Console.WriteLine("Ura, eto zhe Maria!");
}
else {
    Console.WriteLine("Privetstvuem Vas, " + username);
}