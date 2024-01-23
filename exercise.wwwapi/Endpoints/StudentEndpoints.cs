using exercise.wwwapi.Models.StudentModels;
using exercise.wwwapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.wwwapi.Endpoints
{
    public static class StudentEndpoints
    {
        public static void ConfigureStudentEndpoints(this WebApplication app)
        {
            var studentGroup = app.MapGroup("students");
            studentGroup.MapPost("/", AddStudent);
            studentGroup.MapGet("/", GetStudents);
            studentGroup.MapGet("/{firstName}", GetAStudents);
            studentGroup.MapDelete("/{firstName}", DeleteStudent);
            studentGroup.MapPut("/{firstName}", UpdateStudent);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetStudents(IRepository repository)
        {
            var payload = repository.GetStudents();

            return TypedResults.Ok(payload);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> AddStudent(IRepository repository, StudentPost model)
        {                      
            
            return TypedResults.Ok();
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAStudents(IRepository repository, string firstName)
        {
            return TypedResults.Ok();
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteStudent(IRepository repository, string firstName)
        {
            var result = repository.DeleteStudent(firstName);
            if (result == null)
            {
                return Results.NotFound($"student {firstName} not found");
            }
            return TypedResults.Ok(result);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateStudent(IRepository repository, string firstName, StudentPut model)
        {
            var result = repository.UpdateStudent(firstName, model);
            if(result==null)
            {
                return Results.NotFound($"student {firstName} not found");
            }
            return TypedResults.Ok(result);
        }
    }
}
