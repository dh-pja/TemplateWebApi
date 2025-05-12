namespace TemplateWebApi.Repositories.Interfaces;

public interface ISampleRepository
{
    Task<bool> GetSample(CancellationToken cancellationToken);
}