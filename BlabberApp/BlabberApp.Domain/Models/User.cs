using System;
using System.Collections.ObjectModel;

namespace BlabberApp.Domain.Models {
    public class User : Model {
        public String Username { get; set; }
        public String Email { get; set; }
        public Collection<Blab> Balbs { get; set; }
    }
}