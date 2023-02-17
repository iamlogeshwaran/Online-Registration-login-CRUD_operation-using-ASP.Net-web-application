using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace WebLogin
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString("d");
            Label2.Text = DateTime.Now.ToString("hh:mm tt");
        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (Txtname.Text != ""&&Txtmobum.Text!=""&&TxtmailID.Text!=""&&Txtpasscode.Text!=""&&Txtconfirmpasscode.Text!="")
            {
                Register r = new Register();
                r.Username = Txtname.Text;
                r.Mobilenumber = Txtmobum.Text;
                r.Email = TxtmailID.Text;
                r.Passcode = Txtpasscode.Text;
                r.Confirmpasscode = Txtpasscode.Text;

                if (r.Passcode == r.Confirmpasscode)
                {
                    SqlConnection con = new SqlConnection("server=DESKTOP-3MUST40\\SQLEXPRESS;Database=WebLogin;integrated security=true;");
                    try
                    {
                        con.Open();
                    }
                    catch
                    {
                        throw new Exception("Error in SQL connection");
                    }
                    SqlCommand cmd = new SqlCommand("insert into Register values('" + r.Username + "','" + r.Mobilenumber + "','" + r.Email + "','" + r.Passcode + "')");
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MailMessage msg = new MailMessage();
                    msg.To.Add(TxtmailID.Text);
                    msg.From = new MailAddress("iamlogeshwaran.info@gmail.com");
                    msg.Body = "Hai, "+Txtname.Text+"\n"+"This is a mail to confirm that your registration is Successfully done and your data is stored in our database if you want to update  or delete it you can easily do after Signup/login with your Registered username and password"+"\n\n\n"+"Thanks and Regards,\nLogeshwaran M";
                    msg.Subject = "Registration Successful";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential("iamlogeshwaran.info@gmail.com", "fylpjmtdzixmgutn");

                    try
                    {
                        smtp.Send(msg);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }


                    ClientScript.RegisterStartupScript(GetType(), "messagebox", "alert('message:" + "Your data registered sucessfully" + "');", true);

                    Response.Redirect("Information.aspx");
                    con.Close();
                }
                else
                {
                    Label7.Visible = true;
                }
            }
            else {

                Label6.Visible = true;
            }

          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Information.aspx");
        }

    }
}