using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResumeParser
{
    public partial class User : System.Web.UI.Page
    {
        public string ReplaceKeyWords(Match m)
        {
            return ("<h1>" + m.Value + "</h1>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string OpenPath;               
                try
                {
                    OpenPath = Server.MapPath(".") + @"\ParsedData.txt";
                    string FILENAME = OpenPath;
                    StreamReader objStreamReader;
                    objStreamReader = File.OpenText(FILENAME);
                    DataTable table = JsonConvert.DeserializeObject<DataTable>(objStreamReader.ReadToEnd());
                    objStreamReader.Close();
                    GridView1.DataSource = table;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
       
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string OpenPath;
            try
            {
                OpenPath = Server.MapPath(".") + @"\ParsedData.txt";
                string FILENAME = OpenPath;
                StreamReader objStreamReader;
                objStreamReader = File.OpenText(FILENAME);
                var table = JsonConvert.DeserializeObject<List<UserModel>>(objStreamReader.ReadToEnd());
                var userdata = new List<UserModel>();                              
                if (searchBox.Text.Trim().Length > 0 && table.Exists(piX => piX.Name.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())))
                    userdata = table.Where(piX => piX.Name.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())).ToList();
                else if (searchBox.Text.Trim().Length > 0 && table.Exists(piX => piX.Phone.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())))
                    userdata = table.Where(piX => piX.Phone.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())).ToList();
                else if (searchBox.Text.Trim().Length > 0 && table.Exists(piX => piX.Email.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())))
                    userdata = table.Where(piX => piX.Email.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())).ToList();
                else if (searchBox.Text.Trim().Length > 0 && table.Exists(piX => piX.Skills.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())))
                    userdata = table.Where(piX => piX.Skills.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())).ToList();
                else if (searchBox.Text.Trim().Length > 0 && table.Exists(piX => piX.Summary.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())))
                    userdata = table.Where(piX => piX.Summary.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())).ToList();
                else if (searchBox.Text.Trim().Length > 0 && table.Exists(piX => piX.Experience.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())))
                    userdata = table.Where(piX => piX.Experience.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())).ToList();
                else if (searchBox.Text.Trim().Length > 0 && table.Exists(piX => piX.Education.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())))
                    userdata = table.Where(piX => piX.Education.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())).ToList();
                else if (searchBox.Text.Trim().Length > 0 && table.Exists(piX => piX.Interests.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())))
                    userdata = table.Where(piX => piX.Interests.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())).ToList();
                else if (searchBox.Text.Trim().Length > 0 && table.Exists(piX => piX.Languages.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())))
                    userdata = table.Where(piX => piX.Languages.ToLower().Contains(searchBox.Text.Trim().Trim().ToLower())).ToList();

                if (searchBox.Text.Trim().Length == 0)
                    GridView1.DataSource = table;
                else
                    GridView1.DataSource = userdata;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected void GridViewStudent_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[0].Text = Regex.Replace(e.Row.Cells[0].Text, searchBox.Text.Trim(), delegate (Match match)
                {
                    return string.Format("<span style = 'background-color:green; color:white;'>{0}</span>", match.Value);
                }, RegexOptions.IgnoreCase);
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[1].Text = Regex.Replace(e.Row.Cells[1].Text, searchBox.Text.Trim(), delegate (Match match)
                {
                    return string.Format("<span style = 'background-color:green; color:white;'>{0}</span>", match.Value);
                }, RegexOptions.IgnoreCase);
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[2].Text = Regex.Replace(e.Row.Cells[2].Text, searchBox.Text.Trim(), delegate (Match match)
                {
                    return string.Format("<span style = 'background-color:green; color:white;'>{0}</span>", match.Value);
                }, RegexOptions.IgnoreCase);
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[3].Text = Regex.Replace(e.Row.Cells[3].Text, searchBox.Text.Trim(), delegate (Match match)
                {
                    return string.Format("<span style = 'background-color:green; color:white;'>{0}</span>", match.Value);
                }, RegexOptions.IgnoreCase);
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[4].Text = Regex.Replace(e.Row.Cells[4].Text, searchBox.Text.Trim(), delegate (Match match)
                {
                    return string.Format("<span style = 'background-color:green; color:white;'>{0}</span>", match.Value);
                }, RegexOptions.IgnoreCase);
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[5].Text = Regex.Replace(e.Row.Cells[5].Text, searchBox.Text.Trim(), delegate (Match match)
                {
                    return string.Format("<span style = 'background-color:green; color:white;'>{0}</span>", match.Value);
                }, RegexOptions.IgnoreCase);
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[6].Text = Regex.Replace(e.Row.Cells[6].Text, searchBox.Text.Trim(), delegate (Match match)
                {
                    return string.Format("<span style = 'background-color:green; color:white;'>{0}</span>", match.Value);
                }, RegexOptions.IgnoreCase);
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[7].Text = Regex.Replace(e.Row.Cells[7].Text, searchBox.Text.Trim(), delegate (Match match)
                {
                    return string.Format("<span style = 'background-color:green; color:white;'>{0}</span>", match.Value);
                }, RegexOptions.IgnoreCase);
            }
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[8].Text = Regex.Replace(e.Row.Cells[8].Text, searchBox.Text.Trim(), delegate (Match match)
                {
                    return string.Format("<span style = 'background-color:green; color:white;'>{0}</span>", match.Value);
                }, RegexOptions.IgnoreCase);
            }
        }
    }
    public class UserModel
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Skills { set; get; }
        public string Summary { set; get; }
        public string Experience { set; get; }
        public string Education { set; get; }
        public string Interests { set; get; }
        public string Languages { set; get; }                          
    }
}