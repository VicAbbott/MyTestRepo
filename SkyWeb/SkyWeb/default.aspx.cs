using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bizobj;

namespace SkyWeb
{
    public partial class _default : System.Web.UI.Page
    {
        User LoggedInUser = new User();

        protected void Page_Load(object sender, EventArgs e)
        {
            LoggedInUser.Name = "Vic";
            UserAuthorization ua = new UserAuthorization();
            ua.Authorization = UserAuthorization.Authorizations.Admin;
            LoggedInUser.UserAuthorizations = new List<UserAuthorization>();
            LoggedInUser.UserAuthorizations.Add(ua);

            DoMenu(LoggedInUser);
            DoSections(3);


        }

        private void DoSections(int p)
        {
            for (int i = 0; i < p; i++)
            {
                Panel pl = new Panel();
                pl.BackImageUrl = "Images/section.png";
                pl.BorderWidth = 0;
                pl.Width = 600;
                pl.CssClass = "section-panel";
                //pl.Height = 50;
                pl.Style.Add(HtmlTextWriterStyle.Height, "Auto");
                
                //************************
                //add controls to section (pl) here
                DoSectionControls(ref pl,i);
                //************************

                Div1.Controls.Add(pl);
                Image im = new Image();
                im.ImageUrl = "Images/divider.png";
                Div1.Controls.Add(im);                         
            }
            Image bottom = new Image();
            bottom.ImageUrl = "Images/tbbottom.png";
            Div1.Controls.Add(bottom);
        }

        private void DoSectionControls(ref Panel pl, int i)
        {
            Panel _p = new Panel();
            _p.Style.Add(HtmlTextWriterStyle.PaddingLeft, "2em");

            for (int x = 0; x < 4; x++)
            {
                
                TextBox lb = new TextBox();
                
                lb.Text = "Section Control " + x.ToString();

                _p.Controls.Add(lb);
                _p.Controls.Add(new LiteralControl("<br/>"));
                
            }
            pl.Controls.Add(_p);
        }

        

        private void DoMenu(bizobj.User LoggedInUser)
        {
            foreach (UserAuthorization ua in LoggedInUser.UserAuthorizations)
            {
                switch (ua.Authorization)
                {
                    case UserAuthorization.Authorizations.Admin:
                        DoAdminMenu();
                        break;
                }


            }
        }

        private void DoAdminMenu()
        {
            List<bizobj.MenuItem> mn = RetrieveMenuItems(LoggedInUser);

            foreach (bizobj.MenuItem mi in mn)
            {
                LinkButton lb = new LinkButton();
                lb.Style.Add(HtmlTextWriterStyle.BackgroundImage, "Images/btnmenu.png");
                lb.Style.Add(HtmlTextWriterStyle.Cursor, "Hand");
                lb.CssClass = "menulabel";
                lb.ID = mi.DisplayName;
                lb.Text = mi.DisplayName;
                lb.Width = 150;
                lb.Height = 30;
                lb.Click += lb_Click;
                Panel1.Controls.Add(lb);
            }

        }

        void lb_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        private List<bizobj.MenuItem> RetrieveMenuItems(bizobj.User LoggedInUser)
        {
            List<bizobj.MenuItem> mns = new List<bizobj.MenuItem>();

            mns.Add(new bizobj.MenuItem { DisplayName = "Initiate", SiteURL = "" });
            mns.Add(new bizobj.MenuItem { DisplayName = "Disposition", SiteURL = "" });
            mns.Add(new bizobj.MenuItem { DisplayName = "Admin", SiteURL = "" });
            mns.Add(new bizobj.MenuItem { DisplayName = "User Admin", SiteURL = "" });
            mns.Add(new bizobj.MenuItem { DisplayName = "Form Edit", SiteURL = "" });
            mns.Add(new bizobj.MenuItem { DisplayName = "Form Approve", SiteURL = "" });

            return mns;
        }

    }
}