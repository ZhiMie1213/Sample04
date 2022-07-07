using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S04
{
    internal class Function
    {
        public static int Square( int value)
        {
            int result = value * value;
            return result;
        }

        public static int Cube( int value )
        {
            int result = value * value * value;
            return result;
        }
        public static long Power( long value, long power )
        {
            long result = 1;
            for (int i = 0; i < power; i++)
            {
                result = value * value;
            }
            return result;
        }

        public static double WaitInputParseToDouble( )
        {
            double result = 0;
            bool parseSuccess = false;

            while ( !parseSuccess )
            {
                string userWeight = Console.ReadLine() ?? "";
                parseSuccess = double.TryParse( Console.ReadLine(), out result);

                if ( !parseSuccess )
                    Console.WriteLine( "数値を入力してください" );
            }
                return result;
        }

        //ハンズオン04の関数
        public static double ParseArgsAndWaitInputIfParseFailed( string[ ] argumeats, int argumetIndes ){
            double result = 0;
            bool weightOptionIsValid = false;

            if ( argumeats.Length > 0 ){
                string args = argumeats[ 0 ];
                weightOptionIsValid = double.TryParse( args, out result );
            }
            if ( !weightOptionIsValid ){
                //Console.WriteLine( askText );
                result = WaitInputParseToDouble( );
            }
            return result;
        }

        //ハンズオン05の関数
        public static void NormalSample( int value ){
            value += 1;
        }
        public static void RefSample( ref int value ){
            value += 1;
        }

        //ハンズオン06の関数
        public static ( double, double, double ) GetVectorMagnitudeAndNormalized( double x, double y ){
            double magnitude = Math.Sqrt( x * x + y * y );
            
            return ( magnitude, x / magnitude, y / magnitude );
        }
    }
}
