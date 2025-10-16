using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolms
{
    public partial class Schedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClass = ddlClass.SelectedItem.Value;
            StringBuilder sb = new StringBuilder();

            switch (selectedClass)
            {
                case "1":
                    sb.Append("<b>Class 1 Timetable</b><br/>");
                    sb.Append("09:00 – 09:45 → English<br/>");
                    sb.Append("09:45 – 10:30 → Maths<br/>");
                    sb.Append("10:30 – 11:15 → Drawing<br/>");
                    sb.Append("11:30 – 12:15 → EVS<br/>");
                    sb.Append("12:15 – 01:00 → Storytelling<br/>");
                    break;

                case "2":
                    sb.Append("<b>Class 2 Timetable</b><br/>");
                    sb.Append("09:00 – 09:45 → Mathematics<br/>");
                    sb.Append("09:45 – 10:30 → English<br/>");
                    sb.Append("10:30 – 11:15 → Science<br/>");
                    sb.Append("11:30 – 12:15 → Hindi<br/>");
                    sb.Append("12:15 – 01:00 → Computer<br/>");
                    break;

                case "3":
                    sb.Append("<b>Class 3 Timetable</b><br/>");
                    sb.Append("09:00 – 09:45 → English<br/>");
                    sb.Append("09:45 – 10:30 → Maths<br/>");
                    sb.Append("10:30 – 11:15 → Science<br/>");
                    sb.Append("11:30 – 12:15 → Social Studies<br/>");
                    sb.Append("12:15 – 01:00 → Hindi<br/>");
                    break;

                case "4":
                    sb.Append("<b>Class 4 Timetable</b><br/>");
                    sb.Append("09:00 – 09:45 → English<br/>");
                    sb.Append("09:45 – 10:30 → Maths<br/>");
                    sb.Append("10:30 – 11:15 → Drawing<br/>");
                    sb.Append("11:30 – 12:15 → EVS<br/>");
                    sb.Append("12:15 – 01:00 → Storytelling<br/>");
                    break;

                case "5":
                    sb.Append("<b>Class 5 Timetable</b><br/>");
                    sb.Append("09:00 – 09:45 → Mathematics<br/>");
                    sb.Append("09:45 – 10:30 → English<br/>");
                    sb.Append("10:30 – 11:15 → Science<br/>");
                    sb.Append("11:30 – 12:15 → Hindi<br/>");
                    sb.Append("12:15 – 01:00 → Computer<br/>");
                    break;


                case "6":
                    sb.Append("<b>Class 6 Timetable</b><br/>");
                    sb.Append("09:00 – 09:45 → English<br/>");
                    sb.Append("09:45 – 10:30 → Maths<br/>");
                    sb.Append("10:30 – 11:15 → Drawing<br/>");
                    sb.Append("11:30 – 12:15 → EVS<br/>");
                    sb.Append("12:15 – 01:00 → Storytelling<br/>");
                    break;

                case "7":
                    sb.Append("<b>Class 7 Timetable</b><br/>");
                    sb.Append("09:00 – 09:45 → Mathematics<br/>");
                    sb.Append("09:45 – 10:30 → English<br/>");
                    sb.Append("10:30 – 11:15 → Science<br/>");
                    sb.Append("11:30 – 12:15 → Hindi<br/>");
                    sb.Append("12:15 – 01:00 → Computer<br/>");
                    break;

                case "8":
                    sb.Append("<b>Class 8 Timetable</b><br/>");
                    sb.Append("09:00 – 09:45 → English<br/>");
                    sb.Append("09:45 – 10:30 → Maths<br/>");
                    sb.Append("10:30 – 11:15 → Drawing<br/>");
                    sb.Append("11:30 – 12:15 → EVS<br/>");
                    sb.Append("12:15 – 01:00 → Storytelling<br/>");
                    break;

                case "9":
                    sb.Append("<b>Class 9 Timetable</b><br/>");
                    sb.Append("09:00 – 09:45 → Mathematics<br/>");
                    sb.Append("09:45 – 10:30 → English<br/>");
                    sb.Append("10:30 – 11:15 → Science<br/>");
                    sb.Append("11:30 – 12:15 → Hindi<br/>");
                    sb.Append("12:15 – 01:00 → Computer<br/>");
                    break;

                case "10":
                    sb.Append("<b>Class 10 Timetable</b><br/>");
                    sb.Append("09:00 – 09:45 → Mathematics<br/>");
                    sb.Append("09:45 – 10:30 → Science<br/>");
                    sb.Append("10:30 – 11:15 → English<br/>");
                    sb.Append("11:30 – 12:15 → Social Studies<br/>");
                    sb.Append("12:15 – 01:00 → Hindi<br/>");
                    break;

                case "11":
                    sb.Append("<b>Class 11 Timetable</b><br/>");
                    sb.Append("09:00 – 09:45 → English<br/>");
                    sb.Append("09:45 – 10:30 → Maths<br/>");
                    sb.Append("10:30 – 11:15 → Drawing<br/>");
                    sb.Append("11:30 – 12:15 → EVS<br/>");
                    sb.Append("12:15 – 01:00 → Storytelling<br/>");
                    break;


                case "12":
                    sb.Append("<b>Class 12 Timetable</b><br/>");
                    sb.Append("09:00 – 09:45 → Physics<br/>");
                    sb.Append("09:45 – 10:30 → Chemistry<br/>");
                    sb.Append("10:30 – 11:15 → Maths<br/>");
                    sb.Append("11:30 – 12:15 → English<br/>");
                    sb.Append("12:15 – 01:00 → Computer Science<br/>");
                    break;

                default:
                    sb.Append("Please select a class to view timetable.");
                    break;
            }

            lblTimetable.Text = sb.ToString();
        }
    }

}