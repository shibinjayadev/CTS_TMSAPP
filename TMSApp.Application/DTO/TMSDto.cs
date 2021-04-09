//-----------------------------------------------------------------------
// <copyright file="TMSDto.cs" company="Cognizant">
//  Copyright (C) Cognizant Technology. All rights reserved.
// </copyright>
// <Author>Shibin</Author>
// <Date>06 April 2021</Date>

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TMSApp.Application.DTO
{

    public class TMSDto
    {
        

        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public float TimeSpent { get; set; }
        public int TaskGroup { get; set; }
        public string Assignee { get; set; }
        public int SubTask { get; set; }
        public int TaskStatus { get; set; }

       
    }
}
