using ServiceStack.ServiceInterface;
using ServiceStackJQueryMobileTutorial.Model;
using ServiceStackJQueryMobileTutorial.Repository;

namespace ServiceStackJQueryMobileTutorial.Service
{
    public class EventsService : RestServiceBase<Events>
    {
        private EventRepository repository;
        public EventsService()
        {
            repository = new EventRepository();
        }
        public EventsService(EventRepository repo)
        {
            repository = repo;
        }

        public override object OnGet(Events request)
        {
            var list = repository.GetEvents();
            var output = new EventsResponse
            {
                EventListings = list
            };

            return output;
        }
    }
}