namespace DependencyInversion.Utilities {
    public interface IDataAccess {
        void LoadData();
        void SaveDate(string name);
    }
}