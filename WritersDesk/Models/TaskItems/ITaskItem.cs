using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritersDesk.Models.TaskItems
{
    /// <summary>
    /// An interface for a Task item
    /// </summary>
    public interface ITaskItem
    {
        /// <summary>
        /// The name of this task
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The description of this task
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Whether this task is complete or not
        /// </summary>
        bool IsComplete { get; set; }

        /// <summary>
        /// This Task's collection of sub-tasks
        /// </summary>
        ObservableCollection<ITaskItem> SubTasks { get; }
    }
}
