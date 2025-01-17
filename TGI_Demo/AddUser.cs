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

namespace TGI_Demo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddUser recording.
    /// </summary>
    [TestModule("da715446-bc11-481b-a642-25cb996a38a9", ModuleType.Recording, 1)]
    public partial class AddUser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TGI_DemoRepository repository.
        /// </summary>
        public static TGI_DemoRepository repo = TGI_DemoRepository.Instance;

        static AddUser instance = new AddUser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddUser()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddUser Instance
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
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FirstName' at .159;.294.", repo.ApplicationUnderTest.FirstNameInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.FirstName.Click(".159;.294");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Jason' with focus on 'ApplicationUnderTest.FirstName'.", repo.ApplicationUnderTest.FirstNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.FirstName.PressKeys("Jason");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LastName' at Center.", repo.ApplicationUnderTest.LastNameInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.LastName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Branham' with focus on 'ApplicationUnderTest.LastName'.", repo.ApplicationUnderTest.LastNameInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.LastName.PressKeys("Branham");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Movie' at .176;.533.", repo.ApplicationUnderTest.MovieInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Movie.Click(".176;.533");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Gender' at .385;.692.", repo.ApplicationUnderTest.GenderInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Gender.Click(".385;.692");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.InputTagAdd' at .28;.565.", repo.ApplicationUnderTest.InputTagAddInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.InputTagAdd.Click(".28;.565");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
