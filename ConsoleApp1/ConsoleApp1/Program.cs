using S04;

//ハンズオン01
//int a = 10;
//int b = S04.Function.Square( a );
//Console.WriteLine( b );

//int a = 3; long b = 20;
//int c = Function.Power( a, b );
//int d = Function.Power( a, 5 );
//Console.WriteLine( d );

//ハンズオン02
/*
Console.WriteLine( "体重を入力してください(kg)" );
double weight = Function.WaitInputParseToDouble( );
Console.WriteLine( "体重は" + weight.ToString( "F2" ) + "です" );

Console.WriteLine( "身長を入力してください(cm)" );
double height = Function.WaitInputParseToDouble( );
Console.WriteLine( "身長は" + height.ToString( "F2" ) + "です" );

const tmi = weight / ( height * height );
Console.WriteLine( "BMIは" + tmi.ToString( "F4" ) + "です" );
*/

for ( int i = 0; i < args.Length; i++ ){
    Console.WriteLine( "オプション" + i + ":" + args[ i ] ); 
}

//ハンズオン04
/*
double weight = Function.ParseArgsAndWaitInputIfParseFailed( args, 0 );
Console.WriteLine( "体重は" + weight.ToString( "F2" ) + "です" );

double height = 0;
bool heightOptionIsValid = false;
if( args.Length > 0 )
{
    string arg1 = args[ 0 ];
    heightOptionIsValid = double.TryParse( arg1, out height );
}

if( !heightOptionIsValid )
{
    Console.WriteLine( "身長を入力してください(cm)" );
    height = Function.WaitInputParseToDouble();
}
Console.WriteLine( "身長は" + height.ToString("F2") + "です" );

double bmi = weight / (height * height);
Console.WriteLine( "BMIは" + bmi.ToString("F4") + "です" );
*/

//ハンズオン05
/*
int value05 = 10;

Console.WriteLine( "normal before:" + value05 );
Function.NormalSample( value05 );
Console.WriteLine( "normal after:" + value05 );

value05 = 10;
Console.WriteLine( "ref before" + value05 );
Function.RefSample( ref value05 );
Console.WriteLine( "ref after" + value05 );
*/

//ハンズオン06
/*
double x = 1.65;
double y = 5.786;

( double magnitude, double normalizedX, double normalizedY  ) = Function.GetVectorMagnitudeAndNormalized( x, y );

Console.WriteLine( "絶対値" + magnitude );
Console.WriteLine( "正規化ベクトル x" + normalizedX );
Console.WriteLine( "正規化ベクトル y" + normalizedY );
*/

//ハンズオン07
/*
string output = "";
long temp1 = 1;
long temp2 = 1;
output = "1:" + temp1 + "\r\n";
output = "2:" + temp2 + "\r\n";

for ( int i = 0; i <= 50; i++ ){
    long next = temp1 + temp2;
    output += i.ToString( ) + ":" + next + "\r\n";
    temp1 = temp2;
    temp2 = next;
}

System.IO.File.WriteAllText( "C:\\output.txt", output );
*/

//ハンズオン08

System.Net.WebClient wc = new System.Net.WebClient( );

for ( int i = 1; i <= 16; i++ ){
    string numberText = i.ToString( "03" );

    wc.DownloadFile( "http://com-extra.jp/web_extra/2018/manga/0201/" + numberText + ".jpg", @"C:Users\student\Desktop\CSharp" + numberText + ".jpg" );
}

wc.Dispose( );
Console.WriteLine( "ダウンロード完了" );