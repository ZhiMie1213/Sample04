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

double weight = 0;
bool weightOptionIsValid = false;
if ( args.Length > 0 ){
    string arg0 = args[ 0 ];
    weightOptionIsValid =  double.TryParse( arg0, out weight );
}

if ( !weightOptionIsValid )
{
    Console.WriteLine( "体重を入力してください(kg)" );
    weight = Function.WaitInputParseToDouble( );
}
Console.WriteLine("体重は" + weight.ToString("F2") + "です");

double height = 0;
bool heightOptionIsValid = false;
if( args.Length > 0 )
{
    string arg1 = args[ 0 ];
    heightOptionIsValid = double.TryParse( arg1, out height );
}

if(!heightOptionIsValid )
{
    Console.WriteLine("身長を入力してください(cm)");
    height = Function.WaitInputParseToDouble();
}
Console.WriteLine("身長は" + height.ToString("F2") + "です");

double tmi = weight / (height * height);
Console.WriteLine("BMIは" + tmi.ToString("F4") + "です");