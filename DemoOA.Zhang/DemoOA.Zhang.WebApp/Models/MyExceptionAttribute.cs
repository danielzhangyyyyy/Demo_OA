using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace DemoOA.Zhang.WebApp.Models
{
    //HandleErrorAttribute为mvc自带的异常处理过滤器，所有的访问异常都将被该过滤器捕获，并排到队列中
    public class MyExceptionAttribute : HandleErrorAttribute
    {
        public static Queue<Exception> ExecptionQueue = new Queue<Exception>();
        /// <summary>
        /// 可以捕获异常数据
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnException(ExceptionContext filterContext)
        {
          
            base.OnException(filterContext);
            Exception ex = filterContext.Exception;
            //写到队列
            ExecptionQueue.Enqueue(ex);
            //跳转到错误页面.
            filterContext.HttpContext.Response.Redirect("/Error.html");
        }
    }
}