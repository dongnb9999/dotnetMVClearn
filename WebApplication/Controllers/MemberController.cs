using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;



namespace WebApplication.Controllers
{
    public class MemberController : Controller
    {
        private static List<Member> members = new List<Member>();

        // GET: Member

        [HttpGet]
        public ActionResult Create()
        {
            var result = new JsonResult()
            {
                Data = members,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
            return View();
        }

        [HttpPost]
        public ActionResult Store(Member member)
        {

            ViewBag.member = member;
            member.Id = DateTime.Now.Millisecond;
            members.Add(member);
            return new JsonResult()
            {
                Data = member,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpPut]
        public ActionResult Update(long id, Member updateMember)
        {
            for (int i = 0; i < members.Count; i++)
            {
                if (members[i].Id.Equals(id))
                {
                    members[i] = updateMember;
                }
            }
            return new JsonResult()
            {
                Data = updateMember,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        [HttpDelete]
        public ActionResult Delete(long id)
        {
            int removeIndex = -1;
            for(int i = 0; i < members.Count; i++)
            {
                if (members[i].Id.Equals(id))
                {
                    removeIndex = i;
                }
            }
            if(removeIndex != -1)
            {
                members.RemoveAt(removeIndex);
            }
            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}