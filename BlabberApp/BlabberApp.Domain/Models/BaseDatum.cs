using System;
using BlabberApp.Domain.Interfaces;

namespace BlabberApp.Domain.Models {
    public class BaseDatum : IDatum {
        private string _SysId;
        public BaseDatum() {
            this._SysId = Guid.NewGuid().ToString();
        }
        public string getSysId() {
            return this._SysId;
        }
    }
}