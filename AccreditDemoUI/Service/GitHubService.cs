using AccreditDemoUI.Interface;
using AccreditDemoUI.Request;
using AccreditDemoUI.RequestResponses;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AccreditDemoUI.Service
{
    public class GitHubService : IGitHubService
    {
        public GitHubUserDetailsReponse GetGitHubUserDetails(GitHubRequest gitHubRequest)
        {
            string jsonContent = JsonConvert.SerializeObject(gitHubRequest);

            var client = new RestClient(ConfigurationManager.AppSettings["AccreditDemoAPIUrl"] + "GitHub/GetGitHubUsernameDetails");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", jsonContent, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            string jsonString = response.Content;
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;
            return JsonConvert.DeserializeObject<GitHubUserDetailsReponse>(jsonString, settings);
        }
    }
}