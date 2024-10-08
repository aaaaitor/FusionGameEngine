﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FusionEditor.GameProject
{
    [DataContract]
    public class Scene : BaseViewModel
    {
        private string _name;
        [DataMember]
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(nameof(Name)); } }
        [DataMember]
        public Project Project { get; private set; }

        public Scene(Project project, string name)
        {
            Debug.Assert(project != null);
            Project = project;
            Name = name;
        }
    }
}
