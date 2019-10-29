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

namespace SwissCom
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The addSummaryNotes recording.
    /// </summary>
    [TestModule("f0128d00-e805-4954-b1fc-fa49bd5fd1a0", ModuleType.Recording, 1)]
    public partial class AddSummaryNotes : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SwissComRepo repository.
        /// </summary>
        public static SwissComRepo repo = SwissComRepo.Instance;

        static AddSummaryNotes instance = new AddSummaryNotes();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddSummaryNotes()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddSummaryNotes Instance
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
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IncidentForm.txt_detailedDescription' at Center.", repo.IncidentForm.txt_detailedDescriptionInfo, new RecordItemIndex(0));
            repo.IncidentForm.txt_detailedDescription.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test notes' with focus on 'IncidentForm.txt_detailedDescription'.", repo.IncidentForm.txt_detailedDescriptionInfo, new RecordItemIndex(1));
            repo.IncidentForm.txt_detailedDescription.PressKeys("test notes");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IncidentForm.txt_description' at Center.", repo.IncidentForm.txt_descriptionInfo, new RecordItemIndex(2));
            repo.IncidentForm.txt_description.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test summary' with focus on 'IncidentForm.txt_description'.", repo.IncidentForm.txt_descriptionInfo, new RecordItemIndex(3));
            repo.IncidentForm.txt_description.PressKeys("test summary");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
