using BookStore.Instructor;
using System;
using BookStore.Instructor.Models;

namespace BookStore.DanielStore
{
    public class DanielStore :IBookStoreService
    {
        public static IBookStoreService GetService()
        {
            throw new NotImplementedException();
        }

        public Guid AddAuthor(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public Guid AddBook(Guid authorId, string title, string ISBN, decimal price, BookShipmentEnum bookShipment)
        {
            throw new NotImplementedException();
        }

        public Guid AddCustomer(string firstName, string lastName, string street, string city, string state, string zip)
        {
            throw new NotImplementedException();
        }

        public Guid AddOrder(Guid customerId, Guid bookId)
        {
            throw new NotImplementedException();
        }

        public Author GetAuthor(Guid authorId)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(Guid bookId)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public int GetWarehouseBookQty(Guid bookId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerAddress(Guid customerId, string street, string city, string state, string zip)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderStatus(Guid orderId, OrderStatusEnum orderStatus)
        {
            throw new NotImplementedException();
        }

        public void UpdateWarehouseBookQty(Guid bookId, BookShipmentEnum bookShipment)
        {
            throw new NotImplementedException();
        }
    }
}
