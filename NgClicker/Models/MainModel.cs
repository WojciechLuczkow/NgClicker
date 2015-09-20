namespace NgClicker.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Model for the MainWindow
    /// </summary>
    public class MainModel
    {
        private static readonly string MODESNAMESPACE = "NgClicker.Views.Modes";

        public MainModel()
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            this.AvailableModes = currentAssembly.GetTypes()
                                      .Where(t => t.Namespace == MODESNAMESPACE)
                                      .Select(t => t.Name);
        }

        public IEnumerable<string> AvailableModes { get; set; }
    }
}
