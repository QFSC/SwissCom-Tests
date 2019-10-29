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
    ///The validateDuplicate recording.
    /// </summary>
    [TestModule("4487d230-d7d1-4ea6-9ae5-56d47121af4e", ModuleType.Recording, 1)]
    public partial class validateDuplicate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SwissComRepo repository.
        /// </summary>
        public static SwissComRepo repo = SwissComRepo.Instance;

        static validateDuplicate instance = new validateDuplicate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public validateDuplicate()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static validateDuplicate Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HPD_Associations.txt_Entry2_RequestID' at 99;10.", repo.HPD_Associations.txt_Entry2_RequestIDInfo, new RecordItemIndex(0));
            repo.HPD_Associations.txt_Entry2_RequestID.Click("99;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'INC000000000261' with focus on 'HPD_Associations.txt_Entry2_RequestID'.", repo.HPD_Associations.txt_Entry2_RequestIDInfo, new RecordItemIndex(1));
            repo.HPD_Associations.txt_Entry2_RequestID.PressKeys("INC000000000261");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HPD_Associations.txt_Entry1_RequestID' at 120;16.", repo.HPD_Associations.txt_Entry1_RequestIDInfo, new RecordItemIndex(2));
            repo.HPD_Associations.txt_Entry1_RequestID.Click("120;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'INC000000000097' with focus on 'HPD_Associations.txt_Entry1_RequestID'.", repo.HPD_Associations.txt_Entry1_RequestIDInfo, new RecordItemIndex(3));
            repo.HPD_Associations.txt_Entry1_RequestID.PressKeys("INC000000000097");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BMCRemedySearch.TBsearchsavechanges' at 12;8.", repo.BMCRemedySearch.TBsearchsavechangesInfo, new RecordItemIndex(4));
            repo.BMCRemedySearch.TBsearchsavechanges.Click("12;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Duplicate of') on item 'HPD_Associations.mn_AssociationType'.", repo.HPD_Associations.mn_AssociationTypeInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.HPD_Associations.mn_AssociationTypeInfo, "Value", "Duplicate of");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
