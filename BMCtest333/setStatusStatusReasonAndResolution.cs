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
    ///The setStatusStatusReasonAndResolution recording.
    /// </summary>
    [TestModule("ea0bdf29-3da4-4e6b-bd1d-ee73b6cdff29", ModuleType.Recording, 1)]
    public partial class setStatusStatusReasonAndResolution : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BMCtest333Repository repository.
        /// </summary>
        public static BMCtest333Repository repo = BMCtest333Repository.Instance;

        static setStatusStatusReasonAndResolution instance = new setStatusStatusReasonAndResolution();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public setStatusStatusReasonAndResolution()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static setStatusStatusReasonAndResolution Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IncidentForm.mn_status' at Center.", repo.IncidentForm.mn_statusInfo, new RecordItemIndex(0));
            repo.IncidentForm.mn_status.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Down}{Down}{Down}{Down}{Return}' with focus on 'IncidentForm.mn_status'.", repo.IncidentForm.mn_statusInfo, new RecordItemIndex(1));
            repo.IncidentForm.mn_status.PressKeys("{Down}{Down}{Down}{Down}{Down}{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IncidentForm.mn_statusReason' at Center.", repo.IncidentForm.mn_statusReasonInfo, new RecordItemIndex(2));
            repo.IncidentForm.mn_statusReason.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Down}{Down}{Return}' with focus on 'IncidentForm.mn_statusReason'.", repo.IncidentForm.mn_statusReasonInfo, new RecordItemIndex(3));
            repo.IncidentForm.mn_statusReason.PressKeys("{Down}{Down}{Down}{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IncidentForm.txt_INC_Resolution' at Center.", repo.IncidentForm.txt_INC_ResolutionInfo, new RecordItemIndex(4));
            repo.IncidentForm.txt_INC_Resolution.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ResolveOriginalIncident' with focus on 'IncidentForm.txt_INC_Resolution'.", repo.IncidentForm.txt_INC_ResolutionInfo, new RecordItemIndex(5));
            repo.IncidentForm.txt_INC_Resolution.PressKeys("ResolveOriginalIncident");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IncidentForm.btn_save' at Center.", repo.IncidentForm.btn_saveInfo, new RecordItemIndex(6));
            repo.IncidentForm.btn_save.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
