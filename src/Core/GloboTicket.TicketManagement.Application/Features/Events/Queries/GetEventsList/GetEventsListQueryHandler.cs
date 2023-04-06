using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using AutoMapper;

namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsList {
	public class GetEventsListQueryHandler : IRequestHandler<GetEventsListQuery, List<EventListVm>> {
		private readonly IEventRepository _eventRepository;
		private readonly IMapper _mapper;
		public GetEventsListQueryHandler(IMapper mapper, IEventRepository eventRepository){
			_mapper = mapper;
			_eventRepository = eventRepository;
		}	
		// Lists all Events ordered by date and maps them in the mapper.
		public async Task<List<EventListVm>> Handle(GetEventsListQuery request, CancellationToken cancellationToken) {
			var allEvents = (await _eventRepository.ListAllAsync()).OrderBy( x => x.Date);
			return _mapper.Map<List<EventListVm>>(allEvents);
		}
	}
}
