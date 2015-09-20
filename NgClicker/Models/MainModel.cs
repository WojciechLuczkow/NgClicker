using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NgClicker.Models
{
    /// <summary>
    /// Model for the MainWindow
    /// </summary>
    public class MainModel
    {
        private static readonly string MODES_NAMESPACE = "NgClicker.Views.Modes";

        public IEnumerable<string> AvailableModes { get; set; }

        public MainModel()
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            this.AvailableModes = currentAssembly.GetTypes().
                                      Where(t => t.Namespace == MODES_NAMESPACE)
                                      .Select(t => t.Name);
        }
    }
}
