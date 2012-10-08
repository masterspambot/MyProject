﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace MyProject
{
    [Serializable]
    public class Task
    {
        public enum TaskStatus : int
        {
            PLANNED = 0,
            INPROGRESS = 1,
            OVERTIME = 2,
            DONE = 3,
            ERROR = 4
        }
        //test integracji VS2008 z svnem
        private string _name = string.Empty;
        private DateTime _start = DateTime.Now;
        private DateTime _end = DateTime.Now;
        private string _description = string.Empty;
        private int _progress = 0;
        private readonly List<Task> _tasks = new List<Task>();
        private int _duration = 1;
        private string _priority = "VERY LOW";
        // zawiera wskaźnik na rodzica elementu w drzewie
        private int level = 0;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public List<Task> Tasks { get { return this._tasks; } }

        public int Duration
        {
            get
            {
                if (this._tasks.Count > 0)
                {
                    int d = 0;
                    foreach (Task t in this._tasks)
                        d += t.Duration;
                    return d;
                }
                return this._duration;
            }
            set
            {
                this._duration = value;
            }
        }

        public DateTime Start
        {
            get
            {
                if (this.Tasks.Count > 0)
                {
                    DateTime dt = new DateTime();
                    foreach (Task t in this.Tasks)
                        if (dt < t.Start) dt = t.Start;
                    return dt;
                }
                return this._start;
            }
            set
            {
                this._start = value;
                if (this._end < this._start) this._end = this._start;
            }
        }

        public int Progress
        {
            get
            {
                if (this._tasks.Count > 0)
                {
                    //сум_общ(длительн_каждого_задания * процент_выполн/100)/длительн_всех_заданий*100
                    int sum_dur = 0; decimal sum_by_progress = 0m;
                    foreach (Task t in this._tasks)
                    {
                        sum_dur += t.Duration;
                        sum_by_progress += t.Progress * t.Duration / 100;
                    }
                    return Convert.ToInt32(sum_by_progress / sum_dur * 100);//
                }
                return this._progress;
            }
            set
            {
                if (value > 100)
                    this._progress = 100;
                else if (value < 0)
                    this._progress = 0;
                this._progress = value;
            }
        }

        public bool Completed
        {
            get { return this.Progress == 100; }
            set
            {
                if (value) this.Progress = 100;
            }
        }

        public DateTime End
        {
            get
            {
                if (this.Tasks.Count > 0)
                {
                    DateTime dt = new DateTime();
                    foreach (Task t in this.Tasks)
                        if (dt < t.End) dt = t.End;
                    return dt;
                }
                return this._end;
            }
            set
            {
                this._end = value;
                if (this._start > value) this._start = value;
            }
        }

        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        /// <summary>
        /// Zwraca status zadania (ale te zadania coś mają problemy ze sprawdzaniem swojej daty
        /// </summary>
        public TaskStatus Status
        {
            get
            {
                DateTime today = DateTime.Now;
                if (Completed)
                {
                    return TaskStatus.DONE;
                }
                else
                {
                    if (today.CompareTo(this.Start) < 0)
                    {
                        return TaskStatus.PLANNED;
                    }
                    else if ((today.CompareTo(this.Start) >= 0) && (today.CompareTo(this.End) <= 0))
                    {
                        return TaskStatus.INPROGRESS;
                    }
                    else if (today.CompareTo(this.End) > 0)
                    {
                        return TaskStatus.OVERTIME;
                    }
                    else
                    {
                        return TaskStatus.ERROR;
                    }
                }
            }
        }

        bool _expanded;

        /// <summary>
        /// it's for persisting node state
        /// </summary>
        public bool Expanded { get { return this._expanded; } set { this._expanded = value; } }

        /// <summary>
        /// Картинка продолжительности задания - для размещения в таблице. Высота - 20, ширина - 150
        /// </summary>
        [Obsolete]
        public Image Image
        {
            get
            {
                Bitmap bmp = new Bitmap(150, 20);
                Graphics g = Graphics.FromImage(bmp);

                //Хе-хе... Нужны даты начала и конца проекта)))
                //re he-he :) - it's needed for grid only - but not for independent image-report...
                //              for such report this property not needed at all ):
                g.Dispose();
                return bmp;
            }
        }

        public string Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                _priority = value;
            }
        }
    }
}