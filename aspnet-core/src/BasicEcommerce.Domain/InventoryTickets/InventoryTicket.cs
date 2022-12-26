﻿using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace BasicEcommerce.InventoryTickets
{
    public class InventoryTicket : AuditedAggregateRoot<Guid>
    {
        public string Code { get; set; }
        public TicketType TicketType { get; set; }
        public bool IsApproved { get; set; }
        public Guid? ApprovedId { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }
}
