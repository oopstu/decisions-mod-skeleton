using DecisionsFramework.Design;
using DecisionsFramework.ServiceLayer;
using DecisionsFramework.ServiceLayer.Services.Folder;
using DecisionsFramework.ServiceLayer.Services.Portal;
using DecisionsFramework.ServiceLayer.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is a module initializer.  This is an optional aspect to a module.
/// This code is run whenever ServiceHostManager is started so this code can be
/// used to check and enforce branding, ensure certain things are present, make registrations,
/// enforce licensing and more.  Since this code is run on EVERY start of SHM it should not 
/// always recreate the same things, but should check and create as needed.
/// </summary>
namespace MyModuleCode
{
    public class ModuleInit : IInitializable
    {
        public void Initialize()
        {
            // This code on run on every start.
            //ChangedBranding();

            //SetupFolders();

            EnsureCustomSettingsObject();
        }

        private void EnsureCustomSettingsObject()
        {
            ModuleSettingsAccessor<MyModuleSettings>.GetSettings();
            ModuleSettingsAccessor<MyModuleSettings>.SaveSettings();
        }

        //private void SetupFolders()
        //{
        //    SystemUserContext system = new SystemUserContext();
        //    if (FolderService.Instance.Exists(system, "MY CO ROOT FOLDER") == false) {
        ///        // The null here is for a Folder Bheavior which allows a lot of customization
        //        // of a folder including custom actions and a lot of filtering capability.
        //        FolderService.Instance.CreateRootFolder(system, "MY CO ROOT FOLDER", "My Company Designs", null);
        //    }
        //}

        //private void ChangedBranding()
        //{
        //    ModuleSettingsAccessor<PortalSettings>.Instance.SloganText = "My Custom Rule Portal";

        //    ModuleSettingsAccessor<DesignerSettings>.Instance.StudioSlogan = "My Custom Rule Studio";

        //}
    }
}
