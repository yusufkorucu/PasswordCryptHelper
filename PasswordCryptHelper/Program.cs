using PasswordCryptHelper.Helpers;

Console.Write("Enter a password: ");

string passwordInput = Console.ReadLine();

string response = Helper.Hash(passwordInput);

string password = "123";

var verificationResult = Helper.Validate(password:password,passwordHash:response);

Console.WriteLine(verificationResult.ToString());