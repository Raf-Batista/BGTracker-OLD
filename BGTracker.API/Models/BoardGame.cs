using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGTracker.API.Models
{
    public class BoardGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPlayers { get; set; }
        public bool WishList { get; set; } // If true this BoardGame is on the user's wishlist, otherwise the user owns it
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
