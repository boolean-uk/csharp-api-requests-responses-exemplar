
using exercise.wwwapi.Models.LanguageModels;
using exercise.wwwapi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace exercise.wwwapi.Endpoints
{
    public static class LanguageEndpoints
    {
        public static void ConfigureLanguageEndpoints(this WebApplication app)
        {
            var languageGroup = app.MapGroup("languages");
            languageGroup.MapPost("/", AddLanguage);
            languageGroup.MapGet("/", GetLanguages);
            languageGroup.MapGet("/{name}", GetALanguage);
            languageGroup.MapDelete("/{name}", DeleteLanguage);
            languageGroup.MapPut("/{name}", UpdateLanguage);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddLanguage(IRepository repository, LanguagePost model)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var newLanguage = new Language() { name = model.name };
                    var result = repository.AddLanguage(newLanguage);
                    if (result == null)
                    {
                        return Results.Problem("Failed to AddLanguage");
                    }
                    return TypedResults.Created($"/{result.name}", result);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetLanguages(IRepository repository)
        {           
            try
            {
                return await Task.Run(() =>
                {                   
                    var result = repository.GetLanguages();
                    return result != null ? Results.Ok(result) : Results.StatusCode(404);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetALanguage(IRepository repository, string name)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var result = repository.GetLanguage(name);
                    return TypedResults.Ok(result);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
           
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteLanguage(IRepository repository, string name)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var target = repository.DeleteLanguage(name);
                    return TypedResults.Ok(target);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateLanguage(IRepository repository, string name, LanguagePut model)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var target = repository.UpdateLanguage(name, model);
                    return TypedResults.Ok(target);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
