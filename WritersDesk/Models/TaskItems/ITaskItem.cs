using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritersDesk.Models.TaskItems
{
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

    }
}
