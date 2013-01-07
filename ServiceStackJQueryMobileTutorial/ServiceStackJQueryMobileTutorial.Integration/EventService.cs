using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceStackJQueryMobileTutorial.Model;
using ServiceStackJQueryMobileTutorial.Service;

namespace ServiceStackJQueryMobileTutorial.Integration
{
    [TestClass]
    public class EventService
    {
        [TestMethod]
        public void CanIDownloadAListOfEvents()
        {
            var request = new Event();
            var target = new EventsService();
            var actual = target.OnGet(request);
            Assert.IsNotNull(actual);
        }
    }
}
