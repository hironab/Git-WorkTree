Value x;
x = new Value();
x.value = 1;

Value y;
y = new Value();
y = x;

y.value = 10;

Console.WriteLine("xが参照するインスタンスのvalueの値" + x.value);
Console.WriteLine("yが参照するインスタンスのvalueの値" + y.value);



var v2 = 1.0;
Console.WriteLine(v2.GetType().Name);



int a2 = 5;
int b2 = 2;
int c2 = 1;

bool check2;

check2 = a2 > b2 | b2 > c2;
Console.WriteLine(check2);

check2 = b2 > a2 | b2 > c2;
Console.WriteLine(check2);

check2 = b2 > a2 | c2 > b2;
Console.WriteLine(check2);


int a3 = 5;
int b3 = 2;
bool check3;

check3 = !(a3 > b3);
Console.WriteLine(check3);

check3 = !(b3 > a3);
Console.WriteLine(check3);


int a4 = 5;
int b4 = 2;
int c4 = 1;
bool check4;

check4 = a4 > b4 ^ c4 > b4;
Console.WriteLine(check4);

check4 = b4 > a4 ^ b4 > c4;
Console.WriteLine(check4);

check4 = a4 > b4 ^ b4 > c4;
Console.WriteLine(check4);

check4 = b4 > a4 ^ c4 > b4;
Console.WriteLine(check4);




var str1 = "C#";
var str2 = "C++";

Console.WriteLine(str1);
Console.WriteLine(str2);

string str_1 = "Microsoft Visual C#";
var str_2 = "C#";
var str_3 = "C++";

Console.WriteLine(str_1.Contains(str_2));
Console.WriteLine(str_1.Contains(str_3));


string s1 = "Microsoft Visual C#";

var s2 = "Microsoft";
var s3 = "C++";

Console.WriteLine(s1.StartsWith(s2));
Console.WriteLine(s1.StartsWith(s3));





class Value
{
    public int value;
}