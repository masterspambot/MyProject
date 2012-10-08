using System;
using System.Collections.Generic;
using System.Text;
using Aga.Controls.Tree;

namespace MyProject
{
    class TaskTreeModel : TreeModelBase
    {

        public List<Task> projects;
        public TaskTreeModel(Task project)
    	{
            projects = new List<Task>();
            projects.Add(project);
    	}
    	
        public override System.Collections.IEnumerable GetChildren(TreePath treePath)
        {
            Task t= treePath.LastNode as Task;
            if(t==null)
            	return new List<Task>(this.projects);
            return t.Tasks;
        }

        public override bool IsLeaf(TreePath treePath)
        {
            Task t= treePath.LastNode as Task;
            return t.Tasks.Count==0;
        }

        public void AddProject(Task t)
        {
            this.projects.Add(t);
        }

       
        
        
    }
}
