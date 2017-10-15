using Xunit;
using PrimeServices;

namespace Prime.UnitTests.Services {
	public class PrimeServiceIsPrimeShould {
		private readonly PrimeService primeService;

		public PrimeServiceIsPrimeShould() {
			primeService = new PrimeService();
		}

		[Fact]
		public void ReturnFalseGivenValueOf1() {
			var result = primeService.isPrime(1);

			Assert.False(result, "1 shoulk not be prime");
		}
	}
}
