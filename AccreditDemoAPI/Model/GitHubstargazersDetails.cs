using System;

namespace AccreditDemoAPI.Model
{
    public class GitHubstargazersDetails
    {
        public Uri repoUrl { get; set; }
        public string repoName { get; set; }
        public long repoId { get; set; }
        public long stargazer_count { get; set; }
        public string description { get; set; }
    }
}