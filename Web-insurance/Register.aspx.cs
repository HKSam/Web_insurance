using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_insurance
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if(username.Text.ToString()!="")
            {
                if(password.Text.ToString() != ""&& passwords.Text.ToString() != "")
                {
                    if(password.Text.ToString() == passwords.Text.ToString())
                    {
                        if (number.Text.ToString() != "")
                        {
                            try
                            {

                                DateTime.Now.Month.ToString();
                                MydataDataContext data = new MydataDataContext();
                                login logins = new login();
                                logins.username = username.Text;
                                logins.password = password.Text;
                                logins.number = number.Text;
                                data.login.InsertOnSubmit(logins);
                                data.SubmitChanges();

                              
                                for (int i = 1; i < 13; i++)
                                {
                                    data datas = new data();
                                    datas.mouth = Convert.ToString(i);
                                    datas.name = username.Text;
                                    datas.data1 = "0";
                                    datas.data2 = "0";
                                    datas.data3 = "0";
                                    datas.data4 = "0";
                                    data.data.InsertOnSubmit(datas);
                                    data.SubmitChanges();
                                }
                               
                                string url = "Login.aspx";
                                Response.Redirect(url);
                                
                            }catch (Exception)
                            {
                         
                                Response.Write(" <script>window.onload=function()  {alert( '工号已录入，请直接登陆' ) } </script> ");
                                number.Text = "";
                            }
                           
                           
                        }
                        else
                        {
                            Response.Write("<script language=javascript>alert('请填写工号');</" + "script>");
                           
                            
                        }
                           
                    }
                    else
                    {
                    
                        Response.Write(" <script>window.onload=function() {alert( '两次输入密码不同，请重新填写' ) } </script> ");
                        password.Text = "";
                        passwords.Text = "";
                    }
                }
                else
                {
                    Response.Write(" <script>alert( '请填写密码' ) </script> ");
                }
            }
            else
            {
               
                Response.Write(" <script>alert( '请填写姓名' )</script> ");
            }
        }

        protected void username_TextChanged(object sender, EventArgs e)
        {

        }

        protected void password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void passwords_TextChanged(object sender, EventArgs e)
        {

        }

        protected void number_TextChanged(object sender, EventArgs e)
        {

        }
    }
}