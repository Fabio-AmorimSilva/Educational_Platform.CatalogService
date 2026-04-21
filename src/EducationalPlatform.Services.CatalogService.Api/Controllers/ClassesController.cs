namespace EducationalPlatform.Services.CatalogService.Api.Controllers;

[ApiController]
[Route("api/classes")]
public class ClassesController(
    UseCaseValidation validation
) : BaseController(validation)
{
    [HttpGet("{classId:guid}")]
    public Task<IActionResult> Get(Guid classId)
        => Execute<IGetClassUseCase, Guid, UseCaseResult<GetClassUseCaseModel>>(classId);

    [HttpGet]
    public Task<IActionResult> List()
        => Execute<IListClassesUseCase, Unit, UseCaseResult<IEnumerable<ListClassesUseCaseModel>>>(Unit.Value);

    [HttpPost]
    public Task<IActionResult> Post([FromBody] CreateClassUseCaseModel model)
        => Execute<ICreateClassUseCase, CreateClassUseCaseModel, UseCaseResult<Guid>>(model);

    [HttpPut("{classId:guid}")]
    public Task<IActionResult> Put(Guid classId, [FromBody] UpdateClassUseCaseModelPayload payload)
        => Execute<IUpdateClassUseCase, UpdateClassUseCaseModel, UseCaseResult<Unit>>(
            payload.AsModel(classId));

    [HttpDelete("{classId:guid}")]
    public Task<IActionResult> Delete(Guid classId)
        => Execute<IDeleteClassUseCase, Guid, UseCaseResult<Unit>>(classId);
}