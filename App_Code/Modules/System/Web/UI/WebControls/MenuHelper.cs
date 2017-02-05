using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Modules.System.Web.UI.WebControls
{
    public class MenuHelper
    {
        public static void InitNavigationBar(MasterPage masterPage, string currentPage)
        {
            try
            {
                bool IsAdmin = false;
                bool IsLoggedIn = false;

                if (masterPage.Session["Account.IsAdmin"] != null && masterPage.Session["Account.IsAdmin"].ToString() == "1")
                    IsAdmin = true;

                if (masterPage.Session["Account.IsLoggedIn"] != null && masterPage.Session["Account.IsLoggedIn"].ToString() == "1")
                    IsLoggedIn = true;

                Menu menu = (Menu)masterPage.FindControl("NavigationBar");
                menu.FindItem(currentPage).Enabled = false;

                if (!IsLoggedIn)
                {
                    List<MenuItem> ItemToRemove = new List<MenuItem>();

                    foreach (MenuItem item in menu.Items)
                    {
                        if (StringHelper.Equals(item.Text, "Lend A Helping Hand", "Your Profile"))
                            ItemToRemove.Add(item);
                    }

                    foreach (MenuItem item in ItemToRemove)
                        menu.Items.Remove(item);
                }
                else
                {
                    foreach (MenuItem item in menu.Items)
                    {
                        if (StringHelper.Equals(item.Text, "Login/Register"))
                        {
                            item.Text = "Logout";
                            item.NavigateUrl = "~/Member/Logout.aspx";
                        }
                    }
                }
            }
            catch (Exception) { }
        }
    }
}