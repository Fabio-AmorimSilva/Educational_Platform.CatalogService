namespace EducationalPlatform.Services.CatalogService.Api.Controllers;

public class ModulesController(
    UseCaseValidation validation
) : BaseController(validation)
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
        => await Execute<IListModulesUseCase, Unit, UseCaseResult<IEnumerable<ListModulesUseCaseModel>>>(Unit.Value);

    [HttpGet("{moduleId:guid}")]
    public async Task<IActionResult> Get(Guid moduleId)
        => await Execute<IGetModuleUseCase, Guid, UseCaseResult<GetModuleUseCaseModel>>(moduleId);

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateModuleUseCaseModel model)
        => await Execute<ICreateModuleUseCase, CreateModuleUseCaseModel, UseCaseResult<Guid>>(model);

    [HttpPut("{moduleId:guid}")]
    public async Task<IActionResult> Put(Guid moduleId, [FromBody] UpdateModuleUseCaseModelPayload payload)
        => await Execute<IUpdateModuleUseCase, UpdateModuleUseCaseModel, UseCaseResult>(payload.AsModel(moduleId));

    [HttpDelete("{moduleId:guid}")]
    public async Task<IActionResult> Delete(Guid moduleId)
        => await Execute<IDeleteModuleUseCase, Guid, UseCaseResult>(moduleId);
}