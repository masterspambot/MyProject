using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace MyProject
{
    public class RecentList
    {
        private const int MAX_ITEMS_COUNT = 5;
        private const string RECENT_FILE_NAME = "recent.xml";
        private string _recentFileFullName;

        List<string> _recentFileList = new List<string>();
        public List<string> RecentFileList
        {
            get { return _recentFileList; }

        }

        private bool _hasChanges = true;
        public bool HasChanges
        {
            get { return _hasChanges; }
            set { _hasChanges = value; }
        }


        public RecentList()
        {
            InitializeValues();
        }

        //this method initializes some data member.
        private void InitializeValues()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            path += Path.DirectorySeparatorChar + RECENT_FILE_NAME;
            _recentFileFullName = path;


        }


        public void Load()
        {
            if (!File.Exists(_recentFileFullName))
            {
                File.Create(_recentFileFullName).Close();
                return;
            }

            System.Xml.Serialization.XmlSerializer srl = new System.Xml.Serialization.XmlSerializer(typeof(List<string>));
            System.IO.FileStream file = System.IO.File.OpenRead(_recentFileFullName);
            this._recentFileList = (List<string>)srl.Deserialize(file);
            RemoveInvalidFiles();


        }

        public void Save()
        {
            if (File.Exists(_recentFileFullName))
            {
                //File.Delete(_recentFileFullName);

            }

            //File.Create(_recentFileFullName).Close();

            RemoveInvalidFiles();

            XmlTextWriter xmlWriter = new XmlTextWriter(_recentFileFullName, Encoding.UTF8);
            System.Xml.Serialization.XmlSerializer srl = new System.Xml.Serialization.XmlSerializer(typeof(List<string>));
            //System.IO.FileStream file = System.IO.File.OpenWrite(_recentFileFullName);
            //srl.Serialize(file, this._recentFileList);
            srl.Serialize(xmlWriter, _recentFileList);
            xmlWriter.Close();


        }

        public void AddItem(string item)
        {
            //item in position [0] is the oldest item in list
            int itemIndex = _recentFileList.IndexOf(item);
            //item exists in recent list, so change his place only.
            if ((itemIndex >= 0) &&
                (itemIndex < _recentFileList.Count))
            {
                _recentFileList.RemoveAt(itemIndex);

            }
            else
            {
                //delete the oldest item from the list
                if ((_recentFileList.Count > MAX_ITEMS_COUNT) &&
                    (_recentFileList.Count > 0))
                    _recentFileList.RemoveAt(0);

            }

            if (IsValidFile(item))
            {
                _recentFileList.Add(item);
                //list is dirty and need to render again.
                _hasChanges = true;
            }

        }

        private void RemoveInvalidFiles()
        {
            for (int i = _recentFileList.Count - 1; i >= 0; i--)
                if (!IsValidFile(_recentFileList[i]))
                    _recentFileList.RemoveAt(i);

        }

        private bool IsValidFile(string pFileName)
        {
            //right now , File is Valid , if exists, 
            //file is added after successful 'OpenProject' call.
            return File.Exists(pFileName);
        }

    }
}
