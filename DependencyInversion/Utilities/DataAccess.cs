using System;

namespace DependencyInversion.Utilities {
    public class DataAccess : IDataAccess {
        public void LoadData() {
            Console.WriteLine("Loading Data");
        }

        public void SaveDate(string name) {
            Console.WriteLine($"Saving {name}");
        }
    }
}