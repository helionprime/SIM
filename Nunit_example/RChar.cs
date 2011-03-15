/*
 * Created by SharpDevelop.
 * User: sim
 * Date: 2011-03-14
 * Time: 9:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Nunit_example
{
	/// <summary>
	/// RChar = RomainChar class.
	/// </summary>
	public class RChar
	{
		public Char _c;

		public char C {
			get { return _c; }
			set { _c = value; }
		}
		
		public Int16 _Value;
		
		public short Value {
			get { return _Value; }
			set { _Value = value; }
		}
		
		public Int16 _Magnitudo;
		
		public short Magnitudo {
			get { return _Magnitudo; }
			set { _Magnitudo = value; }
		}
		
		public RChar()
		{
		}

		public RChar(Char C, Int16 Value, Int16 Magnitudo)
		{
			_c = C;
			_Value = Value;
			_Magnitudo = Magnitudo;
		}

		public void Init(Char C, Int16 Value, Int16 Magnitudo)
		{
			_c = C;
			_Value = Value;
			_Magnitudo = Magnitudo;
		}
	}
}
