using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritersDesk.Models.TaskItems
{
    public class TaskItem : ITaskItem
    {
        /// <inheritdoc/>
        public string Name { get; set; }
        /// <inheritdoc/>
        public string Description { get; set; }
        /// <inheritdoc/>
        public bool IsComplete { get; set; } = false;

        /// <inheritdoc/>
        public ObservableCollection<ITaskItem> SubTasks { get; } = new ObservableCollection<ITaskItem>();


        public TaskItem(string name, string description)
        {
            Name = name;
            Description = description;
        }

    }
}
