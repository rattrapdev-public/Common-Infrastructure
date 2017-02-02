using System.Linq;
using NUnit.Framework;
using Shouldly;

namespace RattrapDev.Common.Tests
{
	[TestFixture]
	public class MaybeTests
	{
		[Test]
		public void None_has_no_value()
		{
			var empty = Maybe<object>.None();

			empty.Any().ShouldBeFalse();
		}

		[Test]
		public void Some_has_a_object()
		{
			var some = Maybe<object>.Some(new object());

			some.Any().ShouldBeTrue();
		}
	}
}
