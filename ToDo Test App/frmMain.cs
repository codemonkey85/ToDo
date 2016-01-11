using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ToDo;

namespace ToDo_Test_App
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private const string FolderPath = @"C:\Users\mbond\Desktop\ToDo Test\{0}.txt";

        private void btnTestSerialize_Click(object sender, EventArgs e)
        {
            var account = new Account
            {
                Inbox = new List<Task> { new Task { Title = "Inbox Task 1" } },
                Projects = new List<Project>(),
                SmartLists = null
            };
            account.Projects.Add(new Project { Name = "Project 1", Tasks = new List<Task> { new Task { Title = "Project Task 1", StartDate = DateTime.Today, Reminders = new List<Reminder> { new Reminder { DateTime = DateTime.Today + TimeSpan.FromHours(1) } }, Tags = new List<Tag>() { new Tag() { Name = "Test" } } } } });
            using (var fs = new FileStream(string.Format(FolderPath, typeof(Account)).Replace("ToDo.", ""), FileMode.Create, FileAccess.Write))
            {
                FileIO.SaveToFile(fs, account);
                fs.Close();
            }
            var project = new Project();
            using (var fs = new FileStream(string.Format(FolderPath, typeof(Project)).Replace("ToDo.", ""), FileMode.Create, FileAccess.Write))
            {
                FileIO.SaveToFile(fs, project);
                fs.Close();
            }
            var task = new Task();
            using (var fs = new FileStream(string.Format(FolderPath, typeof(Task)).Replace("ToDo.", ""), FileMode.Create, FileAccess.Write))
            {
                FileIO.SaveToFile(fs, task);
                fs.Close();
            }
            var reminder = new Reminder();
            using (var fs = new FileStream(string.Format(FolderPath, typeof(Reminder)).Replace("ToDo.", ""), FileMode.Create, FileAccess.Write))
            {
                FileIO.SaveToFile(fs, reminder);
                fs.Close();
            }
            var location = new Location();
            using (var fs = new FileStream(string.Format(FolderPath, typeof(Location)).Replace("ToDo.", ""), FileMode.Create, FileAccess.Write))
            {
                FileIO.SaveToFile(fs, location);
                fs.Close();
            }
        }

        private void btnTestDeserialize_Click(object sender, EventArgs e)
        {
            var account = new Account();
            using (var fs = new FileStream(string.Format(FolderPath, typeof(Account)).Replace("ToDo.", ""), FileMode.Open, FileAccess.Read))
            {
                FileIO.LoadFromFile(fs, ref account);
                fs.Close();
            }
            var project = new Project();
            using (var fs = new FileStream(string.Format(FolderPath, typeof(Project)).Replace("ToDo.", ""), FileMode.Open, FileAccess.Read))
            {
                FileIO.LoadFromFile(fs, ref project);
                fs.Close();
            }
            var task = new Task();
            using (var fs = new FileStream(string.Format(FolderPath, typeof(Task)).Replace("ToDo.", ""), FileMode.Open, FileAccess.Read))
            {
                FileIO.LoadFromFile(fs, ref task);
                fs.Close();
            }
            var reminder = new Reminder();
            using (var fs = new FileStream(string.Format(FolderPath, typeof(Reminder)).Replace("ToDo.", ""), FileMode.Open, FileAccess.Read))
            {
                FileIO.LoadFromFile(fs, ref reminder);
                fs.Close();
            }
            var location = new Location();
            using (var fs = new FileStream(string.Format(FolderPath, typeof(Location)).Replace("ToDo.", ""), FileMode.Open, FileAccess.Read))
            {
                FileIO.LoadFromFile(fs, ref location);
                fs.Close();
            }
        }
    }
}