using System.Collections.Generic;
using BlabberApp.Domain.Models;

namespace BlabberApp.Domain.Interfaces {
    public interface IRepository {
        T Add<T>(T item) where T : BaseDatum;
        void Delete<T>(T item) where T : BaseDatum;
        List<T> GetAll<T>(ISpecification<T> spec = null) where T : BaseDatum;
        T GetById<T>(string sysId) where T : BaseDatum;
        void Update<T>(T item) where T : BaseDatum;
    }
}