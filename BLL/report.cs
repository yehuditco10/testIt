﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public static class report
    {
        public static int getTeachers()
        {

            //The context cannot be used while the model is being created. This exception may be thrown if the context is used inside the OnModelCreating method or if the same context instance is accessed by multiple threads concurrently.Note that instance members of DbContext and related classes are not guaranteed to be thread safe."
            try
            {
                using (checkTestEntities1 db = new checkTestEntities1())
                {
                    int numTeachers = 0;
                    numTeachers = db.Teachers.Count();

                    if (numTeachers != 0)
                        return numTeachers;
                }
            }
            catch (Exception)
            {


                throw;
            }

            return 0;
        }

        public static int getStudents()
        {
            try
            {
                using (checkTestEntities1 db = new checkTestEntities1())
                {
                    int numStudent = 0;
                    numStudent = db.students.Count();
                    if (numStudent != 0)
                        return numStudent;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return 0;
        }
    }
}
