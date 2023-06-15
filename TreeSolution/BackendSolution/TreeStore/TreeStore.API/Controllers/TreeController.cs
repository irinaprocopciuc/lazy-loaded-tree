using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using TreeStore.API.Services.Interfaces;

namespace TreeStore.API.Controllers;

[ApiController]
[Route("api/tree")]
public class TreeController : ControllerBase
{
    private readonly ITreeService trees;

    public TreeController(ITreeService trees)
    {
        this.trees = trees;
    }

    [HttpGet("{nodeid}")]
    public IActionResult GetChilds(string nodeid)
    {
        return Ok(trees.GetChildNodes(int.Parse(nodeid)));
    }

    [HttpGet]
    public IActionResult GetRoot()
    {
        return Ok(trees.GetRootNodes());
    }
}
