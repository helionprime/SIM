/*
 * Created by SharpDevelop.
 * User: sim
 * Date: 2011-03-12
 * Time: 7:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace Nunit_example
{
	/// <summary>
	/// Description of RNum.
	/// </summary>
	public class RNum
	{
		public RNum()
		{
		}
		
		private UInt16 Chart2Num(Char InChar)
		{
			UInt16 RetVal = 0;
			
			switch (InChar) {
				case 'I': 
					RetVal = 1;
					break;
				case 'V': 
					RetVal = 5;
					break;
				case 'X': 
					RetVal = 10;
					break;
				case 'L': 
					RetVal = 50;
					break;
				case 'C': 
					RetVal = 100;
					break;
				case 'D': 
					RetVal = 500;
					break;
				case 'M': 
					RetVal = 1000;
					break;
				default:
					
					break;
			}
			return RetVal;
		}
		
		public int Convert(String RomanNumberStr)
		{
			RChar rcL = new RChar('L',  50, 4);
			RChar rcC = new RChar('C', 100, 5);
			
//			return Chart2Num(RomanNumberStr.Substring(1,1));
			return Chart2Num(RomanNumberStr[0]);
		}
	}
}
