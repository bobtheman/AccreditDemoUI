using AccreditDemoAPI.Model;
using AccreditDemoAPI.Requests;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace AccreditDemoAPI.Interface
{
    public interface IGitHubService
    {
        Task<GitHubUserDetails> GetGitHubDetails(GitHubUserDetailsRequest gitHubUserDetailsRequest, IConfiguration configuration);
        Task<GitHubRepoDetailsList> GitHubRepoDetailsList(GitHubUserDetailsRequest gitHubUserDetailsRequest, IConfiguration configuration);
        Task<GitHubAvatarDetails> GetGitHubAvatarDetails(GitHubUserDetailsRequest gitHubUserDetailsRequest, IConfiguration configuration);
    }
}