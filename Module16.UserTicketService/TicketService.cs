using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16.UserTicketService.Tests
{
    public class TicketService : ITicketService
    {

        public void AddTicket(Ticket ticket)
        {
            FakeDatabase.Add(ticket);
        }

        private void DeleteTicket(Ticket ticket)
        {
            FakeDatabase.Remove(ticket);
        }

        public int GetTicketPrice(int ticketId)
        {
            var ticket = FakeDatabase.FirstOrDefault(t => t.Id == ticketId);
            return (ticket is null) ?
               throw new TicketNotFoundException() : ticket.Price;
        }

        public Ticket GetTicket(int id)
        {
            var ticket = FakeDatabase.FirstOrDefault(t => t.Id == id);
            return (ticket is null) ?
              throw new TicketNotFoundException() : ticket;
        }

        public List<Ticket> GetAllTickets()
        {
            var allTickets = FakeDatabase;
            return (allTickets is null) ?
              throw new TicketNotFoundException() : allTickets;
        }

        private List<Ticket> FakeDatabase = new List<Ticket>
        {
            new Ticket(1, "Москва - Санкт-Петербург", 3500),
            new Ticket(2, "Челябинск - Магадан", 3500),
            new Ticket(3, "Норильск - Уфа", 3500)
        };

        //private IEnumerable<Ticket> FakeDatabase
        //{
        //    get
        //    {
        //        return new List<Ticket>
        //        {
        //            new Ticket(1, "Москва - Санкт-Петербург", 3500),
        //            new Ticket(2, "Челябинск - Магадан", 3500),
        //            new Ticket(3, "Норильск - Уфа", 3500)
        //        };
        //    }
        //}
    }
}
