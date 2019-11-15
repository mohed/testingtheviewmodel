using Xunit;

namespace testingtheviewmodel.UITests.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
        }
        
        [Fact]
        public void ShouldReturnTrue()
        {
            Assert.True(true);
        }
    }
}