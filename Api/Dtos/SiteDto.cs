using Model.Entities;

namespace Api.Dtos;

public record SiteDto(int Id, string Url, string Title, string Description, EColor Color);