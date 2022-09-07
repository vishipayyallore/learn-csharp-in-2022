using Loans.Domain.Applications;

namespace Loans.UnitTests
{
    public class LoanTermShould
    {
        [Fact]
        public void ReturnTermInMonths()
        {
            var sut = new LoanTerm(1);

            Assert.Equal(12, sut.ToMonths());
        }
    }
}