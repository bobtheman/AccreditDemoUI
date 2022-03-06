using Newtonsoft.Json;
using System;

namespace AccreditDemoUI.RequestResponses
{
    public partial class GitHubUserDetailsReponse
    {
        [JsonProperty("gitHubUserDetails")]
        public GitHubUserDetails GitHubUserDetails { get; set; }

        [JsonProperty("gitHubRepoDetailsList")]
        public GitHubRepoDetailsList GitHubRepoDetailsList { get; set; }

        [JsonProperty("gitHubstargazersCountList")]
        public GitHubstargazersCountList GitHubstargazersCountList { get; set; }

        [JsonProperty("gitHubAvatarDetails")]
        public GitHubAvatarDetails GitHubAvatarDetails { get; set; }
    }

    public partial class GitHubAvatarDetails
    {
        [JsonProperty("profileImageByte")]
        public byte[] profileImageByte { get; set; }
    }

    public partial class GitHubRepoDetailsList
    {
        [JsonProperty("gitHubRepoDetails")]
        public GitHubRepoDetail[] GitHubRepoDetails { get; set; }
    }

    public partial class GitHubRepoDetail
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nodeId")]
        public string NodeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        [JsonProperty("htmlUrl")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fork")]
        public bool Fork { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("forksUrl")]
        public Uri ForksUrl { get; set; }

        [JsonProperty("keysUrl")]
        public string KeysUrl { get; set; }

        [JsonProperty("collaboratorsUrl")]
        public string CollaboratorsUrl { get; set; }

        [JsonProperty("teamsUrl")]
        public Uri TeamsUrl { get; set; }

        [JsonProperty("hooksUrl")]
        public Uri HooksUrl { get; set; }

        [JsonProperty("issueEventsUrl")]
        public string IssueEventsUrl { get; set; }

        [JsonProperty("eventsUrl")]
        public Uri EventsUrl { get; set; }

        [JsonProperty("assigneesUrl")]
        public string AssigneesUrl { get; set; }

        [JsonProperty("branchesUrl")]
        public string BranchesUrl { get; set; }

        [JsonProperty("tagsUrl")]
        public Uri TagsUrl { get; set; }

        [JsonProperty("blobsUrl")]
        public string BlobsUrl { get; set; }

        [JsonProperty("gitTagsUrl")]
        public string GitTagsUrl { get; set; }

        [JsonProperty("gitRefsUrl")]
        public string GitRefsUrl { get; set; }

        [JsonProperty("treesUrl")]
        public string TreesUrl { get; set; }

        [JsonProperty("statusesUrl")]
        public string StatusesUrl { get; set; }

        [JsonProperty("languagesUrl")]
        public Uri LanguagesUrl { get; set; }

        [JsonProperty("stargazersUrl")]
        public Uri StargazersUrl { get; set; }

        [JsonProperty("contributorsUrl")]
        public Uri ContributorsUrl { get; set; }

        [JsonProperty("subscribersUrl")]
        public Uri SubscribersUrl { get; set; }

        [JsonProperty("subscriptionUrl")]
        public Uri SubscriptionUrl { get; set; }

        [JsonProperty("commitsUrl")]
        public string CommitsUrl { get; set; }

        [JsonProperty("gitCommitsUrl")]
        public string GitCommitsUrl { get; set; }

        [JsonProperty("commentsUrl")]
        public string CommentsUrl { get; set; }

        [JsonProperty("issueCommentUrl")]
        public string IssueCommentUrl { get; set; }

        [JsonProperty("contentsUrl")]
        public string ContentsUrl { get; set; }

        [JsonProperty("compareUrl")]
        public string CompareUrl { get; set; }

        [JsonProperty("mergesUrl")]
        public Uri MergesUrl { get; set; }

        [JsonProperty("archiveUrl")]
        public string ArchiveUrl { get; set; }

        [JsonProperty("downloadsUrl")]
        public Uri DownloadsUrl { get; set; }

        [JsonProperty("issuesUrl")]
        public string IssuesUrl { get; set; }

        [JsonProperty("pullsUrl")]
        public string PullsUrl { get; set; }

        [JsonProperty("milestonesUrl")]
        public string MilestonesUrl { get; set; }

        [JsonProperty("notificationsUrl")]
        public string NotificationsUrl { get; set; }

        [JsonProperty("labelsUrl")]
        public string LabelsUrl { get; set; }

        [JsonProperty("releasesUrl")]
        public string ReleasesUrl { get; set; }

        [JsonProperty("deploymentsUrl")]
        public Uri DeploymentsUrl { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("pushedAt")]
        public DateTime PushedAt { get; set; }

        [JsonProperty("gitUrl")]
        public string GitUrl { get; set; }

        [JsonProperty("sshUrl")]
        public string SshUrl { get; set; }

        [JsonProperty("cloneUrl")]
        public Uri CloneUrl { get; set; }

        [JsonProperty("svnUrl")]
        public Uri SvnUrl { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("stargazersCount")]
        public long StargazersCount { get; set; }

        [JsonProperty("watchersCount")]
        public long WatchersCount { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("hasIssues")]
        public bool HasIssues { get; set; }

        [JsonProperty("hasProjects")]
        public bool HasProjects { get; set; }

        [JsonProperty("hasDownloads")]
        public bool HasDownloads { get; set; }

        [JsonProperty("hasWiki")]
        public bool HasWiki { get; set; }

        [JsonProperty("hasPages")]
        public bool HasPages { get; set; }

        [JsonProperty("forksCount")]
        public long ForksCount { get; set; }

        [JsonProperty("mirrorUrl")]
        public object MirrorUrl { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("openIssuesCount")]
        public long OpenIssuesCount { get; set; }

        [JsonProperty("license")]
        public License License { get; set; }

        [JsonProperty("allowForking")]
        public bool AllowForking { get; set; }

        [JsonProperty("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonProperty("topics")]
        public object[] Topics { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("forks")]
        public long Forks { get; set; }

        [JsonProperty("openIssues")]
        public long OpenIssues { get; set; }

        [JsonProperty("watchers")]
        public long Watchers { get; set; }

        [JsonProperty("defaultBranch")]
        public string DefaultBranch { get; set; }
    }

    public partial class License
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("spdxId")]
        public string SpdxId { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("nodeId")]
        public string NodeId { get; set; }
    }

    public partial class Owner
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nodeId")]
        public string NodeId { get; set; }

        [JsonProperty("avatarUrl")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("gravatarId")]
        public string GravatarId { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("htmlUrl")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("followersUrl")]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("followingUrl")]
        public Uri FollowingUrl { get; set; }

        [JsonProperty("gistsUrl")]
        public Uri GistsUrl { get; set; }

        [JsonProperty("starredUrl")]
        public Uri StarredUrl { get; set; }

        [JsonProperty("subscriptionsUrl")]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("organizationsUrl")]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("reposUrl")]
        public Uri ReposUrl { get; set; }

        [JsonProperty("eventsUrl")]
        public Uri EventsUrl { get; set; }

        [JsonProperty("receivedEventsUrl")]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("siteAdmin")]
        public bool SiteAdmin { get; set; }
    }

    public partial class GitHubUserDetails
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nodeId")]
        public string NodeId { get; set; }

        [JsonProperty("avatarUrl")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("gravatarId")]
        public string GravatarId { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("htmlUrl")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("followersUrl")]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("followingUrl")]
        public Uri FollowingUrl { get; set; }

        [JsonProperty("gistsUrl")]
        public Uri GistsUrl { get; set; }

        [JsonProperty("starredUrl")]
        public Uri StarredUrl { get; set; }

        [JsonProperty("subscriptionsUrl")]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("organizationsUrl")]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("reposUrl")]
        public Uri ReposUrl { get; set; }

        [JsonProperty("eventsUrl")]
        public Uri EventsUrl { get; set; }

        [JsonProperty("receivedEventsUrl")]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("siteAdmin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("blog")]
        public Uri Blog { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("hireable")]
        public string Hireable { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("twitterUsername")]
        public string TwitterUsername { get; set; }

        [JsonProperty("publicRepos")]
        public long PublicRepos { get; set; }

        [JsonProperty("publicGists")]
        public long PublicGists { get; set; }

        [JsonProperty("followers")]
        public long Followers { get; set; }

        [JsonProperty("following")]
        public long Following { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }

    public partial class GitHubstargazersCountList
    {
        [JsonProperty("gitHubstargazersDetails")]
        public GitHubstargazersDetail[] GitHubstargazersDetails { get; set; }
    }

    public partial class GitHubstargazersDetail
    {
        [JsonProperty("repoUrl")]
        public Uri RepoUrl { get; set; }

        [JsonProperty("repoName")]
        public string RepoName { get; set; }

        [JsonProperty("repoId")]
        public long RepoId { get; set; }

        [JsonProperty("stargazer_count")]
        public long StargazerCount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}