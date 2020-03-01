using System;
using System.Collections.Generic;

namespace PokedexPersistance.Entities
{
    public partial class Users
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
