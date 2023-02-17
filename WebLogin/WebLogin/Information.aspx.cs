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
    public partial class Information : System.Web.UI.Page
    {
        public static string username = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            Label3.Text = DateTime.Now.ToString("d");
            Label7.Text = DateTime.Now.ToString("hh:mm tt");
 
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("select Password from Register where Username='"+Txtlogusername.Text+"'");
            cmd.Connection = con;
           string dbpassword=(string)cmd.ExecuteScalar();

           if (dbpassword == Txtlogpassword.Text)
           {
               SqlCommand cmmd = new SqlCommand("select Username,Mobilenumber,Email,Password from Register where Username='"+Txtlogusername.Text+"'");
               cmmd.Connection = con;

               SqlDataReader da = cmmd.ExecuteReader();
              da.Read();
                   Txtusername.Text = da.GetString(0);
                   Txtmobilenum.Text = da.GetString(1);
                   TxtmailID.Text = da.GetString(2);
                   Txtpassword.Text = da.GetString(3);
                   con.Close();
          
               da.Close();
           }
           else
           {
               throw new Exception("Invalid User");
           }
        }

        protected void buttonupdate_Click(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("update Register set Username='" + Txtusername.Text + "',Mobilenumber='" + Txtmobilenum.Text + "',Email='" + TxtmailID.Text + "',Password='" + Txtpassword.Text + "' where Username='" + Txtlogusername.Text + "' ");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MailMessage msg = new MailMessage();
            msg.To.Add(TxtmailID.Text);
            msg.From = new MailAddress("iamlogeshwaran.info@gmail.com");
            msg.Body = "Hai, " + Txtusername.Text + "\n" + "This is a mail to confirm that your data updation is done successfully" + "\n\n\n" + "Thanks and Regards,\nLogeshwaran M";
            msg.Subject = "Updation Successful";
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


            ClientScript.RegisterStartupScript(this.GetType(), "messagebox", "alert('Message:" + "Updated sucessfully" + "');", true);
            con.Close();


        }

        protected void Buttondlt_Click(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("delete Register where Username='"+Txtlogusername+"'");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MailMessage msg = new MailMessage();
            msg.To.Add(TxtmailID.Text);
            msg.From = new MailAddress("iamlogeshwaran.info@gmail.com");
            msg.Body = "Hai, " + Txtusername.Text + "\n" + "This is a mail to inform that your data were removed from us successfully" + "\n\n\n" + "Thanks and Regards,\nLogeshwaran M";
            msg.Subject = "Removed Successful";
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
            ClientScript.RegisterStartupScript(GetType(), "messagebox", "alert('message:" + "Deleted your all data succefully" + "');", true);
            Txtusername.Text = "";
            Txtmobilenum.Text = "";
            TxtmailID.Text = "";
            Txtpassword.Text = "";
            Txtlogusername.Text = "";
            con.Close();
        }
    }
}