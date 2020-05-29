/*
 * Created by Ranorex
 * User: jbranham
 * Date: 5/29/2020
 * Time: 10:39 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */

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

namespace TGI_Demo
{
    /// <summary>
    /// Description of DoSomeCode.
    /// </summary>
    [TestModule("597684D5-1A09-40A3-A879-F28C41054BE9", ModuleType.UserCode, 1)]
    public class DoSomeCode : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DoSomeCode()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            
        }
    }
}
