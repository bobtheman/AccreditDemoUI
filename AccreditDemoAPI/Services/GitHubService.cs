using AccreditDemoAPI.Helpers;
using AccreditDemoAPI.Interface;
using AccreditDemoAPI.Model;
using AccreditDemoAPI.Requests;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccreditDemoAPI.Services
{
    public class GitHubService : IGitHubService
    {
        public Task<GitHubUserDetails> GetGitHubDetails(GitHubUserDetailsRequest gitHubUserDetailsRequest, IConfiguration configuration)
        {
            GitHubUserDetails gitHubUserDetails = new GitHubUserDetails();
            var client = new RestClient(configuration["GitHub:UserDetailsUrl"] + gitHubUserDetailsRequest.Username);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/vnd.github.v3+json");
            request.AddHeader("Authorization", "token " + configuration["GitHub:Token"]);
            IRestResponse response = client.Execute(request);
            string jsonString = response.Content;
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;
            return Task.FromResult(JsonConvert.DeserializeObject<GitHubUserDetails>(jsonString, settings));
        }

        public Task<GitHubRepoDetailsList> GitHubRepoDetailsList(GitHubUserDetailsRequest gitHubUserDetailsRequest, IConfiguration configuration)
        {
            var client = new RestClient(configuration["GitHub:UserDetailsUrl"] + gitHubUserDetailsRequest.Username + "/repos");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/vnd.github.v3+json");
            request.AddHeader("Authorization", "token " + configuration["GitHub:Token"]);
            IRestResponse response = client.Execute(request);
            GitHubRepoDetailsList gitHubRepoDetailsList = new GitHubRepoDetailsList();
            gitHubRepoDetailsList.gitHubRepoDetails = JsonConvert.DeserializeObject<List<GitHubRepoDetails>>(response.Content);
            return Task.FromResult(gitHubRepoDetailsList);
        }

        public Task<GitHubAvatarDetails> GetGitHubAvatarDetails(GitHubUserDetailsRequest gitHubUserDetailsRequest, IConfiguration configuration)
        {
            var client = new RestClient(configuration["GitHub:AvatarsUrl"] + gitHubUserDetailsRequest.UserId + "?v=4");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/vnd.github.v3+json");
            request.AddHeader("Authorization", "token " + configuration["GitHub:Token"]);
            IRestResponse response = client.Execute(request);
            GitHubAvatarDetails gitHubAvatarDetails = new GitHubAvatarDetails();
            gitHubAvatarDetails.profileImageByte = response.RawBytes;
            return Task.FromResult(gitHubAvatarDetails);
        }

    }
}