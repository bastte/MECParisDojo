using Xunit;

namespace TradingCardGameKata
{
    public class ManaShould
    {
        private readonly ManaPool _manaPool = new ManaPool();

        [Fact]
        public void CapacityShouldNotGoFurtherThan10()
        {
            _manaPool.Add(42);
            Assert.Equal(10, _manaPool.Capacity);
        }

    }

    static class ManaPoolExtension
    {
        public static void Add(this ManaPool manaPool, int amount)
        {
            for (int i = 0; i < amount; ++i)
            {
                manaPool.Add();
            }
        }
    }
}
