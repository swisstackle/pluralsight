using GloboTicket.TicketManagement.Domain.Common;

namespace GloboTicket.TicketManagement.Domain.Entities {
	public class Event : AuditableEntity {
		public Guid EventId { get; set; }
		public string name { get; set; } = string.Empty;
		public int Price { get; set; }
		public string? Artist { get; set; }
		public DateTime date { get; set; }
		public string? Description { get; set; }
		public string? ImageUrl { get; set; }
		public Guid CategoryId { get; set; }
		public Category Category { get; set; } = default;
	}
}
