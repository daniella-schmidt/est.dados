Stack<string> passwords = new Stack<string>();
const string chars = "abcde123456789";
Random random = new Random();

for (int i = 0; i < 10; i++)
{
    string password = GeneratePassword(4); 
    passwords.Push(password);
    Console.WriteLine(password);
}

foreach (string password in passwords)
{
    Console.WriteLine(password);
}

string GeneratePassword(int length)
{
    string password = "";
    for (int j = 0; j < length; j++)
    {
        password += chars[random.Next(0, chars.Length)];
    }
    return password;
}