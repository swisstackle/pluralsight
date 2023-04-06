using GloboTicket.TicketManagement.Application.Features.Events;
using GloboTicket.TicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using AutoMapper;

namespace GloboTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent {
	public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Guid> {
		private readonly IEventRepository _eventRepository;
		private readonly IMapper _mapper;

		public CreateEventCommandHandler(IMapper mapper, IEventRepository eventRepository) {
			_mapper = mapper;
			_eventRepository = eventRepository;
		}
		public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken) {
			var @event = _mapper.Map<Event>(request);
			@event = await _eventRepository.AddAsync(@event);
			return @event.EventId;
		}
	}
}
