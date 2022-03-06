using AccreditDemoUI.Request;
using AccreditDemoUI.RequestResponses;

namespace AccreditDemoUI.Interface
{
    public interface IGitHubService
    {
        GitHubUserDetailsReponse GetGitHubUserDetails(GitHubRequest gitHubRequest);
    }
}