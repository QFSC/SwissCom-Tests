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
    ///The goToNewMode recording.
    /// </summary>
    [TestModule("d8c1847d-ae45-4e39-b9a7-5ec5d282a53a", ModuleType.Recording, 1)]
    public partial class goToNewMode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BMCtest333Repository repository.
        /// </summary>
        public static BMCtest333Repository repo = BMCtest333Repository.Instance;

        static goToNewMode instance = new goToNewMode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public goToNewMode()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static goToNewMode Instance
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+Alt+Shift+F2' Press with focus on 'BMCRemedySearch'.", repo.BMCRemedySearch.SelfInfo, new RecordItemIndex(0));
            Keyboard.PrepareFocus(repo.BMCRemedySearch.Self);
            Keyboard.Press(System.Windows.Forms.Keys.F2 | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt, 60, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
