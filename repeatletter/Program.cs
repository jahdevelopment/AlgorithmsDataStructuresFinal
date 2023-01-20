

using System.Globalization;


Console.WriteLine("=================== COMPRESSOR MACHINE =====================");
// RTFFFFYYUPPPEEEUU
// RTF4Y2UP3E3U2

Console.WriteLine("Please enter a string of characters, no spaces or punctuation signs");

string strInput = Console.ReadLine().ToUpper();

string compressed = "";

int count = 1;

char lastChar = strInput[0];

///// COMPRESSS

for(int i = 1; i < strInput.Length; i++)
{
    if (strInput[i] == strInput[i-1])
    {
        count++;
    }
    else
    {
        if (count > 1)
        {
            compressed += strInput[i - 1] + count.ToString();
        }
        else
        {
            compressed += strInput[i - 1];
        }
        count = 1;
    }
}

if (count > 1)
{
    compressed += strInput[strInput.Length - 1] + count.ToString();
}
else
{
    compressed += strInput[strInput.Length - 1];
}

Console.WriteLine($"\nCompressed string: { compressed}");


//////// DECOMPRESS

string decompress = "";

for (int i = 0; i < compressed.Length; i++)
{
    if (Char.IsDigit(compressed[i]))
    {
        int counter = int.Parse(compressed[i].ToString());
        for (int j = 0; j < counter; j++)
        {
            decompress += compressed[i - 1];
        }
    }
    else
    {
        decompress += compressed[i];
    }
}

Console.WriteLine($"\ndecompressed string: {decompress}");

