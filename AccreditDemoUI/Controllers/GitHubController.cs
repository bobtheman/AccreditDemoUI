using AccreditDemoUI.Helpers;
using AccreditDemoUI.Interface;
using AccreditDemoUI.Request;
using AccreditDemoUI.RequestResponses;
using AccreditDemoUI.Service;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccreditDemoUI.Controllers
{
    public class GitHubController : Controller
    {
        public GitHubController()
            : this(new GitHubService())
        {
        }

        private IGitHubService _gitHubService;

        public GitHubController(IGitHubService gitHubService)
        {
            _gitHubService = gitHubService;
        }

        //[ValidateAntiForgeryToken]
        public ActionResult GetGutHubDetails(GitHubRequest gitHubRequest)
        {
            //logger.Info("Invoking action " + MethodName.GetCallerName());

            GitHubUserDetailsReponse gitHubUserDetailsReponse = new GitHubUserDetailsReponse();
            gitHubUserDetailsReponse = _gitHubService.GetGitHubUserDetails(gitHubRequest);

            return PartialView("~/Views/Home/Dialogs/_GitHubUserDetails.cshtml", gitHubUserDetailsReponse);
        }
    }
}