using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;




public partial class Test2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TaskDetailsCollection TaskCollection = new TaskDetailsCollection();
        this.TreeGridControlDefault.DataSource = TaskCollection.GetDataSource();
        this.TreeGridControlDefault.DataBind();
    }
}

public class TaskDetailsCollection
{
    public class TaskDetails
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int Duration { get; set; }
        public string Progress { get; set; }
        public string Priority { get; set; }
        public bool Approved { get; set; }
        public List<TaskDetails> SubTasks { get; set; }
        public DateTime FilterStartDate { get; set; }
        public DateTime FilterEndDate { get; set; }
    }

    public List<TaskDetails> GetDataSource()
    {
        List<TaskDetails> tasks = new List<TaskDetails>();

        //tasks.Add(new TaskDetails()
        //{
        //    TaskID = 1,
        //    TaskName = "Project Schedule",
        //    StartDate = "02/03/2017",
        //    EndDate = "03/07/2017"
        //});

        //tasks[0].SubTasks = new List<TaskDetails>();

        tasks.Add(new TaskDetails()
        {
            TaskID = 1,
            TaskName = "Planning",
            StartDate = "02/03/2017",
            EndDate = "02/07/2017",
            Priority = "Normal",
            FilterStartDate = new DateTime(2017, 02, 03),
            FilterEndDate = new DateTime(2017, 02, 07),
        });

        tasks[0].SubTasks = new List<TaskDetails>();


        tasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 2,
            TaskName = "Plan timeline",
            StartDate = "02/03/2017",
            EndDate = "02/07/2017",
            Duration = 5,
            Progress = "100",
            Priority = "Low",
            Approved = false,
            FilterStartDate = new DateTime(2017, 02, 03),
            FilterEndDate = new DateTime(2017, 02, 07),
        });
        tasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 3,
            TaskName = "Plan budget",
            StartDate = "02/03/2017",
            EndDate = "02/07/2017",
            Duration = 5,
            Progress = "100",
            Priority = "Normal",
            Approved = true,
            FilterStartDate = new DateTime(2017, 02, 03),
            FilterEndDate = new DateTime(2017, 02, 07),
        });
        tasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 4,
            TaskName = "Allocate resources",
            StartDate = "02/03/2017",
            EndDate = "02/07/2017",
            Duration = 5,
            Progress = "100",
            Priority = "High",
            Approved = true,
            FilterStartDate = new DateTime(2017, 02, 03),
            FilterEndDate = new DateTime(2017, 02, 07),
        });
        tasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 5,
            TaskName = "Planning complete",
            StartDate = "02/07/2017",
            EndDate = "02/07/2017",
            Duration = 0,
            Approved = false,
            FilterStartDate = new DateTime(2017, 02, 07),
            FilterEndDate = new DateTime(2017, 02, 07),
        });

        tasks.Add(new TaskDetails()
        {
            TaskID = 6,
            TaskName = "Design",
            StartDate = "02/10/2017",
            EndDate = "02/14/2017",
            Priority = "High",
            FilterStartDate = new DateTime(2017, 02, 10),
            FilterEndDate = new DateTime(2017, 02, 14),
        });

        tasks[1].SubTasks = new List<TaskDetails>();

        tasks[1].SubTasks.Add(new TaskDetails()
        {
            TaskID = 7,
            TaskName = "Software Specification",
            StartDate = "02/10/2017",
            EndDate = "02/12/2017",
            Duration = 3,
            Progress = "60",
            Priority = "Critical",
            Approved = true,
            FilterStartDate = new DateTime(2017, 02, 10),
            FilterEndDate = new DateTime(2017, 02, 12),
        });
        tasks[1].SubTasks.Add(new TaskDetails()
        {
            TaskID = 8,
            TaskName = "Develop prototype",
            StartDate = "02/10/2017",
            EndDate = "02/12/2017",
            Duration = 3,
            Progress = "100",
            Priority = "Normal",
            Approved = false,
            FilterStartDate = new DateTime(2017, 02, 10),
            FilterEndDate = new DateTime(2017, 02, 12),
        });
        tasks[1].SubTasks.Add(new TaskDetails()
        {
            TaskID = 9,
            TaskName = "Get approval from customer",
            StartDate = "02/13/2017",
            EndDate = "02/14/2017",
            Duration = 2,
            Progress = "100",
            Priority = "Low",
            Approved = false,
            FilterStartDate = new DateTime(2017, 02, 13),
            FilterEndDate = new DateTime(2017, 02, 14),
        });
        tasks[1].SubTasks.Add(new TaskDetails()
        {
            TaskID = 10,
            TaskName = "Design Documentation",
            StartDate = "02/13/2017",
            EndDate = "02/14/2017",
            Duration = 0,
            Approved = true,
            FilterStartDate = new DateTime(2017, 02, 14),
            FilterEndDate = new DateTime(2017, 02, 14),
        });
        tasks[1].SubTasks.Add(new TaskDetails()
        {
            TaskID = 11,
            TaskName = "Design complete",
            StartDate = "02/14/2017",
            EndDate = "02/14/2017",
            Duration = 0,
            Approved = true,
            FilterStartDate = new DateTime(2017, 02, 14),
            FilterEndDate = new DateTime(2017, 02, 14),
        });


        tasks.Add(new TaskDetails()
        {
            TaskID = 12,
            TaskName = "Implementation Phase",
            StartDate = "02/17/2017",
            EndDate = "02/27/2017",
            Priority = "Normal",
            FilterStartDate = new DateTime(2017, 02, 17),
            FilterEndDate = new DateTime(2017, 02, 27),
        });

        tasks[2].SubTasks = new List<TaskDetails>();

        tasks[2].SubTasks.Add(new TaskDetails()
        {
            TaskID = 13,
            TaskName = "Phase 1",
            StartDate = "02/17/2017",
            EndDate = "02/27/2017",
            Priority = "High",
            FilterStartDate = new DateTime(2017, 02, 17),
            FilterEndDate = new DateTime(2017, 02, 27),
        });

        tasks[2].SubTasks[0].SubTasks = new List<TaskDetails>();

        tasks[2].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 14,
            TaskName = "Implementation Module 1",
            StartDate = "02/17/2017",
            EndDate = "02/27/2017",
            Priority = "Normal",
            FilterStartDate = new DateTime(2017, 02, 17),
            FilterEndDate = new DateTime(2017, 02, 27),
        });

        tasks[2].SubTasks[0].SubTasks[0].SubTasks = new List<TaskDetails>();


        tasks[2].SubTasks[0].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 15,
            TaskName = "Development Task 1",
            StartDate = "02/17/2017",
            EndDate = "02/19/2017",
            Duration = 3,
            Progress = "50",
            Priority = "Critical",
            Approved = true,
            FilterStartDate = new DateTime(2017, 02, 17),
            FilterEndDate = new DateTime(2017, 02, 19),
        });
        tasks[2].SubTasks[0].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 16,
            TaskName = "Development Task 2",
            StartDate = "02/17/2017",
            EndDate = "02/19/2017",
            Duration = 3,
            Progress = "50",
            Priority = "Low",
            Approved = true,
            FilterStartDate = new DateTime(2017, 02, 17),
            FilterEndDate = new DateTime(2017, 02, 19),
        });
        tasks[2].SubTasks[0].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 17,
            TaskName = "Testing",
            StartDate = "02/20/2017",
            EndDate = "02/21/2017",
            Duration = 2,
            Progress = "0",
            Priority = "Normal",
            Approved = false,
            FilterStartDate = new DateTime(2017, 02, 20),
            FilterEndDate = new DateTime(2017, 02, 21),
        });
        tasks[2].SubTasks[0].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 18,
            TaskName = "Bug fix",
            StartDate = "02/24/2017",
            EndDate = "02/25/2017",
            Duration = 2,
            Progress = "0",
            Priority = "Low",
            Approved = false,
            FilterStartDate = new DateTime(2017, 02, 24),
            FilterEndDate = new DateTime(2017, 02, 25),
        });
        tasks[2].SubTasks[0].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 19,
            TaskName = "Customer review meeting",
            StartDate = "02/26/2017",
            EndDate = "02/27/2017",
            Duration = 2,
            Progress = "0",
            Priority = "High",
            Approved = true,
            FilterStartDate = new DateTime(2017, 02, 26),
            FilterEndDate = new DateTime(2017, 02, 27),
        });
        tasks[2].SubTasks[0].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 20,
            TaskName = "Phase 1 complete",
            StartDate = "02/27/2017",
            EndDate = "02/27/2017",
            Duration = 0,
            Priority = "Low",
            Approved = false,
            FilterStartDate = new DateTime(2017, 02, 27),
            FilterEndDate = new DateTime(2017, 02, 27),
        });

        tasks[2].SubTasks.Add(new TaskDetails()
        {
            TaskID = 21,
            TaskName = "Phase 2",
            StartDate = "02/17/2017",
            EndDate = "02/28/2017",
            Priority = "High",
            FilterStartDate = new DateTime(2017, 02, 17),
            FilterEndDate = new DateTime(2017, 02, 28),
        });

        tasks[2].SubTasks[1].SubTasks = new List<TaskDetails>();

        tasks[2].SubTasks[1].SubTasks.Add(new TaskDetails()
        {
            TaskID = 22,
            TaskName = "Implementation Module 2",
            StartDate = "02/17/2017",
            EndDate = "02/28/2017",
            Priority = "Normal",
            FilterStartDate = new DateTime(2017, 02, 17),
            FilterEndDate = new DateTime(2017, 02, 28),
        });

        tasks[2].SubTasks[1].SubTasks[0].SubTasks = new List<TaskDetails>();

        tasks[2].SubTasks[1].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 23,
            TaskName = "Development Task 1",
            StartDate = "02/17/2017",
            EndDate = "02/20/2017",
            Duration = 4,
            Progress = "50",
            Priority = "High",
            Approved = false,
            FilterStartDate = new DateTime(2017, 02, 17),
            FilterEndDate = new DateTime(2017, 02, 20),
        });
        tasks[2].SubTasks[1].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 24,
            TaskName = "Development Task 2",
            StartDate = "02/17/2017",
            EndDate = "02/20/2017",
            Duration = 4,
            Progress = "50",
            Priority = "Critical",
            Approved = true,
            FilterStartDate = new DateTime(2017, 02, 17),
            FilterEndDate = new DateTime(2017, 02, 20),
        });
        tasks[2].SubTasks[1].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 25,
            TaskName = "Testing",
            StartDate = "02/21/2017",
            EndDate = "02/24/2017",
            Duration = 2,
            Progress = "0",
            Priority = "Normal",
            Approved = true,
            FilterStartDate = new DateTime(2017, 02, 21),
            FilterEndDate = new DateTime(2017, 02, 24),
        });
        tasks[2].SubTasks[1].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 26,
            TaskName = "Bug fix",
            StartDate = "02/25/2017",
            EndDate = "02/26/2017",
            Duration = 2,
            Progress = "0",
            Priority = "Critical",
            Approved = false,
            FilterStartDate = new DateTime(2017, 02, 25),
            FilterEndDate = new DateTime(2017, 02, 26),
        });
        tasks[2].SubTasks[1].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 27,
            TaskName = "Customer review meeting",
            StartDate = "02/27/2017",
            EndDate = "02/28/2017",
            Duration = 2,
            Progress = "0",
            Priority = "High",
            Approved = false,
            FilterStartDate = new DateTime(2017, 02, 27),
            FilterEndDate = new DateTime(2017, 02, 28),
        });
        tasks[2].SubTasks[1].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 28,
            TaskName = "Phase 2 complete",
            StartDate = "02/28/2017",
            EndDate = "02/28/2017",
            Duration = 0,
            Priority = "Low",
            Approved = true,
            FilterStartDate = new DateTime(2017, 02, 28),
            FilterEndDate = new DateTime(2017, 02, 28),
        });

        tasks[2].SubTasks.Add(new TaskDetails()
        {
            TaskID = 29,
            TaskName = "Phase 3",
            StartDate = "02/17/2017",
            EndDate = "02/27/2017",
            Priority = "Critical",
            FilterStartDate = new DateTime(2017, 02, 17),
            FilterEndDate = new DateTime(2017, 02, 27),
        });
        tasks[2].SubTasks[2].SubTasks = new List<TaskDetails>();

        tasks[2].SubTasks[2].SubTasks.Add(new TaskDetails()
        {
            TaskID = 30,
            TaskName = "Implementation Module 3",
            StartDate = "02/17/2017",
            EndDate = "02/27/2017",
            Priority = "High",
            FilterStartDate = new DateTime(2017, 02, 17),
            FilterEndDate = new DateTime(2017, 02, 27),
        });

        tasks[2].SubTasks[2].SubTasks[0].SubTasks = new List<TaskDetails>();

        tasks[2].SubTasks[2].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 31,
            TaskName = "Development Task 1",
            StartDate = "02/17/2017",
            EndDate = "02/19/2017",
            Duration = 3,
            Progress = "50",
            Priority = "High",
            Approved = false,
            FilterStartDate = new DateTime(2017, 02, 17),
            FilterEndDate = new DateTime(2017, 02, 19),
        });
        tasks[2].SubTasks[2].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 32,
            TaskName = "Development Task 2",
            StartDate = "02/17/2017",
            EndDate = "02/19/2017",
            Duration = 3,
            Progress = "50",
            Priority = "Critical",
            Approved = true,
            FilterStartDate = new DateTime(2017, 02, 17),
            FilterEndDate = new DateTime(2017, 02, 19),
        });
        tasks[2].SubTasks[2].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 33,
            TaskName = "Testing",
            StartDate = "02/20/2017",
            EndDate = "02/21/2017",
            Duration = 2,
            Progress = "0",
            Priority = "High",
            Approved = false,
            FilterStartDate = new DateTime(2017, 02, 20),
            FilterEndDate = new DateTime(2017, 02, 21),
        });
        tasks[2].SubTasks[2].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 34,
            TaskName = "Bug fix",
            StartDate = "02/24/2017",
            EndDate = "02/25/2017",
            Duration = 2,
            Progress = "0",
            Priority = "Low",
            Approved = true,
            FilterStartDate = new DateTime(2017, 02, 24),
            FilterEndDate = new DateTime(2017, 02, 25),
        });
        tasks[2].SubTasks[2].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 35,
            TaskName = "Customer review meeting",
            StartDate = "02/26/2017",
            EndDate = "02/27/2017",
            Duration = 2,
            Progress = "0",
            Priority = "Normal",
            Approved = false,
            FilterStartDate = new DateTime(2017, 02, 26),
            FilterEndDate = new DateTime(2017, 02, 27),
        });
        tasks[2].SubTasks[2].SubTasks[0].SubTasks.Add(new TaskDetails()
        {
            TaskID = 36,
            TaskName = "Phase 3 complete",
            StartDate = "02/27/2017",
            EndDate = "02/27/2017",
            Duration = 0,
            Priority = "Critical",
            Approved = true,
            FilterStartDate = new DateTime(2017, 02, 27),
            FilterEndDate = new DateTime(2017, 02, 27),
        });
        return tasks;
    }
}
public class BusinessObject
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public string StartDate { get; set; }
    public int Duration { get; set; }
    public int? ParentId { get; set; }
}

