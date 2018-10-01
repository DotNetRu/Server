#pragma warning disable SA1028 // Code must not contain trailing whitespace
/*
 * Meetup Management Service API
 *
 * Meetup Management Service API
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
#pragma warning restore SA1028 // Code must not contain trailing whitespace

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using DotNetRu.MeetupManagement.WebApi.Contract.Attributes;
using DotNetRu.MeetupManagement.WebApi.Contract.Models;

namespace DotNetRu.MeetupManagement.WebApi.Contract.Controllers
#pragma warning disable SA1028 // Code must not contain trailing whitespace
{ 
    /// <inheritdoc />
    /// <summary>
    /// 
    /// </summary>
#pragma warning restore SA1028 // Code must not contain trailing whitespace
#pragma warning disable SA1649
    public abstract class VenueApiController : ControllerBase
#pragma warning restore SA1649
#pragma warning disable SA1028 // Code must not contain trailing whitespace
    { 
        /// <summary>
        /// Create venue draft
        /// </summary>
        
        /// <param name="venueDraft"></param>
        /// <response code="201">Draft was successfully created</response>
        /// <response code="400">Invalid request parameters</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="409">Draft is already exists</response>
        [HttpPost]
        [Route("/venues/draft")]
        [ValidateModelState]
        [SwaggerOperation("CreateVenueDraft")]
        public abstract void CreateVenueDraft([FromBody]CreateVenueDraftParameters venueDraft);

        /// <summary>
        /// Delete venue draft
        /// </summary>
        
        /// <param name="venueId"></param>
        /// <response code="204">Draft was successfully deleted</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Venue not found</response>
        [HttpDelete]
        [Route("/venues/{venueId}/draft")]
        [ValidateModelState]
        [SwaggerOperation("DeleteVenueDraft")]
        public abstract void DeleteVenueDraft([FromRoute][Required]string venueId);

        /// <summary>
        /// Get venue draft
        /// </summary>
        
        /// <param name="venueId"></param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Venue not found</response>
        [HttpGet]
        [Route("/venues/{venueId}/draft")]
        [ValidateModelState]
        [SwaggerOperation("GetVenueDrafts")]
        [SwaggerResponse(statusCode: 200, type: typeof(VenueDraft), description: "OK")]
        public abstract VenueDraft GetVenueDrafts([FromRoute][Required]string venueId);

        /// <summary>
        /// Update venue draft
        /// </summary>
        
        /// <param name="venueId"></param>
        /// <param name="properties"></param>
        /// <response code="204">Draft was successfully updated</response>
        /// <response code="400">Invalid request parameters</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Venue not found</response>
        [HttpPut]
        [Route("/venues/{venueId}/draft")]
        [ValidateModelState]
        [SwaggerOperation("UpdateVenueDraft")]
        public abstract void UpdateVenueDraft([FromRoute][Required]string venueId, [FromBody]UpdateVenueDraftParameters properties);
    }
#pragma warning restore SA1028 // Code must not contain trailing whitespace
}
