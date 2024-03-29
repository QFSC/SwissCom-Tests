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
    ///The addCustomer recording.
    /// </summary>
    [TestModule("6011d56f-462e-453c-8875-1da54b6bb7eb", ModuleType.Recording, 1)]
    public partial class AddCustomer : ITestModule
    {
        /// <summary>
        /// Holds an instance of the BMCtest333Repository repository.
        /// </summary>
        public static BMCtest333Repository repo = BMCtest333Repository.Instance;

        static AddCustomer instance = new AddCustomer();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddCustomer()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddCustomer Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IncidentForm.txt_customer' at Center.", repo.IncidentForm.txt_customerInfo, new RecordItemIndex(0));
            repo.IncidentForm.txt_customer.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'tosho' with focus on 'IncidentForm.txt_customer'.", repo.IncidentForm.txt_customerInfo, new RecordItemIndex(1));
            repo.IncidentForm.txt_customer.PressKeys("tosho");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'IncidentForm.txt_customer'.", repo.IncidentForm.txt_customerInfo, new RecordItemIndex(2));
            repo.IncidentForm.txt_customer.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
