

string[] MaxLengthElement (string[]Array, int dlina)
{

int count=0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length<dlina)
    count++;
}

string [] NewArray = new string [count];
int j=0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length<dlina)
    {
        NewArray[j]=Array[i];
       // System.Console.WriteLine($"{j}= {NewArray[j]}");
        j++;
    }
}
//System.Console.WriteLine(string.Join(",",NewArray));
return NewArray;
}
string [] ArrayInput = new string [] {"csharp", "123", "git", "Forest", "hi", "nine","bye","6=6", "6!=2"};
int dlina = 6;
string [] ArrayResult = MaxLengthElement(ArrayInput,dlina);
System.Console.WriteLine(string.Join(",",ArrayResult));