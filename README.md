# My Learning Buddy

My Learning Buddy is a Windows Forms application designed to help students stay productive and organized.  
It combines a Pomodoro timer, a to-do list manager, and useful study statistics into one simple and friendly interface.

---

## 🚀 Features

### **1. Pomodoro Timer**
- Adjustable focus, short break, and long break durations  
- Start, pause, reset controls  
- Progress visualization  
- Automatically cycles focus → short break → next focus  
- Optional sound notifications  

### **2. To‑Do List Manager**
- Add, delete, and mark tasks as completed  
- Task categories (study, assignment, exam prep, etc.)  
- Optional due date  
- Tasks automatically saved to local files  

### **3. Settings Panel**
- Customize Pomodoro time lengths  
- Toggle sound notifications  
- Automatically load previous tasks  
- Save user preferences locally  

---

## 🏗 Project Structure
This structure is not yet complete and is currently in the initial testing phase.
```
/MyLearnBuddy
  /Forms
    Form_mainPage.cs
    Form_pomodoro.cs
    Form_setting.cs
    Form_Debug.cd
  /Component
    DataStructure.cs
    Task.cs
  /Component
    backColorSet.cs
    jsonnManager.cs
  Program.cs
  README.md
```

---

## 👥 Team Responsibilities

### **李松澔 – To‑Do + setting**
- Implements TodoManager and task models
- Implements user settings persistence  
- Integrates load/save on program start/exit  

### **陳鍵中 – Pomodoro Logic**
- Implements PomodoroManager (state machine, timers)  
- Connects WinForms Timer to UI  
- Handles focus/break session transitions  
- Tests timer cycles and state changes  

### **藍碩彥 – Data Storage**
- Handles reading/writing tasks to JSON/text


---

## 📦 Installation & Usage

### **Requirements**
- Windows 10 / 11  
- .NET Framework 4.8 (depending on project settings)  
- Visual Studio 2022 (recommended)

<!--
### **How to Run**
1. Clone this repository  
2. Open the `.sln` file in Visual Studio  
3. Build and run the project  
4. Enjoy productive studying!  
-->

```
git clone https://github.com/Squirrel-li/My_Learning_Buddy
```

---

## ❤️ Credits
Developed by a 3‑person team for coursework.

|  姓名  |   學號    |          e-mail         |
|--------|----------|-------------------------|
| 李松澔 | 112360221 | t112360221@ntut.org.tw |
| 陳鍵中 | 112360209 | t112360209@ntut.org.tw |
| 藍碩彥 | 112360210 | t112360210@ntut.org.tw |

My Learn Buddy — your study companion!
