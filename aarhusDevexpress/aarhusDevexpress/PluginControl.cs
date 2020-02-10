﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aarhusDevexpress.Models;
using aarhusDevexpress.Views;
using Uniconta.API.Service;
using Uniconta.ClientTools;
using Uniconta.Common;

namespace aarhusDevexpress
{
    public class PluginControl : IPluginControl
    {
        public string Name { get; }
        public event EventHandler OnExecute;
        private string _error = "";

        public string GetErrorDescription()
        {
            return _error;
        }

        public ErrorCodes Execute(UnicontaBaseEntity master, UnicontaBaseEntity currentRow, IEnumerable<UnicontaBaseEntity> source, string command,
            string args)
        {
            return ErrorCodes.Succes;
        }

        public void SetMaster(List<UnicontaBaseEntity> masters)
        {
        }

        public void SetAPI(BaseAPI api)
        {
        }

        public void Intialize()
        {
        }

        public string[] GetDependentAssembliesName()
        {
            return null;// new[] { "Uniconta.Common.dll", "Uniconta.WindowsAPI.dll", "PresentationFramework.dll", "ClientTools.dll" };
        }

        public List<Uniconta.ClientTools.PluginControl> RegisterControls()
        {
            //OBS!!!!!!! you have to tell uniconta which form to open from INSIDE uniconta, when adding the menu item in lokal or main 
            //add the UniqueName to arguments like so .: 'FormName=MyGridView;' you can also send current record to your control by adding 'SourceType=UseCurrentRecord'
            List <Uniconta.ClientTools.PluginControl> ctrls = new List<Uniconta.ClientTools.PluginControl>();
            ctrls.Add(new Uniconta.ClientTools.PluginControl() { UniqueName = "MyGridView", PageType = typeof(GridView1), AllowMultipleOpen = false, PageHeader = "Overview of Orders" });
            return ctrls;
        }
    }
}
