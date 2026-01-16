using OnlineBookstore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineBookstore.Infrastructure.Services
{
    public class CartService
    {
        public class CartEntry
        {
            public OrderItem Item { get; set; } = new();
            public string SelectedFormat { get; set; } = string.Empty;
        }

        public List<CartEntry> CartEntries { get; private set; } = new();

        // The "Bell" that notifies the UI to refresh
        public event Action? OnCartChanged;

        public void AddToCart(Book book, string format)
        {
            var existing = CartEntries.FirstOrDefault(c => c.Item.BookId == book.Id && c.SelectedFormat == format);

            if (existing != null)
            {
                existing.Item.Quantity++;
            }
            else
            {
                CartEntries.Add(new CartEntry
                {
                    SelectedFormat = format,
                    Item = new OrderItem
                    {
                        BookId = book.Id,
                        Book = book,
                        Quantity = 1
                    }
                });
            }

            // Notify listeners (like NavMenu and Cart page)
            NotifyStateChanged();
        }

        public void RemoveFromCart(int bookId, string format)
        {
            var entry = CartEntries.FirstOrDefault(c => c.Item.BookId == bookId && c.SelectedFormat == format);
            if (entry != null)
            {
                CartEntries.Remove(entry);
                NotifyStateChanged();
            }
        }

        public void ClearCart()
        {
            CartEntries.Clear();
            NotifyStateChanged();
        }

        public decimal GetTotal()
        {
            return (decimal)CartEntries.Sum(c =>
            {
                double unitPrice = c.SelectedFormat == "Physical"
                    ? (c.Item.Book?.PricePhysical ?? 0)
                    : (c.Item.Book?.PriceSoftcopy ?? 0);

                return unitPrice * c.Item.Quantity;
            });
        }

        public int GetCount() => CartEntries.Sum(c => c.Item.Quantity);

        // Helper to trigger the refresh event
        private void NotifyStateChanged() => OnCartChanged?.Invoke();
    }
}