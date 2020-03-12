namespace BlabberApp.Domain.Interfaces {
    public interface IDataStore {
        bool Create(IDatum datum);
        IDatum Read(int id);
        bool Update(IDatum initial, IDatum changed);
        bool Delete(IDatum id);
    }
}
