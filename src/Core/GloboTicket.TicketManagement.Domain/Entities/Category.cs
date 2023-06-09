using GloboTicket.TicketManagement.Domain.Common;

namespace GloboTicket.TicketManagement.Domain.Entities {
	public class Category : AuditableEntity {
		public Guid CategoryId { get; set; }
		public String Name { get; set; } = string.Empty;
		public ICollection<Event>? Events  { get; set; }
	}
}
