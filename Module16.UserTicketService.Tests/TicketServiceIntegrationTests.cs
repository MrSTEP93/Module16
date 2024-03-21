using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Module16.UserTicketService.Tests
{
    [TestFixture]
    public class TicketServiceIntegrationTests
    {
        //[TestMethod]
        [Test]
        public void SaveTicketMustAddTicketInBase()
        {
            var ticketServiceTest = new TicketService();
            var newTicket = new Ticket(300, "Test ticket", 1000);

            ticketServiceTest.AddTicket(newTicket);

            var allTicketsAfterAddingNewTicket = ticketServiceTest.GetAllTickets();
            NUnit.Framework.CollectionAssert.Contains(allTicketsAfterAddingNewTicket, newTicket);

            //PrivateObject obj = new PrivateObject(ticketServiceTest);

            var privateMethod = typeof(TicketService).
                GetMethod("DeleteTicket", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            privateMethod.Invoke(ticketServiceTest, new object?[] { newTicket });

            var allTicketsAfterDeletingNewTicket = ticketServiceTest.GetAllTickets();
            NUnit.Framework.CollectionAssert.DoesNotContain(allTicketsAfterDeletingNewTicket, newTicket);
        }
    }
}
