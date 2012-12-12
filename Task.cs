using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

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
        private string _colorbox = "■";
        private string _name = string.Empty;
        private DateTime _start = DateTime.Now;
        private DateTime _end = DateTime.Now;
        private string _description = string.Empty;
        private string _assigned = string.Empty;
        private int _progress = 0;
        private bool _isCompleted = false;
        private readonly List<Task> _tasks = new List<Task>();
        private int _duration = 1;
        private string _priority = "VERY LOW";
        // zawiera wskaźnik na rodzica elementu w drzewie
        private int level = 0;
        private List<String> _peopleList = new List<String>();

        public string fontC
        {
            get
            {
                return TaskColorsHelper.SerializeColor(this.fColor);
            }
            set
            {
                fColor = TaskColorsHelper.DeserializeColor(value);
            }
        }


        private Color fColor = System.Drawing.Color.Black;
        public Color getFontColor()
        {
            return this.fColor;
        }

        public void setFontColor(Color newColor)
        {
            this.fColor = newColor;
        }

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

        public List<String> PeopleList
        {
            get { return this._peopleList; }
            set { this._peopleList = value; }
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

        /// <summary>
        /// Status postępu nad rezlizacją zadania
        /// Wyliczna na podstawie wartości progresu zadania (i podzadań)
        /// </summary>
        public int Progress
        {
            get
            {
                if (this._tasks.Count > 0)
                {
                    decimal sum_by_progress = 0m;
                    foreach (Task t in this._tasks)
                    {
                        if (t._isCompleted)
                            sum_by_progress += 100;
                        else
                            sum_by_progress += t.Progress;
                    }
                    return Convert.ToInt32(sum_by_progress / this._tasks.Count);
                }
                if (this._isCompleted)
                    return 100;
                else
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

        /// <summary>
        /// Flaga oznaczająca ukończenie zadania, pełniąca funkcję wrappera pozawalającego cofać ukończenie zadania
        /// Atrybut wylicznay na postawie flagi _isCompleted oraz Progress
        /// </summary>
        public bool Completed
        {
            get {
                if (this.Progress == 100 || this._isCompleted)
                {
                    return true;
                }
                else
                    return false;
            }
            set
            {
                Console.WriteLine();
                this._isCompleted = value;
                foreach (Task t in this._tasks)
                {
                    t._isCompleted = value;
                    //Drobne obejście pozwalające na zachowanie flag w zaznaczonych podzadaniach przy odznaczniu zadania 
                    if (t.Progress == 100)
                    {
                        t._isCompleted = true;
                    }
                }
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
        /// Stores string with name of an assigned person
        /// </summary>
        public string Assigned
        {
            get { return this._assigned; }
            set { this._assigned = value; }
        }

        /// <summary>
        /// Stores string with block to color
        /// </summary>

        [XmlIgnore]
        public string ColorBox
        {
            get { return this._colorbox; }
            set { this._colorbox = value; }
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
        /// Overall duration of tasks - for placing in the table. Height - 20, width - 150
        /// </summary>
        [Obsolete]
        public Image Image
        {
            get
            {
                Bitmap bmp = new Bitmap(150, 20);
                Graphics g = Graphics.FromImage(bmp);

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