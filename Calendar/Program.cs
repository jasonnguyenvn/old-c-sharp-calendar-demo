﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calendar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*string usr = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] usrtmp = usr.Split('\\');
            string userName = "";
            if(usrtmp.Length>=2)
                 userName =  usrtmp[usrtmp.Length-1];
            else
                 userName = usr;

            string path = "C:\\Documents and Settings\\" + userName + "\\Local Settings\\";*/
            
            //MessageBox.Show(path + "Cal61546_data.tmp");
            //if (!System.IO.File.Exists(path + "Cal61546_data.tmp"))
            {
                //System.IO.File.WriteAllText(path + "Cal61546_data.tmp", "running");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Form1 aForm = new Form1();
                Application.Run(new Form1());

                /*if (System.IO.File.Exists(path + "Cal61546_data.tmp"))
                    System.IO.File.Delete(path + "Cal61546_data.tmp");*/
            }
           
        }
    }
}
