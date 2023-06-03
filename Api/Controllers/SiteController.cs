using Api.Dtos;
using Domain.Repositories.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace Api.Controllers;

[ApiController]
[Route("/sites")]
public class SiteController : ControllerBase
{
    private readonly ISiteRepository _repository;

    public SiteController(ISiteRepository repository)
    {
        _repository = repository;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<SiteDto>>> GetSites()
    {
        try
        {
            return Ok(await _repository.ReadAsync());
        }
        catch (NotImplementedException e)
        {
            return StatusCode(501, "NotImplementedException");
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<SiteDto>> GetSite(int id)
    {
        try
        {
            return Ok(await _repository.ReadAsync(id));
        }
        catch (KeyNotFoundException)
        {
            return BadRequest();
        }
        catch (NotImplementedException)
        {
            return StatusCode(501, "NotImplementedException");
        }
    }

    [HttpPost]
    public async Task<ActionResult<SiteDto>> CreateSite(SiteDto siteDto)
    {
        try
        {
            return Ok(await _repository.CreateAsync(siteDto.Adapt<Site>()));
        }
        catch (NotImplementedException e)
        {
            return StatusCode(501, "NotImplementedException");
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteSite(int id)
    {
        try
        {
            var site = await _repository.ReadAsync(id);
            if (site == null)
                throw new KeyNotFoundException();
            await _repository.DeleteAsync(site);
            return Ok();
        }
        catch (KeyNotFoundException)
        {
            return BadRequest();
        }
        catch (NotImplementedException)
        {
            return StatusCode(501, "NotImplementedException");
        }
    }
}