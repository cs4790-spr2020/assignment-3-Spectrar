using System;
using System.Collections.Generic;
using BlabberApp.Domain.Interfaces;

namespace BlabberApp.DataStore {
    public class InMemory : IDataStore {
        private List<IDatum> items = new List<IDatum>();
        public bool Create(IDatum datum) {
            this.items.Add(datum);

            if (items.Count < 0) {
                throw new ArgumentOutOfRangeException("Can't contain negitive objects");
            }

            return true;
        }
        public IDatum Read(int id) {
            IDatum result;
            try {
                result = this.items[id];
            } catch (ArgumentOutOfRangeException) {
                result = null;
            }
            return result;
        }
        public bool Update(IDatum initial, IDatum changed) {
            this.items[this.items.IndexOf(initial)] = changed;
            return true;
        }
        public bool Delete(IDatum datum) {
            bool result = false;
            try {
                result = this.items.Remove(datum);
            } catch (ArgumentOutOfRangeException e) {
                throw e;
            }
            return result;
        }
    }
}