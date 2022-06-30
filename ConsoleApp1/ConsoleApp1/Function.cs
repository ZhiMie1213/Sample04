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
        public static int Power( long value, long power )
        {
            long result = 1;
            for (int i = 0; i < value; i++)
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
    }
}
