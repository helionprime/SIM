/*
 * Created by SharpDevelop.
 * User: sim
 * Date: 2011-03-12
 * Time: 7:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace Nunit_example
{
	[TestFixture]
	public class TestRNum
	{
		
		[Test]
		public void TestRNum01ConvSimple()
		{
			RNum TRN = new RNum();
			
			Assert.AreEqual(   1, TRN.Convert("I"));
			Assert.AreEqual(   5, TRN.Convert("V"));
			Assert.AreEqual(  10, TRN.Convert("X"));
			Assert.AreEqual(  50, TRN.Convert("L"));
			Assert.AreEqual( 100, TRN.Convert("C"));
			Assert.AreEqual( 500, TRN.Convert("D"));
			Assert.AreEqual(1000, TRN.Convert("M"));
		}
		
		[Test]
		public void TestRNum02ConvMultiple()
		{
			RNum TRN = new RNum();
			
			Assert.AreEqual(   2, TRN.Convert("II"));
			Assert.AreEqual(   3, TRN.Convert("III"));
			Assert.AreEqual(  20, TRN.Convert("XX"));
			Assert.AreEqual(  30, TRN.Convert("XXX"));
			Assert.AreEqual( 200, TRN.Convert("CC"));
			Assert.AreEqual( 300, TRN.Convert("CCC"));
			Assert.AreEqual(2000, TRN.Convert("MM"));
			Assert.AreEqual(3000, TRN.Convert("MMM"));
		}
		
		[Test]
		public void TestRNum99ConvError()
		{
			RNum TRN = new RNum();
			
			// TODO: add error cases
			Assert.AreEqual(   2, TRN.Convert("II"));
			
		}
		
		
	}
}
