using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cover2Cover.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasAMembership { get; set; }
        public MembershipType Membership { get; set; }
        public int MembershipId { get; set; }
        public List<int> PurchasedBooks { get; set; }
        public List<int> FavouriteBooks { get; set; }
        public List<int> FavouriteAuthors { get; set; }

    }
}