﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SwissCom_Tests
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The searchOriginIncident recording.
    /// </summary>
    [TestModule("60d40e76-40ab-4cbe-8897-2ed84e607e7d", ModuleType.Recording, 1)]
    public partial class searchOriginIncident : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BMCtest333Repository repository.
        /// </summary>
        public static BMCtest333Repository repo = BMCtest333Repository.Instance;

        static searchOriginIncident instance = new searchOriginIncident();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public searchOriginIncident()
        {
            var_originIncident = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static searchOriginIncident Instance
        {
            get { return instance; }
        }

#region Variables

        string _var_originIncident;

        /// <summary>
        /// Gets or sets the value of variable var_originIncident.
        /// </summary>
        [TestVariable("2c63e07d-7a18-4629-96f9-3ab2eb3033f7")]
        public string var_originIncident
        {
            get { return _var_originIncident; }
            set { _var_originIncident = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IncidentForm.txt_IncidentID' at Center.", repo.IncidentForm.txt_IncidentIDInfo, new RecordItemIndex(0));
            repo.IncidentForm.txt_IncidentID.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$var_originIncident' with focus on 'IncidentForm.txt_IncidentID'.", repo.IncidentForm.txt_IncidentIDInfo, new RecordItemIndex(1));
            repo.IncidentForm.txt_IncidentID.PressKeys(var_originIncident);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IncidentForm.btn_search' at Center.", repo.IncidentForm.btn_searchInfo, new RecordItemIndex(2));
            repo.IncidentForm.btn_search.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(3));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
