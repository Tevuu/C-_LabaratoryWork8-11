/* >> 8 zadanie (bibip)
string word = "Heyrydyeyfdgfd";
int counter = 0;

for (int i = 0; i < word.Length; i += 2)
{
    if (word[i] == 'y')
    {
        counter++;
    }
}

Console.WriteLine("Количество букв 'y' на чётных местах равно: " + counter);*/

///////////////////////////////////////////////////////////////////////////// /// ( hi-hati postavil xd)

// >> 9 Zadanie ( AAaaaAAA)
/*string word = "hello big bukva da?";
string updword = word.Replace('a', 'A');
Console.WriteLine(updword) ;*/

/////////////////////////////////////////////////////////////////////////////

// >> > 3adanie 10 =((
/*string word = "ooog";
int counter0 = 0; 
int counter1 = 0;

for (int i = 0;i < word.Length; i++)
{
    if (word[0] == word[i]) 
    {  
        counter0++; 
    }
    if (word[word.Length-1] == word[i]) 
    { 
        counter1++;
    }

}
if (counter0 > counter1)
{
    Console.WriteLine("1 Bukva chase:" + counter0 + " pa3a");
}
else if (counter1 > counter0) {
    Console.WriteLine("Last bukva chase:" + counter1 + " Pa3a");
}
else
{
    Console.WriteLine("oshibka, kol-vo odinakovo");
        }*/
///////////////////////////////////////////////////////////////////////////


//// >> Zadanie 11 (so hard)
/*string TransformString(string s)
{
    int dotIndex = s.IndexOf('.');
    string prefix = s.Substring(0, dotIndex);
    string suffix = s.Substring(dotIndex);
    prefix = prefix.Replace(",", "");
    if (suffix.Length > 3)
    {
        suffix = suffix.Substring(0, 3) + suffix.Substring(3).Replace("3", "+");
    }

    return prefix + suffix;
}
string s = "Hello, world. My name is 30034.";
string transformed = TransformString(s);
Console.WriteLine(transformed);*/
