namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddApplication()
        {
            services
                .AddUseCases()
                .AddBehaviours()
                .AddFluentValidationDependencyInjection();
        
            return services;
        }

        private IServiceCollection AddUseCases()
        {
            services.AddScoped<ICreateClassUseCase, CreateClassUseCase>();
            services.AddScoped<IDeleteClassUseCase, DeleteClassClassUseCase>();
            services.AddScoped<IUpdateClassUseCase, UpdateClassUseCase>();
            services.AddScoped<IGetClassUseCase, GetClassUseCase>();
            services.AddScoped<IListClassesUseCase, ListClassesUseCase>();
            
            services.AddScoped<IGetCourseUseCase, GetCourseUseCase>();
            services.AddScoped<IListCoursesUseCase, ListCoursesUseCase>();
            services.AddScoped<ICreateCourseUseCase, CreateCourseUseCase>();
            services.AddScoped<UpdateCourseUseCase, UpdateCourseUseCase>();
            services.AddScoped<DeleteCourseUseCase, DeleteCourseUseCase>();
            
            services.AddScoped<IGetModuleUseCase, GetModuleUseCase>();
            services.AddScoped<IListModulesUseCase, ListModulesUseCase>();
            services.AddScoped<CreateModuleUseCase, CreateModuleUseCase>();
            services.AddScoped<UpdateModuleUseCase, UpdateModuleUseCase>();
            services.AddScoped<IDeleteModuleUseCase, DeleteModuleUseCase>();
            
            return services;
        }

        private IServiceCollection AddBehaviours()
        {
            services.AddScoped<UseCaseValidation>();
            
            return services;
        }

        private IServiceCollection AddFluentValidationDependencyInjection()
        {
            services.AddValidatorsFromAssemblies([Assembly.GetExecutingAssembly()]);
            
            return services;
        }
    }
}