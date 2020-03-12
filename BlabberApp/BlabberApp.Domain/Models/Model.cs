using System;

namespace BlabberApp.Domain.Models {
    public class Model : BaseDatum {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public long? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
