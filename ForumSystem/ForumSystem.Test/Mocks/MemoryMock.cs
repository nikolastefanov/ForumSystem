



namespace ForumSystem.Test.Mocks
{
    using Microsoft.Extensions.Caching.Memory;
    using Moq;

    public static class MemoryMock
    {
        public static IMemoryCache Instance
        {
            get
            {
                var iMemoryCacheMock = new Mock<IMemoryCache>();

                return iMemoryCacheMock.Object;
            }

        }

    }
}
