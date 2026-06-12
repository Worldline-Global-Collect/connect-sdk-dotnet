using System.Collections.Generic;
using NUnit.Framework;

namespace Worldline.Connect.Sdk.Communication
{
    [TestFixture]
    public class ResponseHeaderUtilsTest
    {
        [TestCase("attachment; filename=testfile", "testfile")]
        [TestCase("attachment; filename=\"testfile\"", "testfile")]
        [TestCase("attachment; filename=\"testfile", "\"testfile")]
        [TestCase("attachment; filename=testfile\"", "testfile\"")]
        [TestCase("attachment; filename='testfile'", "testfile")]
        [TestCase("attachment; filename='testfile", "'testfile")]
        [TestCase("attachment; filename=testfile'", "testfile'")]
        [TestCase("filename=testfile", "testfile")]
        [TestCase("filename=\"testfile\"", "testfile")]
        [TestCase("filename=\"testfile", "\"testfile")]
        [TestCase("filename=testfile\"", "testfile\"")]
        [TestCase("filename='testfile'", "testfile")]
        [TestCase("filename='testfile", "'testfile")]
        [TestCase("filename=testfile'", "testfile'")]
        [TestCase("attachment; filename=testfile; x=y", "testfile")]
        [TestCase("attachment; filename=\"testfile\"; x=y", "testfile")]
        [TestCase("attachment; filename=\"testfile; x=y", "\"testfile")]
        [TestCase("attachment; filename=testfile\"; x=y", "testfile\"")]
        [TestCase("attachment; filename='testfile'; x=y", "testfile")]
        [TestCase("attachment; filename='testfile; x=y", "'testfile")]
        [TestCase("attachment; filename=testfile'; x=y", "testfile'")]
        [TestCase("attachment", null)]
        [TestCase("filename=\"", "\"")]
        [TestCase("filename='", "'")]
        public void TestGetDispositionFilename(string headerValue, string expectedFilename)
        {
            var headers = new List<ResponseHeader>
            {
                new ResponseHeader("Content-Disposition", headerValue)
            };
            Assert.That(headers.GetDispositionFilename(), Is.EqualTo(expectedFilename));
        }
    }
}
