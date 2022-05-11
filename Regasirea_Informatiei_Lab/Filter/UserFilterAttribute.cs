using System.Linq;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Regasirea_Informatiei_Lab.Data;
using Regasirea_Informatiei_Lab.Models;

namespace Regasirea_Informatiei_Lab.Filter
{
    public class UserFilterAttribute : IActionFilter
    {
        private readonly DBContext context;

        public UserFilterAttribute(DBContext context)
        {
            this.context = context;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            string data = "";

            var routeData = context.RouteData;
            var controller = routeData.Values["controller"];
            var action = routeData.Values["action"];

            var url = $"{controller}/{action}";

            if (!string.IsNullOrEmpty(context.HttpContext.Request.QueryString.Value))
            {
                data = context.HttpContext.Request.QueryString.Value;
            }
            else
            {
                var arguments = context.ActionArguments;

                var value = arguments.FirstOrDefault().Value;

                var convertedValue = JsonConvert.SerializeObject(value);
                data = convertedValue;
            }

            var user = context.HttpContext.User.Identity.Name;

            var ipAddress = context.HttpContext.Connection.RemoteIpAddress.ToString();

            SaveUserActivity(data, url, user, ipAddress);
        }

        public void SaveUserActivity(string data, string url, string user, string ipAddress)
        {
            var userActivity = new UserActivity
            {
                Data = data,
                Url = url,
                UserName = user,
                IpAddress = ipAddress
            };

            context.userActivities.Add(userActivity);
            context.SaveChanges();
        }
    }
}
