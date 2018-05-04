using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Move2._0.Dto;
using Move2._0.Dto.Moodle;
using Move2._0.DAL;
using System.IO;
using System.Web.Script.Serialization;
using System.Text;

namespace Move2._0.Controllers.Api
{
    public class MoodleController : ApiController
    {
        private string _token = "f8119557a0ace481f11e3e1e075ed274";
        private string _domainname = "http://beta.campus.movelanguage.com";


        [HttpPost]
        [Route("api/moodle/users")]
        public IHttpActionResult CreateUser(MoodleUserDto user)
        {

            string _functionname = "core_user_create_users";
            string serverurl = _domainname + "/webservice/rest/server.php" + "?wstoken=" + _token + "&wsfunction=" + _functionname + "&moodlewsrestformat=json";
            string username = (user.Email.Split('@'))[0];
            String postData = String.Format("users[0][username]={0}&users[0][password]={1}&users[0][firstname]={2}&users[0][lastname]={3}&users[0][email]={4}", username, "MoveLanguage2018", user.Name, user.LastName, user.Email);

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(serverurl);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            // Encode the parameters as form data:
            byte[] formData = UTF8Encoding.UTF8.GetBytes(postData);
            req.ContentLength = formData.Length;

            // Write out the form Data to the request:
            using (Stream post = req.GetRequestStream())
            {
                post.Write(formData, 0, formData.Length);
            }

            // Get the Response
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream resStream = resp.GetResponseStream();
            StreamReader reader = new StreamReader(resStream);
            //JsonTextReader jsreader = new JsonTextReader(reader);
            string contents = reader.ReadToEnd();

            // Deserialize
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            if (contents.Contains("exception"))
            {
                // Error
                MoodleException moodleError = serializer.Deserialize<MoodleException>(contents);
                return BadRequest(moodleError.debuginfo);
            }
            else
            {
                List<MoodleCreateUserResponse> newUsers = serializer.Deserialize<List<MoodleCreateUserResponse>>(contents);
                user.Id = Convert.ToInt32(newUsers.First().id);
                return Ok();
            }





        }


        [HttpPost]
        [Route("api/moodle/enrolments")]
        public IHttpActionResult CreateEnrolment(EnrolmentDto enrolment)
        {
            string _functionname = "enrol_manual_enrol_users";
            string serverurl = _domainname + "/webservice/rest/server.php" + "?wstoken=" + _token + "&wsfunction=" + _functionname + "&moodlewsrestformat=json";

            long initDate = (int)((TimeSpan)(DateTime.Now - new DateTime(1970, 1, 1))).TotalSeconds;
            long endDate = (int)((TimeSpan)(DateTime.Now.AddMonths(3) - new DateTime(1970, 1, 1))).TotalSeconds;

            String enrolData = String.Format("enrolments[0][roleid]={0}&enrolments[0][userid]={1}&enrolments[0][courseid]={2}&enrolments[0][timestart]={3}&enrolments[0][timeend]={4}", enrolment.RoleId, enrolment.UserId, enrolment.CourseId, initDate, endDate);

            // Call Moodle REST Service

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(serverurl);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            // Encode the parameters as form data:

            byte[] formData = UTF8Encoding.UTF8.GetBytes(enrolData);  //or use "userData"
            req.ContentLength = formData.Length;


            // Write out the form Data to the request:
            using (Stream post = req.GetRequestStream())
            {
                post.Write(formData, 0, (int)req.ContentLength);
            }


            // Get the Response
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream resStream = resp.GetResponseStream();
            StreamReader reader = new StreamReader(resStream);
            //JsonTextReader jsreader = new JsonTextReader(reader);
            string contents = reader.ReadToEnd();

            // Deserialize
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            if (contents.Contains("exception"))
            {
                // Error
                MoodleException moodleError = serializer.Deserialize<MoodleException>(contents);
                return BadRequest(moodleError.debuginfo);
            }
            else
            {
                return Ok();
            }



        }


    }

    class MoodleException
    {
        public string exception { get; set; }
        public string errorcode { get; set; }
        public string message { get; set; }
        public string debuginfo { get; set; }
    }

    class MoodleCreateUserResponse
    {
        public string id { get; set; }
        public string username { get; set; }
    }
}
