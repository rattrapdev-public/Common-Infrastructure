using NUnit.Framework;
using Shouldly;

namespace RattrapDev.Common.Tests
{
	[TestFixture]
	public class MaybeExtensionsTests
	{
		[Test]
		public void Do_executes_action_with_some_value()
		{
			var modifiedValue = "default";

			var some = Maybe<string>.Some("found value");

			some.Do<string>((value) =>
			{
				modifiedValue = value;
			});

			modifiedValue.ShouldBe("found value");
		}

		public void ModifyString()
		{
			var modifiedValue = "default";

			var some = Maybe<string>.None();

			some.Do<string>((value) =>
			{
				modifiedValue = value;
			});

			modifiedValue.ShouldBe("default");
		}
	}
}
