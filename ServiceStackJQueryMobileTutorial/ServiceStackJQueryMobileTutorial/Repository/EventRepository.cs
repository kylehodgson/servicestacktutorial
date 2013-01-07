using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStackJQueryMobileTutorial.Model;

namespace ServiceStackJQueryMobileTutorial.Repository
{
    public enum EventRepositoryResponse
    {
        Success,
        DateAlreadyPresent
    }

    public class EventRepository
    {
        private List<Event> _repo;
        public EventRepository()
        {
            _repo = new List<Event>();
            InitializeTestData();
        }

        public EventRepository(object repo)
        {
            _repo = repo as List<Event>;
        }

        internal List<Event> GetEvents()
        {
            return _repo;
        }

        internal Event GetEvent(string subject)
        {
            return (_repo.Where(e => e.Subject.ToLower() == subject.ToLower())).FirstOrDefault();
        }

        internal EventRepositoryResponse SaveEvent(Event eve)
        {
            var count = (from e in _repo where e.EventStart == eve.EventStart select e).Count();
            if (count > 0) return EventRepositoryResponse.DateAlreadyPresent;
            _repo.Add(eve);
            return EventRepositoryResponse.Success;
        }

        internal int GetCountOfEvents()
        {
            return GetCountOfEvents(null);
        }

        internal int GetCountOfEvents(string searchTerm)
        {
            if (searchTerm == null) return _repo.Count;
            return _repo.Count(e => (e.Subject.Contains(searchTerm)));
        }

        internal void InitializeTestData()
        {
            int recordsToMake = 20;
            for (int i = 1; i < recordsToMake; i++)
            {
                _repo.Add(
                    new Event
                    {
                        EventStart = new DateTime(2012, 4, i),
                        Speaker = "Atley Hunter",
                        Subject = "WP7 Programming"
                    });
            }
        }
    }
}