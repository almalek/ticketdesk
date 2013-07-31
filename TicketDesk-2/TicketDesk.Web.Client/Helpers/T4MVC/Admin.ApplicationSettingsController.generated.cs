// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace TicketDesk.Web.Client.Areas.Admin.Controllers {
    public partial class ApplicationSettingsController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ApplicationSettingsController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Edit() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ApplicationSettingsController Actions { get { return MVC.Admin.ApplicationSettings; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Admin";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "ApplicationSettings";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string List = "List";
            public readonly string Edit = "Edit";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string Edit = "~/Areas/Admin/Views/ApplicationSettings/Edit.aspx";
            public readonly string List = "~/Areas/Admin/Views/ApplicationSettings/List.aspx";
            static readonly _Controls s_Controls = new _Controls();
            public _Controls Controls { get { return s_Controls; } }
            public partial class _Controls{
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_ApplicationSettingsController: TicketDesk.Web.Client.Areas.Admin.Controllers.ApplicationSettingsController {
        public T4MVC_ApplicationSettingsController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult List() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.List);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Edit(string settingName) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
            callInfo.RouteValueDictionary.Add("settingName", settingName);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Edit(TicketDesk.Domain.Models.Setting setting) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
            callInfo.RouteValueDictionary.Add("setting", setting);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591