using AccreditDemoAPI.Helpers;
using AccreditDemoAPI.Interface;
using AccreditDemoAPI.Model;
using AccreditDemoAPI.RequestResponses;
using AccreditDemoAPI.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccreditDemoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitHubController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        private readonly IGitHubService _gitHubService;
        private readonly GitHubUserDetailsResponse gitHubUserDetailsResponse = new GitHubUserDetailsResponse();
        private GitHubRepoDetailsRequest gitHubRepoDetailsRequest = new GitHubRepoDetailsRequest();


        public GitHubController(IConfiguration configuration, ILogger<GitHubController> logger, IGitHubService gitHubService)
        {
            _configuration = configuration;
            _logger = logger;
            _gitHubService = gitHubService;
        }

        [HttpPost("GetGitHubUsernameDetails")]
        public async Task<IActionResult> GetGitHubUsernameDetails(GitHubUserDetailsRequest gitHubUserDetailsRequest)
        {
            gitHubUserDetailsResponse.gitHubUserDetails = new GitHubUserDetails();
            gitHubUserDetailsResponse.gitHubRepoDetailsList = new GitHubRepoDetailsList();
            gitHubUserDetailsResponse.gitHubstargazersCountList = new GitHubstargazersDetailsList();
            gitHubUserDetailsResponse.gitHubAvatarDetails = new GitHubAvatarDetails();

            try
            {
                _logger.LogInformation("Invoking action " + MethodName.GetCallerName());

                gitHubUserDetailsResponse.gitHubUserDetails = await _gitHubService.GetGitHubDetails(gitHubUserDetailsRequest, _configuration);

                if (gitHubUserDetailsResponse.gitHubUserDetails != null && gitHubUserDetailsResponse.gitHubUserDetails.Id != 0)
                {
                    _logger.LogInformation("Get Git Hub Details for: " + gitHubUserDetailsRequest.Username + " loaded");

                    gitHubUserDetailsRequest.UserId = gitHubUserDetailsResponse.gitHubUserDetails.Id;

                    gitHubUserDetailsResponse.gitHubRepoDetailsList = await GetGitHubRepoDetailsList(gitHubUserDetailsRequest);

                    //Get list of stargazers_url's
                    gitHubUserDetailsResponse.gitHubstargazersCountList = await GetStargazersCount(gitHubUserDetailsRequest, gitHubUserDetailsResponse.gitHubRepoDetailsList);

                    //Avatar Details
                    gitHubUserDetailsResponse.gitHubAvatarDetails = await GetAvatarDetails(gitHubUserDetailsRequest);

                    return Ok(gitHubUserDetailsResponse);
                }

                _logger.LogInformation("Get Git Hub Details for: " + gitHubUserDetailsRequest.Username + " not found");
                return NotFound();
            }
            catch (Exception e)
            {
                _logger.LogInformation("Get Git Hub Details for: " + gitHubUserDetailsRequest.Username + " loading error: " + e.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, e.ToString());
            }
        }

        private async Task<GitHubRepoDetailsList> GetGitHubRepoDetailsList(GitHubUserDetailsRequest gitHubUserDetailsRequest)
        {
            _logger.LogInformation("Invoking action " + MethodName.GetCallerName());
            _logger.LogInformation("Get Git Hub Repo Details for: " + gitHubUserDetailsRequest.Username + " loaded");
            return await _gitHubService.GitHubRepoDetailsList(gitHubUserDetailsRequest, _configuration);
        }

        private async Task<GitHubstargazersDetailsList> GetStargazersCount(GitHubUserDetailsRequest gitHubUserDetailsRequest, GitHubRepoDetailsList gitHubRepoDetailsList)
        {
            _logger.LogInformation("Invoking action " + MethodName.GetCallerName());
            _logger.LogInformation("Get Stargazers Count for: " + gitHubUserDetailsRequest.Username);

            GitHubstargazersDetailsList gitHubstargazersCountList = new GitHubstargazersDetailsList();

            List<GitHubstargazersDetails> gitHubstargazersDetails = new List<GitHubstargazersDetails>();

            for (int i = 0; i < gitHubRepoDetailsList.gitHubRepoDetails.Count; i++)
            {
                GitHubRepoDetails gitHubRepoDetail = new GitHubRepoDetails();
                gitHubRepoDetailsRequest.repoName = gitHubRepoDetailsList.gitHubRepoDetails[i].Name;

                gitHubstargazersDetails.Add(new GitHubstargazersDetails
                {
                    repoUrl = gitHubRepoDetailsList.gitHubRepoDetails[i].StargazersUrl,
                    repoName = gitHubRepoDetailsList.gitHubRepoDetails[i].Name,
                    repoId = gitHubRepoDetailsList.gitHubRepoDetails[i].Id,
                    stargazer_count = gitHubRepoDetailsList.gitHubRepoDetails[i].StargazersCount,
                    description = gitHubRepoDetailsList.gitHubRepoDetails[i].Description
                });
            }

            gitHubstargazersCountList.gitHubstargazersDetails = gitHubstargazersDetails.OrderByDescending(i => i.stargazer_count).Take(5).ToList();

            return gitHubstargazersCountList;
        }

        private async Task<GitHubAvatarDetails> GetAvatarDetails(GitHubUserDetailsRequest gitHubUserDetailsRequest)
        {
            _logger.LogInformation("Invoking action " + MethodName.GetCallerName());
            _logger.LogInformation("Get Avatar Details for: " + gitHubUserDetailsRequest.Username);
            return await _gitHubService.GetGitHubAvatarDetails(gitHubUserDetailsRequest,_configuration);
        }
    }
}