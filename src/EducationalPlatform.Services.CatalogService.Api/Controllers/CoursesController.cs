namespace EducationalPlatform.Services.CatalogService.Api.Controllers;

[ApiController]
[Route("api/courses")]
public class CoursesController(
    UseCaseValidation validation
) : BaseController(validation)
{
    [HttpGet("{courseId:guid}")]
    public async Task<IActionResult> GetCourse(Guid courseId)
        => await Execute<IGetCourseUseCase, Guid, UseCaseResult<GetCourseUseCaseModel>>(courseId);

    [HttpGet]
    public async Task<IActionResult> ListCourses()
        => await Execute<IListCoursesUseCase, Unit, UseCaseResult<IEnumerable<ListCoursesUseCaseModel>>>(Unit.Value);

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateCourseUseCaseModel model)
        => await Execute<ICreateCourseUseCase, CreateCourseUseCaseModel, UseCaseResult<Guid>>(model);

    [HttpPut("{courseId:guid}")]
    public async Task<IActionResult> Put(Guid courseId, [FromBody] UpdateCourseUseCaseModelPayload payload)
        => await Execute<IUpdateCourseUseCase, UpdateCourseUseCaseModel, UseCaseResult<Unit>>(payload.AsModel(courseId));

    [HttpDelete("{courseId:guid}")]
    public async Task<IActionResult> Delete(Guid courseId)
        => await Execute<IDeleteCourseUseCase, Guid, UseCaseResult<Unit>>(courseId);
}