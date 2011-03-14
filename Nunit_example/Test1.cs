/*
 * Created by SharpDevelop.
 * User: sim
 * Date: 2011-03-09
 * Time: 10:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;
//using NUnit;

namespace Nunit_example
{
	[TestFixture]
	public class Test1
	{
		[Test]
		public void TestMethod()
		{
			// TODO: Add your test.
			//Assert(
		}
		
		[Test]
		public void TestAdd()
		{
			// TODO: Add your test.
			MainForm MF = new MainForm();
			
			Assert.AreEqual(5, MF.Add(3, 2), "not EQ");
			//Assert.
		}
	}
}
