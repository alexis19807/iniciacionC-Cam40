string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

PrintCorportateEmail(corporate);
PrintExternalEmail(external, externalDomain);

void PrintCorportateEmail(string[,] corporate, string domain = "contoso.com") 
{
    string[] emailCorporateAddresses = new string[corporate.GetLength(0)];
    for (int i = 0; i < corporate.GetLength(0); i++)
    {
        for (int j = 0; j < corporate.GetLength(1); j++)
        {
            // display internal email addresses
            string firstName = corporate[i, 0];
            string lastName = corporate[i, 1];
            string email = $"{firstName.ToLower()[..2]}{lastName.ToLower()}@{domain}";
            emailCorporateAddresses[i] = email;
        }
        Console.WriteLine(emailCorporateAddresses[i]);
    }
}

void PrintExternalEmail(string[,] external, string domain = "contoso.com")
{
    string[] emailExternalAddresses = new string[external.GetLength(0)];
    for (int i = 0; i < external.GetLength(0); i++)
    {
        for (int j = 0; j < external.GetLength(1); j++)
        {
            // display internal email addresses
            string firstName = external[i, 0];
            string lastName = external[i, 1];
            string email = $"{firstName.ToLower()[..2]}{lastName.ToLower()}@{domain}";
            emailExternalAddresses[i] = email;
        }
        Console.WriteLine(emailExternalAddresses[i]);
    }
}

/*
robavin@contoso.com
sibright@contoso.com
kisinclair@contoso.com
aakamath@contoso.com
sadelucchi@contoso.com
siali@contoso.com
viashton@hayworth.com
codysart@hayworth.com
shlawrence@hayworth.com
davaldes@hayworth.com
*/