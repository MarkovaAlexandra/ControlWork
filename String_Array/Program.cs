string [] Array = new string [] {"csharp", "123", "git", "Forest", "hi", "nine","bye","6=6", "6!=2"};

int count=0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length<4)
    count++;
}

string [] NewArray = new string [count];
int j=0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length<4)
    {
        NewArray[j]=Array[i];
        System.Console.WriteLine($"{j}= {NewArray[j]}");
        j++;
    }
}
System.Console.WriteLine(string.Join(",",NewArray));