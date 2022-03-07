using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
namespace SchoolRegister.Model.DataModels
{
    public class Parent
    {
        public IList<Student> Students { get; set; }
        public Parent()
        {

        }
    }
}