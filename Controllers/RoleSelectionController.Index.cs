using Microsoft.AspNetCore.Mvc;
using SonarLintIssueSample;

namespace InhouseWkoIt.WkisSolution.FrontendWebApplication.RoleSelection.Controllers;

/// <summary>
/// 
/// </summary>
public partial class RoleSelectionController
{
    [ModelStateValidation]
    public async Task<IActionResult> Index()
    {
        await HandleRolesAsync(Guid.NewGuid(), String.Empty, 0, Guid.NewGuid(), String.Empty, CancellationToken.None);
        return View();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="applicationId"></param>
    /// <param name="wtRealm"></param>
    /// <param name="prtctx"></param>
    /// <param name="rctx"></param>
    /// <param name="displayName"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    private Task<(List<string> roleList, IActionResult? actionResult)>
        HandleRolesAsync(Guid applicationId, string wtRealm, long? prtctx, Guid rctx, string displayName, CancellationToken cancellationToken)
    {

        // some code

        Guid? rememberedRole = GetRemeberdRoleSelection();
        if (rememberedRole != null)
        {
            // do something
        }

        return Task.FromResult<(List<string>, IActionResult)>(([], null));
    }

    private Guid? GetRemeberdRoleSelection()
    {
        if (!HttpContext.Request.Query[RememberedRoleAutoSelect].Equals(Boolean.TrueString))
        {
            return null;
        }

        return null;
    }
}

