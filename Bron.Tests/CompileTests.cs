using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace Bron.Tests
{
    public class CompileTests
    {
        [Fact]
        public void Running_Compile_Generates_Output()
        {
            Program.Main(new []{"v", ""});
        }
    }
}
