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
            var request = new Events();
            var target = new EventsService();
            var actual = target.OnGet(request);
            Assert.IsNotNull(actual);
        }
    }
}
