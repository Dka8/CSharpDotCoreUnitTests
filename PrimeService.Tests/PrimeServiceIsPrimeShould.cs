using Xunit;
using PrimeServices;

namespace Prime.UnitTests.Services {
	public class PrimeServiceIsPrimeShould {
		private readonly PrimeService primeService;

		public PrimeServiceIsPrimeShould() {
			primeService = new PrimeService();
		}

		[Theory]
		[InlineData(-1)]
		[InlineData(0)]
		[InlineData(1)]
		public void ReturnFalseGivenValuesLessThan2(int value) {
			var result = primeService.isPrime(value);

			Assert.False(result, $"{value} shoulh not be prime");
		}
	}
}
