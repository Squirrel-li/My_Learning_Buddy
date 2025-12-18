using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace project.Component
{
    public class JsonManager
    {
        private string filePath;

        public JsonManager(string filePath)
        {
            if (filePath == null || filePath == "")
            {
                filePath = "../../settings.json";
            }
            this.filePath = filePath;
            json_init();
        }

        public JsonManager()
        {
            this.filePath = "../../settings.json";
            json_init();
        }

        class jsonStructure
        {
            // 代辦任務設定
            public List<string> tableSubject { get; set; }
            public List<string> tableClassification { get; set; }
            public List<string> tableFLPanelText { get; set; }
            public List<ToDoTask> tableToDoTask { get; set; } = new List<ToDoTask>();

            // 番茄鐘設定
            public int[] modeSet { get; set; }
            public int loopTimes { get; set; }
            public bool[] autoStart { get; set; }
        }

        private void json_init()
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                jsonStructure default_json = new jsonStructure()
                {
                    tableSubject = new List<string> { "科目一", "科目二", "科目三" },
                    tableClassification = new List<string> { "考試", "報告", "作業", "期末專題" },
                    tableFLPanelText = new List<string> { "今日活動", "明日活動", "久遠以後" },
                    tableToDoTask = new List<ToDoTask>(),
                    modeSet = new int[] { 0, 20 * 60, 5 * 60, 10 * 60 },
                    loopTimes = 2,
                    autoStart = new bool[] { false, false }
                };
                string jsonString = JsonSerializer.Serialize(default_json, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                System.IO.File.WriteAllText(this.filePath, jsonString);
            }
        }

        // 取得各個 table 的資料
        public List<string> Get_table_subject()
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.tableSubject.Sort();
            return jsonData.tableSubject;
        }

        public List<string> Get_tableClassification()
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.tableClassification.Sort();
            return jsonData.tableClassification;
        }

        public List<string> Get_tableFLPanelText()
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            return jsonData.tableFLPanelText;
        }

        public List<ToDoTask> Get_tableToDoTask()
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.tableToDoTask.Sort((a, b) => a.deadline.CompareTo(b.deadline));
            return jsonData.tableToDoTask;
        }

        public bool[] Get_autoStart()
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            return jsonData.autoStart;
        }

        public void Save_table_subject(List<string> table_subject)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            table_subject.Sort();
            jsonData.tableSubject = table_subject;
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }

        public void Save_tableClassification(List<string> tableClassification)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            tableClassification.Sort();
            jsonData.tableClassification = tableClassification;
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }

        public void Save_tableFLPanelText(List<string> tableFLPanelText)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.tableFLPanelText = tableFLPanelText;
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }

        public void Save_tableToDoTask(List<ToDoTask> tableToDoTasks)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            tableToDoTasks.Sort((a, b) => a.deadline.CompareTo(b.deadline));
            jsonData.tableToDoTask = tableToDoTasks;
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }

        public void Save_autoStart(bool[] autoStart)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.autoStart = autoStart;
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }

        public void Clear_tableToDoTask()
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.tableToDoTask.Clear();
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }

        public void add_table_subject(string table_subject)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.tableSubject.Add(table_subject);
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }

        public void add_tableClassification(string tableClassification)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.tableClassification.Add(tableClassification);
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }

        public void add_tableFLPanelText(string fl_text)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.tableFLPanelText.Add(fl_text);
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }
        
        public void add_tableToDoTask(ToDoTask tableToDoTask)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.tableToDoTask.Add(tableToDoTask);
            jsonData.tableToDoTask.Sort((a, b) => a.deadline.CompareTo(b.deadline));
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }

        public void Remove_table_subject_at(int index)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            if (index >= 0 && index < jsonData.tableSubject.Count)
            {
                jsonData.tableSubject.RemoveAt(index);
                string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                System.IO.File.WriteAllText(this.filePath, jsonString);
            }
        }

        public void Remove_tableClassification_at(int index)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            if (index >= 0 && index < jsonData.tableClassification.Count)
            {
                jsonData.tableClassification.RemoveAt(index);
                string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                System.IO.File.WriteAllText(this.filePath, jsonString);
            }
        }

        public void Remove_tableFLPanelText_at(int index)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            if (index >= 0 && index < jsonData.tableFLPanelText.Count)
            {
                jsonData.tableFLPanelText.RemoveAt(index);
                string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                System.IO.File.WriteAllText(this.filePath, jsonString);
            }
        }
        
        public void Remove_tableToDoTask_at(int index)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            if (index >= 0 && index < jsonData.tableToDoTask.Count)
            {
                jsonData.tableToDoTask.RemoveAt(index);
                string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                System.IO.File.WriteAllText(this.filePath, jsonString);
            }
        }

        public void Remove_tableToDoTask(ToDoTask task)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            ToDoTask target = jsonData.tableToDoTask.Find(t =>
                t.subject == task.subject &&
                t.classification == task.classification &&
                t.taskDescribe == task.taskDescribe &&
                t.deadline == task.deadline &&
                t.finish == task.finish
            );
            if (target != null)
            {
                jsonData.tableToDoTask.Remove(target);
                string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                System.IO.File.WriteAllText(this.filePath, jsonString);
            }
        }

        public void Clear_table_subject()
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.tableSubject.Clear();
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }

        public void Clear_tableClassification()
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.tableClassification.Clear();
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }

        public void Clear_tableFLPanelText()
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.tableFLPanelText.Clear();
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }

        public void Update_tableToDoTask(int index, ToDoTask updatedTask)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            if (index >= 0 && index < jsonData.tableToDoTask.Count)
            {
                jsonData.tableToDoTask[index] = updatedTask;
                string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                System.IO.File.WriteAllText(this.filePath, jsonString);
            }
        }
        public void Update_tableToDoTask(ToDoTask originTask, ToDoTask updatedTask)
        {
            int id = Find_ToDoTask_Id(originTask);
            this.Update_tableToDoTask(id, updatedTask);
        }

        public int Find_ToDoTask_Id(ToDoTask targetTask)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            int Id = jsonData.tableToDoTask.FindLastIndex(t =>
                t.subject == targetTask.subject &&
                t.classification == targetTask.classification &&
                t.taskDescribe == targetTask.taskDescribe &&
                t.deadline == targetTask.deadline &&
                t.finish == targetTask.finish
            );
            return Id;
        }


        // 番茄鐘操作
        public int[] Get_modeSet()
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            return jsonData.modeSet;
        }

        public int Get_loopTime()
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            return jsonData.loopTimes;
        }

        public void Save_modeSet(int[] modeSet)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.modeSet = modeSet;
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }

        public void Save_loopTime(int loopTimes)
        {
            if (!System.IO.File.Exists(this.filePath))
            {
                json_init();
            }
            string jsonFormFile = File.ReadAllText(filePath);
            jsonStructure jsonData = JsonSerializer.Deserialize<jsonStructure>(jsonFormFile);
            jsonData.loopTimes = loopTimes;
            string jsonString = JsonSerializer.Serialize(jsonData, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            System.IO.File.WriteAllText(this.filePath, jsonString);
        }
    }
}
