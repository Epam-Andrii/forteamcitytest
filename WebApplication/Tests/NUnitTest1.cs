using System;
using NSubstitute;
using NUnit.Framework;
using WebApplication.Controllers;

namespace Tests
{
	[TestFixture]
	public class NUnitTest1
	{

		private HomeController homeController;

		[Test]
		public void TestMethod1()
		{
			homeController = Substitute.For<HomeController>();

			var a = homeController.Test();

			Assert.AreEqual("test", a);
		}
	}
}