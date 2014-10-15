using NUnit.Framework;
using FluentAssertions;

namespace FluentAssertionsShouldShouldBe
{
	internal class MistakesTests
	{
		[Test]
		public void ThisDumbThingIKeepDoing()
		{
			var thing = new Thing { FirstName = "Nelson" };
			var thing2 = new Thing { FirstName = "Nelson" };

			// This should definitely pass, right?
			thing.Should().ShouldBeEquivalentTo(thing2);
		}

		private class Thing
		{
			public string FirstName { get; set; }
		}
	}
}
