//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portfolio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    public partial class Project
    {
        public int ProjectID { get; set; }

        [DisplayName("Project Name")]
        public string ProjectName { get; set; }
        [DisplayName("Project Description")]
        public string ProjectDescription { get; set; }
        [DisplayName("Project ScreenShot")]
        public string ProjectScreenShot { get; set; }
        [DisplayName("GitHub Link")]
        public string GitHubLink { get; set; }
    }
}
