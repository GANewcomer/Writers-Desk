using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WritersDesk.Models.TaskItems;

namespace WritersDesk.ViewModels
{
    public class WritingTasksViewModel : BindableBase
    {

        public ObservableCollection<ITaskItem> Tasks { get; } = new ObservableCollection<ITaskItem>();

        private ITaskItem _newTask = new TaskItem("", "");

        public ITaskItem NewTask
        {
            get => this._newTask;
            set { SetProperty(ref this._newTask, value); }
        }

        public DelegateCommand AddTaskCommand { get; private set; }

        public WritingTasksViewModel()
        {
            Tasks.Add(new TaskItem("task1", "the first tasks man"));
            Tasks.Add(new TaskItem("task2", "the second tasks man"));
            Tasks.Add(new TaskItem("task3", "the third tasks man"));

            Tasks[0].SubTasks.Add(new TaskItem("subTask1", "the first subtask brohama"));
            Tasks[0].SubTasks.Add(new TaskItem("subTask2", "the second subtask brohama"));

            //Commands 
            AddTaskCommand = new DelegateCommand(AddTask);
        }

        public void AddTask()
        {
            Tasks.Add(NewTask);
            NewTask = new TaskItem("", "");
        }

    }
}
