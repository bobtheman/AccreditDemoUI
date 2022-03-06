using AccreditDemoAPI.Model;

namespace AccreditDemoAPI.RequestResponses
{
    public class GitHubUserDetailsResponse
    {
        public GitHubUserDetails gitHubUserDetails { get; set; }
        public GitHubRepoDetailsList gitHubRepoDetailsList { get; set; }
        public GitHubstargazersDetailsList gitHubstargazersCountList { get; set; }
        public GitHubAvatarDetails gitHubAvatarDetails { get; set; }
    }
}