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

namespace SQLDM
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Validating_f_b_after_launch_app recording.
    /// </summary>
    [TestModule("2b0c9de8-08d6-46bb-a898-7e1e70e1ced5", ModuleType.Recording, 1)]
    public partial class Validating_f_b_after_launch_app : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SQLDMRepository repository.
        /// </summary>
        public static SQLDMRepository repo = SQLDMRepository.Instance;

        static Validating_f_b_after_launch_app instance = new Validating_f_b_after_launch_app();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validating_f_b_after_launch_app()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validating_f_b_after_launch_app Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IDERASQLDiagnosticManagerSQLdmRepos.BackButton' at 3;10.", repo.IDERASQLDiagnosticManagerSQLdmRepos.BackButtonInfo, new RecordItemIndex(0));
            repo.IDERASQLDiagnosticManagerSQLdmRepos.BackButton.Click("3;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='False') on item 'IDERASQLDiagnosticManagerSQLdmRepos.BackButton'.", repo.IDERASQLDiagnosticManagerSQLdmRepos.BackButtonInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.IDERASQLDiagnosticManagerSQLdmRepos.BackButtonInfo, "Enabled", "False");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasFocus='False') on item 'IDERASQLDiagnosticManagerSQLdmRepos.BackButton'.", repo.IDERASQLDiagnosticManagerSQLdmRepos.BackButtonInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.IDERASQLDiagnosticManagerSQLdmRepos.BackButtonInfo, "HasFocus", "False");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IDERASQLDiagnosticManagerSQLdmRepos.ForwardButton' at 11;12.", repo.IDERASQLDiagnosticManagerSQLdmRepos.ForwardButtonInfo, new RecordItemIndex(3));
            repo.IDERASQLDiagnosticManagerSQLdmRepos.ForwardButton.Click("11;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='False') on item 'IDERASQLDiagnosticManagerSQLdmRepos.ForwardButton'.", repo.IDERASQLDiagnosticManagerSQLdmRepos.ForwardButtonInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.IDERASQLDiagnosticManagerSQLdmRepos.ForwardButtonInfo, "Enabled", "False");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasFocus='False') on item 'IDERASQLDiagnosticManagerSQLdmRepos.ForwardButton'.", repo.IDERASQLDiagnosticManagerSQLdmRepos.ForwardButtonInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.IDERASQLDiagnosticManagerSQLdmRepos.ForwardButtonInfo, "HasFocus", "False");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
