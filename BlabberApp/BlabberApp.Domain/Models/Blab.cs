using System;

namespace BlabberApp.Domain.Models {
    public class Blab : Model {
        public String Message { get; set; }
        public long UserId { get; set; }
    }
}